using System.Collections.Concurrent;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using MuHuMbl.BitwiseSerializer.Attributes;
using MuHuMbl.BitwiseSerializer.Enums;
using MuHuMbl.BitwiseSerializer.Extensions;

namespace MuHuMbl.BitwiseSerializer
{
    public class BitwiseSerializer : IBitwiseSerializer
    {
        private readonly ConcurrentDictionary<Type, IReadOnlyCollection<BitwisePropertyInfo>> _typeMapper;
        private readonly Dictionary<Type, int> _simpleTypes;

        public BitwiseSerializer()
        {
            _simpleTypes = new Dictionary<Type, int>
            {
                { typeof(bool), 1 },
                { typeof(char), sizeof(char) * 8 },
                { typeof(sbyte), sizeof(sbyte) * 8 },
                { typeof(byte), sizeof(byte) * 8 },
                { typeof(short), sizeof(short) * 8 },
                { typeof(ushort), sizeof(ushort) * 8 },
                { typeof(int), sizeof(int) * 8 },
                { typeof(uint), sizeof(uint) * 8 },
                { typeof(long), sizeof(long) * 8 },
                { typeof(ulong), sizeof(ulong) * 8 },
            };
            _typeMapper = new ConcurrentDictionary<Type, IReadOnlyCollection<BitwisePropertyInfo>>();
        }

        public int GetSize<T>(object target = null)
        {
            return GetSize(typeof(T), target);
        }

        public int GetSize(Type targetType, object target = null)
        {
            if (_simpleTypes.TryGetValue(targetType, out var size))
            {
                return size;
            }
            var typeMap = GetTypeMap(targetType);

            size = typeMap.Sum(x => x.SizeGetter(target));

            return size;
        }

        public byte[] Serialize(object target)
        {
            try
            {
                var bytes = GetBytes(target);
                return bytes.ToArray();
            }
            catch (Exception e)
            {
                throw new SerializationException("Error serializing object", e);
            }
        }

        private IEnumerable<byte> GetBytes(object target)
        {
            var currentBitIndex = 0;
            var currentByte = (byte)0;
            var set = false;
            foreach (var bit in GetBits(target))
            {
                set = false;
                currentByte = (byte)((currentByte << 1) | (byte)(bit ? 1 : 0));
                currentBitIndex++;
                if (currentBitIndex % 8 == 0)
                {
                    currentBitIndex = 0;
                    yield return currentByte;
                    currentByte = 0;
                    set = true;
                }
            }
            
            if (!set && currentBitIndex > 0)
            {
                yield return currentByte; 
            }
        }
        
        private IEnumerable<bool> GetBits(object target)
        {
            if (target == null)
            {
                yield break;
            }
            
            var targetType = target.GetType();
            if (_simpleTypes.TryGetValue(targetType, out var size))
            {
                foreach (var bit in  target.GetBits(targetType, size, false))
                {
                    yield return bit;
                }
                yield break;
            }
            var typeMap = GetTypeMap(targetType);

            foreach (var property in typeMap.OrderBy(x => x.Order))
            {
                foreach (var bit in GetFieldBits(target, property))
                {
                    yield return bit;
                }
            }
        }

        private IEnumerable<bool> GetFieldBits(object target, BitwisePropertyInfo fieldInfo)
        {
            var size = fieldInfo.SizeGetter(target);
            var value = GetFieldValue(target, fieldInfo);
            var propertyType = value.GetType().IsEnum
                ? Enum.GetUnderlyingType(value.GetType())
                : value.GetType();
             switch (Type.GetTypeCode(propertyType))
                {
                    case TypeCode.Object:
                    {
                        if (propertyType.IsArray)
                        {
                            for (int i = 0; i < size; i++)
                            {
                                var array = (Array)value;
                                foreach (var item in GetBits(array.GetValue(i)))
                                {
                                    yield return item;
                                }
                            }
                        }
                        else
                        {
                            foreach (var item in GetBits(value))
                            {
                                yield return item;
                            }
                        }
                        break;
                    }
                    default:
                    {
                        foreach (var bit in  value.GetBits(propertyType, size, fieldInfo.IsMsmValue))
                        {
                            yield return bit;
                        }

                        break;
                    }
                    
                }
        }

        private object GetFieldValue(object target, BitwisePropertyInfo fieldInfo)
        {
            var value = fieldInfo.PropertyGetter(target);
            var propertyType = fieldInfo.Type.IsEnum
                ? Enum.GetUnderlyingType(fieldInfo.Type)
                : fieldInfo.Type;
             switch (Type.GetTypeCode(propertyType))
                {
                    case TypeCode.DateTime:
                    {
                        var dt = (DateTime)value;
                        var dtOffset = new DateTimeOffset(dt.Year, dt.Month, dt.Day,
                            dt.Minute, dt.Second, dt.Millisecond,
                            TimeSpan.Zero);
                        var unixTime = dtOffset.ToUnixTimeMilliseconds();
                        return unixTime;
                    }
                    case TypeCode.String:
                    {
                        var str = (string)value;
                        var strArray = Encoding.UTF8.GetBytes(str);
                        return strArray;
                    }
                    default:
                    {
                        return value;
                    }
                    
                }
        }

        public T Deserialize<T>(byte[] source) where T : class, new()
        {
            return Deserialize(typeof(T), source) as T;
        }

        public object Deserialize(Type type, byte[] source)
        {
            var position = 0uL;
            return Deserialize(type, source, ref position);
        }

        private object Deserialize(Type targetType, byte[] source, ref ulong position)
        {
            if (_simpleTypes.TryGetValue(targetType, out var size))
            {
                var simpleResult = source.GetBitValue(targetType, position, size, false);
                position += (ulong)size;
                return simpleResult;
            }
            
            var typeMap = GetTypeMap(targetType);

            var result = Activator.CreateInstance(targetType);
            
            foreach (var property in typeMap.OrderBy(x => x.Order))
            {
                ReadField(result, property, source, ref position);
            }

            return result;
        }
        
         private void ReadField(object result, BitwisePropertyInfo fieldInfo, byte[] source, ref ulong position)
        {
            var size = fieldInfo.SizeGetter(result);

            var propertyType = fieldInfo.Type.IsEnum
                ? Enum.GetUnderlyingType(fieldInfo.Type)
                : fieldInfo.Type;
            try
            {
                switch (Type.GetTypeCode(propertyType))
                {
                    case TypeCode.Boolean:
                    {
                        var value = source.GetBitValue<byte>(position, size, false);
                        fieldInfo.PropertySetter(result, value == 1);
                        break;
                    }
                    case TypeCode.DateTime:
                    {
                        var value = source.GetBitValue<long>(position, size, false);
                        fieldInfo.PropertySetter(result, DateTimeOffset.FromUnixTimeMilliseconds(value));
                        break;
                    }
                    case TypeCode.String:
                    {
                        var sByteArray = new byte[size];
                        for (int i = 0; i < size; i++)
                        {
                            sByteArray[i] = source.GetBitValue<byte>(position, 8, false);
                            position += 8;
                        }

                        var value = Encoding.UTF8.GetString(sByteArray);
                        
                        fieldInfo.PropertySetter(result, value);
                        break;
                    }
                    case TypeCode.Object:
                    {
                        if (propertyType.IsArray)
                        {
                            var elementType = propertyType.GetElementType();
                            var array = Array.CreateInstance(elementType, size);
                            fieldInfo.PropertySetter(result, array);
                            for (int i = 0; i < size; i++)
                            {
                                var arrayValue = Deserialize(elementType, source, ref position);
                                array.SetValue(arrayValue, i);
                            }
                        }
                        else
                        {
                            var value = Deserialize(propertyType, source, ref position);
                            fieldInfo.PropertySetter(result, value);
                        }
                        size = 0;
                        break;
                    }
                    default:
                    {
                        var value = source.GetBitValue(propertyType, position, size, fieldInfo.IsMsmValue);
                        fieldInfo.PropertySetter(result, value);
                        break;
                    }
                    
                }


                position += (ulong)size;
            }
            catch (Exception e)
            {
                throw new SerializationException("Error deserializing object", e);
            }
        }

        public IReadOnlyCollection<BitwisePropertyInfo> GetTypeMap<T>() where T : class, new()
        {
            return GetTypeMap(typeof(T));
        }
         
        public IReadOnlyCollection<BitwisePropertyInfo> GetTypeMap(Type type)
        {
            if (_typeMapper.TryGetValue(type, out var result))
            {
                return result;
            }

            var current = new List<BitwisePropertyInfo>();

            foreach (var property in type.GetProperties())
            {
                var fieldInfo = property
                    .GetCustomAttribute<BaseDataFieldAttribute>(true);

                if (fieldInfo == null)
                {
                    continue;
                }
            
                var sizeGetter = fieldInfo.BuildSizeGetter(type);
                
                var input =  Expression.Parameter(typeof(object), "i");
                var instance = Expression.Convert(input, type);
                
                var propertyExpression = Expression.Property(instance, property);
                var propertyGetterExpression = Expression
                    .Lambda<Func<object, object>>(Expression.Convert(propertyExpression, typeof(object)), input);

                var setterInput = Expression.Parameter(typeof(object), "set");
                var setterExpression = Expression.Assign(propertyExpression,
                    Expression.Convert(setterInput, property.PropertyType));

                var propertySetterExpression = Expression.Lambda<Action<object, object>>(setterExpression, input, setterInput);
                
                current.Add(new BitwisePropertyInfo
                {
                    IsMsmValue = fieldInfo.DataType == DataType.MsmValue,
                    Name = property.Name,
                    Order = fieldInfo.Order,
                    SizeGetter = sizeGetter,
                    Type = property.PropertyType,
                    PropertySetter = propertySetterExpression.Compile(),
                    PropertyGetter = propertyGetterExpression.Compile()
                });
            }

            _typeMapper.TryAdd(type, current);
            return current;
        }
    }
}
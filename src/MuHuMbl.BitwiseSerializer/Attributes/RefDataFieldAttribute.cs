using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using MuHuMbl.BitwiseSerializer.Enums;
using MuHuMbl.BitwiseSerializer.Extensions;

namespace MuHuMbl.BitwiseSerializer.Attributes
{
    public class RefDataFieldAttribute : BaseDataFieldAttribute
    {
        private readonly string[] _sizePropertyNames;
        private readonly CalcOperation _calcOperation;
        
        public RefDataFieldAttribute(int order, DataType dataType) 
            : this(order, dataType, CalcOperation.Sum)
        {
        }
        
         public RefDataFieldAttribute(int order, DataType dataType, string sizePropertyName) 
            : this(order, dataType, CalcOperation.Sum, sizePropertyName)
        {
        }

        public RefDataFieldAttribute(int order,
            DataType dataType,
            CalcOperation calcOperation,
            params string[] sizePropertyNames) 
            : base(order, dataType)
        {
            _calcOperation = calcOperation;
            _sizePropertyNames = sizePropertyNames;
        }
        
        public override Func<object, int> BuildSizeGetter(Type targetType)
        {
            var nullValue = Expression.Constant(null, typeof(object));
            var input =  Expression.Parameter(typeof(object), "i");
            var instance = Expression.Convert(input, targetType);
            var instanceIsNull = Expression.Equal(
                instance,
                Expression.Convert(nullValue, targetType));

            var result = Expression.Variable(typeof(int), "size");

            var expressions = new []
            {
                Expression.Assign(result, GetInitialValue(_calcOperation)) 
            }.Concat(
                _sizePropertyNames
                    .Select(sizePropertyName => 
                        GetSizeExpression(sizePropertyName, _calcOperation, instance, result))
            );

            var assign =  Expression.Block(
                new[] { result },
                expressions
            );

            var call = Expression.IfThenElse(instanceIsNull, result, assign);
            
            var expression = Expression.Lambda<Func<object, int>>(call, input);
            
            return expression.Compile();
        }
        
        private static UnaryExpression GetPropertyValue(string sizePropertyName, UnaryExpression instance)
        {
            var property = Expression.Property(instance, sizePropertyName);
            var call = Expression.Convert(property, typeof(int));
            var dataFieldAttribute = property.Member.GetCustomAttribute<BaseDataFieldAttribute>();
            if (dataFieldAttribute?.DataType == DataType.BitMask)
            {
                var getBitsMethod = typeof(ByteExtensions).GetMethod(nameof(ByteExtensions.GetSetBitsCount));
                call = Expression.Convert(Expression.Call(getBitsMethod, call), typeof(int));
            }

            return call;
        }

        private static BinaryExpression GetSizeExpression(string sizePropertyName,
            CalcOperation calcOperation,
            UnaryExpression instance, 
            ParameterExpression result)
        {
            var propertyValue = GetPropertyValue(sizePropertyName, instance);
            return calcOperation switch
            {
                CalcOperation.Sum => Expression.AddAssignChecked(result, propertyValue),
                CalcOperation.Multiply => Expression.MultiplyAssignChecked(result, propertyValue),
                _ => throw new ArgumentOutOfRangeException(nameof(calcOperation), calcOperation, null)
            };
        }

        private static ConstantExpression GetInitialValue(CalcOperation calcOperation)
        {
            return calcOperation switch
            {
                CalcOperation.Sum => Expression.Constant(0),
                CalcOperation.Multiply => Expression.Constant(1),
                _ => throw new ArgumentOutOfRangeException(nameof(calcOperation), calcOperation, null)
            };
        }
    }
}
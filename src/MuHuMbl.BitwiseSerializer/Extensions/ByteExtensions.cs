using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MuHuMbl.BitwiseSerializer.Extensions
{
    public static class ByteExtensions
    {
        public static int GetSetBitsCount(this int source)
        {
            var result = 0;
            var bytes = BitConverter.GetBytes(Convert.ToUInt64(source));
            var bitArray = new BitArray(bytes);
            foreach (var bit in bitArray)
            {
                if ((bool) bit)
                {
                    result++;
                }
            }

            return result;
        }

        public static T GetBitValue<T>(this byte[] source, ulong pos, int len, bool isMsmValue)
        {
            return (T)GetBitValue(source, typeof(T), pos, len, isMsmValue);
        }

        public static object GetBitValue(this byte[] source, Type destinationType, ulong pos, int len, bool isMsmValue)
        {
            var result = GetBitValueCore(source, pos, len);

            switch (Type.GetTypeCode(destinationType))
            {
                case TypeCode.Boolean:
                    return result == 1;
                case TypeCode.Byte:
                    return (byte)result;
                case TypeCode.Char:
                    return (char)result;
                case TypeCode.Int16:
                    return (short)GetSignedResult(result, len, isMsmValue);
                case TypeCode.Int32:
                    return (int)GetSignedResult(result, len, isMsmValue);
                case TypeCode.Int64:
                    return (long)GetSignedResult(result, len, isMsmValue);
                case TypeCode.SByte:
                    return (sbyte)GetSignedResult(result, len, isMsmValue);
                case TypeCode.UInt16:
                    return (ushort)result;
                case TypeCode.UInt32:
                    return (uint)result;
                case TypeCode.UInt64:
                    return result;
                case TypeCode.Object:
                {
                    if (destinationType == typeof(byte[]))
                    {
                        var bytes = new List<byte>();
                        var currentBitIndex = 0;
                        var currentByte = (byte)0;
                        var set = false;
                        foreach (var bit in GetBits(source, pos, len))
                        {
                            set = false;
                            currentByte = (byte)((currentByte << 1) | (byte)(bit ? 1 : 0));
                            currentBitIndex++;
                            if (currentBitIndex % 8 == 0)
                            {
                                currentBitIndex = 0;
                                bytes.Add(currentByte);
                                set = true;
                            }
                        }

                        if (!set && currentBitIndex > 0)
                        {
                            bytes.Add(currentByte); 
                        }
                        
                        return bytes;
                    }
                    throw new ArgumentOutOfRangeException();
                }
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private static ulong GetSignedResult(ulong source, int len, bool isMsmValue)
        {
            if ((source & (1uL << (len - 1))) == 0)
            {
                return  source;
            }
            len = isMsmValue ? len - 1 : len;  
            var shortValue = isMsmValue 
                ? ~source + 1 
                : source;
            return shortValue | (~0uL << len);
        }

        public static IEnumerable<bool> GetBits(this object source, Type destinationType, int len, bool isMsmValue)
        {
            var value = source.GetCorrectValue(destinationType, len, isMsmValue);
            var bytes = value.GetBytes(destinationType).ToArray();
            return WriteBits(bytes, 0, len);
        }

        private static object GetCorrectValue(this object source, Type destinationType, int len, bool isMsmValue)
        {
            if (!isMsmValue)
            {
                return source;
            }
            
            return Type.GetTypeCode(destinationType) switch
            {
                TypeCode.SByte => new[] { (byte)source },
                TypeCode.Int16 => (short)source >= 0 ? source : (~(short)source | 1 << (len-1)) + 1,
                TypeCode.Int32 => (int)source >= 0 ? source : (~(int)source | 1 << (len - 1)) + 1,
                TypeCode.Int64 => (long)source >= 0 ? source : (~(long)source | 1 << (len - 1)) + 1,
                _ => source
            };
        }
        
        private static IEnumerable<byte> GetBytes(this object source, Type destinationType)
        {
            return Type.GetTypeCode(destinationType) switch
            {
                TypeCode.Boolean => BitConverter.GetBytes((bool)source),
                TypeCode.Byte => new[] { (byte)source },
                TypeCode.Char => new[] { (byte)source },
                TypeCode.UInt16 => BitConverter.GetBytes((ushort)source),
                TypeCode.UInt32 => BitConverter.GetBytes((uint)source),
                TypeCode.UInt64 => BitConverter.GetBytes((ulong)source),
                TypeCode.SByte => new[] { (byte)source },
                TypeCode.Int16 => BitConverter.GetBytes((short)source),
                TypeCode.Int32 => BitConverter.GetBytes((int)source),
                TypeCode.Int64 => BitConverter.GetBytes((long)source),
                TypeCode.Object => source as byte[],
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        private static ulong GetBitValueCore(byte[] source, ulong pos, int len)
        {
            ulong result = 0;

            foreach (var bit in GetBits(source, pos, len))
            {
                result = (result << 1) | (bit ? 1uL : 0uL);
            }

            return result;
        }

        private static IEnumerable<bool> GetBits(byte[] source, ulong pos, int len)
        {
            for (var t = 0; t < len; t++)
            {
                var i = pos + (ulong)t;
                var result = source[i / 8] >> (byte)(7 - i % 8);
                result &= 1;
                yield return result == 1;
            }
        }
        
        private static IEnumerable<bool> WriteBits(byte[] source, ulong pos, int len)
        {
            for (var t = len; t > 0; t--)
            {
                var i = pos + (ulong)t-1;
                var result = source[i / 8] >> (byte)(i % 8);
                result &= 1;
                yield return result == 1;
            }
        }
    }
}
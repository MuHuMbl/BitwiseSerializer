using System;
using MuHuMbl.BitwiseSerializer.Attributes;
using MuHuMbl.BitwiseSerializer.Enums;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Attributes;

public class RtcmFieldAttribute : DataFieldAttribute
{
    public RtcmFieldAttribute(int order, RtcmType RtcmType, ulong size)
        : base(order, ToRtcmType(RtcmType), size)
    {
    }
    
    public RtcmFieldAttribute(int order, RtcmType RtcmType)
        : base(order, ToRtcmType(RtcmType), GetSize(RtcmType))
    {
    }

    private static DataType ToRtcmType(RtcmType rtcmType)
    {
        return rtcmType switch
        {
            RtcmType.Bit => DataType.BitMask,
            RtcmType.IntS5 => DataType.MsmValue,
            RtcmType.IntS11 => DataType.MsmValue,
            RtcmType.IntS22 => DataType.MsmValue,
            RtcmType.IntS24 => DataType.MsmValue,
            RtcmType.IntS27 => DataType.MsmValue,
            RtcmType.IntS32 => DataType.MsmValue,
            _ => DataType.RawValue
        };
    }

    private static ulong GetSize(RtcmType rtcmType)
    {
        return rtcmType switch
        {
            RtcmType.Bit => 1,
            RtcmType.Char8 => 8,
            RtcmType.Int8 => 8,
            RtcmType.Uint8 => 8,
            RtcmType.Int9 => 9,
            RtcmType.Uint9 => 9,
            RtcmType.Utf8 => 8,
            RtcmType.Int10 => 10,
            RtcmType.Int12 => 12,
            RtcmType.Int14 => 14,
            RtcmType.Uint14 => 14,
            RtcmType.Int15 => 15,
            RtcmType.Int16 => 16,
            RtcmType.Uint16 => 16,
            RtcmType.Int17 => 17,
            RtcmType.Uint17 => 17,
            RtcmType.Uint18 => 18,
            RtcmType.Int19 => 19,
            RtcmType.Int20 => 20,
            RtcmType.Uint20 => 20,
            RtcmType.Int21 => 21,
            RtcmType.Int22 => 22,
            RtcmType.IntS22 => 22,
            RtcmType.Int23 => 23,
            RtcmType.Uint23 => 23,
            RtcmType.Int24 => 24,
            RtcmType.Int25 => 25,
            RtcmType.Uint24 => 24,
            RtcmType.IntS24 => 24,
            RtcmType.Uint25 => 25,
            RtcmType.Uint26 => 26,
            RtcmType.Int26 => 26,
            RtcmType.Int27 => 27,
            RtcmType.Uint27 => 27,
            RtcmType.IntS27 => 27,
            RtcmType.Int30 => 30,
            RtcmType.Uint30 => 30,
            RtcmType.Int32 => 32,
            RtcmType.Int34 => 34,
            RtcmType.Int35 => 35,
            RtcmType.Uint32 => 32,
            RtcmType.Uint35 => 35,
            RtcmType.Uint36 => 36,
            RtcmType.IntS32 => 32,
            RtcmType.Int38 => 38,
            RtcmType.Uint2 => 2,
            RtcmType.Uint3 => 3,
            RtcmType.Uint4 => 4,
            RtcmType.Uint5 => 5,
            RtcmType.IntS5 => 5,
            RtcmType.Uint6 => 6,
            RtcmType.Uint7 => 7,
            RtcmType.Uint10 => 10,
            RtcmType.Uint11 => 11,
            RtcmType.IntS11 => 11,
            RtcmType.Uint12 => 12,
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}
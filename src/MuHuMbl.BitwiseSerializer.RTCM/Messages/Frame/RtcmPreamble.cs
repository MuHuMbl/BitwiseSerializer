using MuHuMbl.BitwiseSerializer.Attributes;
using MuHuMbl.BitwiseSerializer.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.Frame;

public class RtcmPreamble
{
    public static byte Default = 0xD3;
    
    [DataField(0, DataType.RawValue, 8)]
    public byte Preamble { get; set; }
}
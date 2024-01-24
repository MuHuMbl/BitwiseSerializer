using MuHuMbl.BitwiseSerializer.Attributes;
using MuHuMbl.BitwiseSerializer.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.Frame;

public class RtcmFrame
{
    [RefDataField(0, DataType.RawValue)]
    public RtcmPreamble Preamble { get; set; }
        
    [DataField(1, DataType.RawValue, 6)]
    public byte Reserved { get; set; }
        
    [DataField(2, DataType.RawValue, 10)]
    public ushort Length { get; set; }

    [RefDataField(3, DataType.RawValue, nameof(Length))]
    public byte[] Message { get; set; }

    [DataField(4, DataType.RawValue, 24)]
    public uint CRC { get; set; }
}
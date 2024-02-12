using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages
{
    public interface IRtcmMessage
    {
        MessageType MessageType { get; set; }
    }
}
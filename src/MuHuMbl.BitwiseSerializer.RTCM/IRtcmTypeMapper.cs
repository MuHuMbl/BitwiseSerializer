using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM
{
    public interface IRtcmTypeMapper
    {
        public Type GetMessageType(MessageType messageType);
    }
}
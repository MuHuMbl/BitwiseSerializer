using MuHuMbl.BitwiseSerializer.RTCM.Enums;
using MuHuMbl.BitwiseSerializer.RTCM.Messages;

namespace MuHuMbl.BitwiseSerializer.RTCM
{
    public interface IRtcmTypeMapper
    {
        public Type GetMessageType(MessageType messageType);

        void AddMap<T>(MessageType messageType) where T : class, IRtcmMessage;
    }
}
using MuHuMbl.BitwiseSerializer.RTCM.Enums;
using MuHuMbl.BitwiseSerializer.RTCM.Messages;

namespace MuHuMbl.BitwiseSerializer.RTCM
{
    public interface IRtcmTypeMapper
    {
        public Type GetMessageType(MessageType messageType);

        bool TryGetMessageType(MessageType messageType, out Type messageObjectType);

        void AddMap<T>(MessageType messageType, bool replace = false) where T : class, IRtcmMessage;
    }
}
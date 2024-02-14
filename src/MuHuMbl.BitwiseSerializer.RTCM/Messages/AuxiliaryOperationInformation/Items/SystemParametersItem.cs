using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.AuxiliaryOperationInformation.Items
{
    public class SystemParametersItem 
    {
        [RtcmField(0, RtcmType.Uint12)]
        public ushort MessageId { get; set; }

        [RtcmField(1, RtcmType.Bit, 1)]
        public bool SyncFlag { get; set; }

        [RtcmField(2, RtcmType.Uint16)]
        public ushort TransmissionInterval { get; set; }
    }
}
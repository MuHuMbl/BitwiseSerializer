using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.StateSpaceRepresentationParameters.Gps.Items
{
    public class SsrGpsCodeBiasItem
    {
        [RtcmField(0, RtcmType.Uint5)]
        public byte GpsSignalAndTrackingModeIndicator { get; set; }
        
        [RtcmField(1, RtcmType.Int14)]
        public short CodeBias { get; set; }
    }
}
using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.StateSpaceRepresentationParameters.Glonass.Items
{
    public class SsrGlonassCodeBiasItem
    {
        [RtcmField(0, RtcmType.Uint5)]
        public byte GlonassSignalAndTrackingModeIndicator { get; set; }
        
        [RtcmField(1, RtcmType.Int14)]
        public short CodeBias { get; set; }
    }
}
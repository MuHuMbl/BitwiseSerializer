using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.StateSpaceRepresentationParameters.Glonass.Items
{
    public class SsrGlonassClockCorrectionItem
    {
        [RtcmField(0, RtcmType.Uint5)]
        public byte GpsSatelliteId { get; set; }
        
        [RtcmField(1, RtcmType.Int22)]
        public int DeltaClockC0 { get; set; }
        
        [RtcmField(2, RtcmType.Int21)]
        public int DeltaClockC1 { get; set; }
        
        [RtcmField(3, RtcmType.Int27)]
        public int DeltaClockC2 { get; set; }
    }
}
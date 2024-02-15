using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.StateSpaceRepresentationParameters.Gps.Items
{
    public class SsrGpsOrbitCorrectionItem
    {
        [RtcmField(0, RtcmType.Uint6)]
        public byte GpsSatelliteId { get; set; }
        
        [RtcmField(1, RtcmType.Uint8)]
        public byte GpsIode { get; set; }
        
        [RtcmField(2, RtcmType.Int22)]
        public int DeltaRadial { get; set; }
        
        [RtcmField(3, RtcmType.Int20)]
        public int DeltaAlongTrack { get; set; }
        
        [RtcmField(4, RtcmType.Int20)]
        public int DeltaCrossTrack { get; set; }
        
        [RtcmField(5, RtcmType.Int21)]
        public int DotDeltaRadial { get; set; }
        
        [RtcmField(6, RtcmType.Int19)]
        public int DotDeltaAlongTrack { get; set; }
        
        [RtcmField(7, RtcmType.Int19)]
        public int DotDeltaCrossTrack { get; set; }
    }
}
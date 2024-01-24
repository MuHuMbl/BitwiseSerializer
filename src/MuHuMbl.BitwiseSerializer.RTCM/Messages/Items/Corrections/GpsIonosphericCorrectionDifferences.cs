using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.Items.Corrections
{
    
    public class GpsIonosphericCorrectionDifferences 
    {
        [RtcmField(0, RtcmType.Uint6)]
        public byte SatelliteId { get; set; }

        [RtcmField(1, RtcmType.Bit, 2)]
        public byte AmbiguityStatusFlag { get; set; }

        [RtcmField(2, RtcmType.Uint3)]
        public byte NonSyncCount { get; set; }

        [RtcmField(3, RtcmType.Int17)]
        public int IonosphericCarrierPhaseCorrectionDifference { get; set; }
    }
}
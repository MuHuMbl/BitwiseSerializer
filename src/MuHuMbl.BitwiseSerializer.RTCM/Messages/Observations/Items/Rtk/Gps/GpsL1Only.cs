using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.Observations.Items.Rtk.Gps
{
    
    public class GpsL1Only 
    {
        [RtcmField(0, RtcmType.Uint6)]
        public byte SatelliteId { get; set; }

        [RtcmField(1, RtcmType.Bit, 1)]
        public byte L1CodeIndicator { get; set; }

        [RtcmField(2, RtcmType.Uint24)]
        public uint Pseudorange { get; set; }

        [RtcmField(3, RtcmType.Int20)]
        public int PhaseRangeMinusPseudorange { get; set; }

        [RtcmField(4, RtcmType.Uint7)]
        public byte LockTimeIndicator { get; set; }
    }
}
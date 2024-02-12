using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.Observations.Items.Rtk.Gps
{
    
    public class GpsL1L2 
    {
        [RtcmField(0, RtcmType.Uint6)]
        public byte SatelliteId { get; set; }

        [RtcmField(1, RtcmType.Bit, 1)]
        public byte L1CodeIndicator { get; set; }

        [RtcmField(2, RtcmType.Uint24)]
        public uint L1Pseudorange { get; set; }

        [RtcmField(3, RtcmType.Int20)]
        public int L1PhaseRangeMinusL1Pseudorange { get; set; }

        [RtcmField(4, RtcmType.Uint7)]
        public byte L1LockTimeIndicator { get; set; }

        [RtcmField(5, RtcmType.Bit, 2)]
        public byte L2CodeIndicator { get; set; }

        [RtcmField(6, RtcmType.Int14)]
        public short L2L1PseudorangeDifference { get; set; }

        [RtcmField(7, RtcmType.Int20)]
        public int L2PhaseRangeMinusL1Pseudorange { get; set; }

        [RtcmField(8, RtcmType.Uint7)]
        public byte L2LockTimeIndicator { get; set; }
    }
}
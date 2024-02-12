using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.Observations.Items.Msm.SignalData
{
    public class Msm7
    {
        [RtcmField(0, RtcmType.Int20)]
        public int FinePseudorange { get; set; }

        [RtcmField(1, RtcmType.Int24)]
        public int FinePhaseRange { get; set; }

        [RtcmField(2, RtcmType.Uint10)]
        public ushort PhaseRangeLockTimeIndicator { get; set; }

        [RtcmField(3, RtcmType.Bit, 1)]
        public bool HalfCycleAmbiguityIndicator { get; set; }

        [RtcmField(4, RtcmType.Uint10)]
        public ushort GnssSignalCnr { get; set; }
        
        [RtcmField(5, RtcmType.Int15)]
        public int FinePhaseRangeRates { get; set; }
    }
}
using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.Items.Msm.SignalData
{
    public class Msm3
    {
        [RtcmField(0, RtcmType.Int15)]
        public int FinePseudorange { get; set; }

        [RtcmField(1, RtcmType.Int22)]
        public int FinePhaseRange { get; set; }

        [RtcmField(2, RtcmType.Uint4)]
        public byte PhaseRangeLockTimeIndicator { get; set; }

        [RtcmField(3, RtcmType.Bit, 1)]
        public bool HalfCycleAmbiguityIndicator { get; set; }
    }
}
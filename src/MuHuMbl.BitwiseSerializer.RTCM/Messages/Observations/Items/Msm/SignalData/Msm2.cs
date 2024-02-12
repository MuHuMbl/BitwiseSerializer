using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.Observations.Items.Msm.SignalData
{
    public class Msm2
    {
        [RtcmField(0, RtcmType.Int22)]
        public int FinePhaseRange { get; set; }

        [RtcmField(1, RtcmType.Uint4)]
        public byte PhaseRangeLockTimeIndicator { get; set; }
        
        [RtcmField(2, RtcmType.Bit, 1)]
        public bool HalfCycleAmbiguityIndicator  { get; set; }
    }
}
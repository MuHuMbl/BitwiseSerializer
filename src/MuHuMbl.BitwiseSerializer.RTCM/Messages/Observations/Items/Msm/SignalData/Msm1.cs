using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.Observations.Items.Msm.SignalData
{
    public class Msm1
    {
        [RtcmField(0, RtcmType.Int15)]
        public int FinePseudorange { get; set; }
    }
}
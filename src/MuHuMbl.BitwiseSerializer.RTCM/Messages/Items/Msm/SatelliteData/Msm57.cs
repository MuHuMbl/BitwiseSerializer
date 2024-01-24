using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.Items.Msm.SatelliteData
{
    public class Msm57
    {
        [RtcmField(0, RtcmType.Uint8)]
        public ushort SatelliteRoughRangesMilliseconds { get; set; }

        [RtcmField(1, RtcmType.Uint4)]
        public byte ExtendedSatelliteInformation { get; set; }

        [RtcmField(2, RtcmType.Uint10)]
        public ushort SatelliteRoughRangesModulo { get; set; }

        [RtcmField(3, RtcmType.Int14)]
        public short SatelliteRoughRangesPhaseRangeRates { get; set; }
    }
}
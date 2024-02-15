using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.Observations.Glonass.Items
{
    public class GlonassL1L2ExtendedItem : IGlonassRtkItem   
    {
        [RtcmField(0, RtcmType.Uint6)]
        public byte SatelliteId { get; set; }

        [RtcmField(1, RtcmType.Bit, 1)]
        public byte L1CodeIndicator { get; set; }

        [RtcmField(2, RtcmType.Uint5)]
        public byte FrequencyChannelNumber { get; set; }

        [RtcmField(3, RtcmType.Uint25)]
        public uint L1Pseudorange { get; set; }

        [RtcmField(4, RtcmType.Int20)]
        public int L1PhaseRangeMinusL1Pseudorange { get; set; }

        [RtcmField(5, RtcmType.Uint7)]
        public byte L1LockTimeIndicator { get; set; }

        [RtcmField(6, RtcmType.Uint7)]
        public byte L1PseudorangeModulusAmbiguity { get; set; }

        [RtcmField(7, RtcmType.Uint8)]
        public byte L1CNR { get; set; }

        [RtcmField(8, RtcmType.Bit, 2)]
        public byte L2CodeIndicator { get; set; }

        [RtcmField(9, RtcmType.Int14)]
        public uint L2L1PseudorangeDifference { get; set; }

        [RtcmField(10, RtcmType.Int20)]
        public int L2PhaseRangeMinusL1Pseudorange { get; set; }

        [RtcmField(11, RtcmType.Uint7)]
        public byte L2LockTimeIndicator { get; set; }

        [RtcmField(12, RtcmType.Uint8)]
        public byte L2CNR { get; set; }
    }
}
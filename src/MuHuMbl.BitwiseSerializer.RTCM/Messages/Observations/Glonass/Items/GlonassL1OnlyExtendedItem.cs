using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.Observations.Glonass.Items
{
    public class GlonassL1OnlyExtendedItem : IGlonassRtkItem   
    {
        [RtcmField(0, RtcmType.Uint6)]
        public byte SatelliteId { get; set; }

        [RtcmField(1, RtcmType.Bit, 1)]
        public byte L1CodeIndicator { get; set; }

        [RtcmField(2, RtcmType.Uint5)]
        public byte FrequencyChannelNumber { get; set; }

        [RtcmField(3, RtcmType.Uint25)]
        public uint Pseudorange { get; set; }

        [RtcmField(4, RtcmType.Int20)]
        public int PhaseRangeMinusPseudorange { get; set; }

        [RtcmField(5, RtcmType.Uint7)]
        public byte LockTimeIndicator { get; set; }

        [RtcmField(6, RtcmType.Uint7)]
        public byte PseudorangeModulusAmbiguity { get; set; }

        [RtcmField(7, RtcmType.Uint8)]
        public byte CNR { get; set; }
    }
}
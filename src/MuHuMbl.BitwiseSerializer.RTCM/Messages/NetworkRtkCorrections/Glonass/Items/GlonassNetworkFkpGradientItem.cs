using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.NetworkRtkCorrections.Glonass.Items
{
    public class GlonassNetworkFkpGradientItem
    {
        [RtcmField(0, RtcmType.Uint6)] 
        public byte GpsSatelliteId { get; set; }

        [RtcmField(1, RtcmType.Bit, 8)] 
        public byte GlonassIssueOfDataEphemeris { get; set; }

        [RtcmField(2, RtcmType.Int12)] 
        public byte GeometricGradientNorth { get; set; }

        [RtcmField(3, RtcmType.Int12)]
        public byte GeometricGradientEast { get; set; }

        [RtcmField(4, RtcmType.Int14)]
        public byte IonosphericGradientNorth { get; set; }

        [RtcmField(5, RtcmType.Int14)]
        public byte IonosphericGradientEast { get; set; }
    }
}
using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.NetworkRtkCorrections.Items.Gps
{
    public class GpsNetworkFkpGradientItem
    {
        [RtcmField(0, RtcmType.Uint6)] 
        public byte GpsSatelliteId { get; set; }

        [RtcmField(1, RtcmType.Bit, 8)] 
        public byte GpsIssueOfDataEphemeris { get; set; }

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
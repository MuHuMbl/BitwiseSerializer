using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.NetworkRtkCorrections.Gps.Items
{
    public class GpsNetworkResidualItem
    {
        [RtcmField(0, RtcmType.Uint6)]
        public byte GpsSatelliteId { get; set; }
        
        [RtcmField(0, RtcmType.Uint8)]
        public byte Soc { get; set; }
        
        [RtcmField(0, RtcmType.Uint9)]
        public ushort Sod { get; set; }
        
        [RtcmField(0, RtcmType.Uint6)]
        public byte Soh { get; set; }
        
        [RtcmField(0, RtcmType.Uint10)]
        public ushort Sic { get; set; }
        
        [RtcmField(0, RtcmType.Uint10)]
        public ushort Sid { get; set; }
    }
}
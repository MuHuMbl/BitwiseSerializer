using MuHuMbl.BitwiseSerializer.Attributes;
using MuHuMbl.BitwiseSerializer.Enums;
using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;
using MuHuMbl.BitwiseSerializer.RTCM.Messages.NetworkRtkCorrections.Gps.Items;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.NetworkRtkCorrections.Gps
{
    public class GpsNetworkResidual : IRtcmMessage
    {
        [RtcmField(0, RtcmType.Uint12)]
        public MessageType MessageType { get; set; }
        
        [RtcmField(1, RtcmType.Uint20)]
        public uint GpsResidualsEpochTime { get; set; }
        
        [RtcmField(2, RtcmType.Uint12)]
        public ushort ReferenceStationId { get; set; }
        
        [RtcmField(3, RtcmType.Uint7)]
        public byte NRefs { get; set; }
        
        [RtcmField(4, RtcmType.Uint5)]
        public byte GpsNumberOfSatelliteSignalsProcessed { get; set; }
        
        [RefDataField(8, DataType.RawValue, nameof(GpsNumberOfSatelliteSignalsProcessed))]
        public GpsNetworkResidualItem[] Items { get; set; }
    }
}
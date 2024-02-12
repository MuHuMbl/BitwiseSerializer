using MuHuMbl.BitwiseSerializer.Attributes;
using MuHuMbl.BitwiseSerializer.Enums;
using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;
using MuHuMbl.BitwiseSerializer.RTCM.Messages.NetworkRtkCorrections.Items.Gps;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.NetworkRtkCorrections
{
    public class GpsNetworkFkpGradient : IRtcmMessage
    {
        [RtcmField(0, RtcmType.Uint12)]
        public MessageType MessageType { get; set; }
        
        [RtcmField(1, RtcmType.Uint12)]
        public ushort ReferenceStationId { get; set; }
        
        [RtcmField(2, RtcmType.Uint20)]
        public uint GpsFkpEpochTime { get; set; }
        
        [RtcmField(3, RtcmType.Uint5)]
        public byte NumberOfGpsSatelliteSignalsProcessed { get; set; }
        
        [RefDataField(4, DataType.RawValue, nameof(NumberOfGpsSatelliteSignalsProcessed))]
        public GpsNetworkFkpGradientItem[] Items { get; set; }
    }
}
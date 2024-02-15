using MuHuMbl.BitwiseSerializer.Attributes;
using MuHuMbl.BitwiseSerializer.Enums;
using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;
using MuHuMbl.BitwiseSerializer.RTCM.Messages.NetworkRtkCorrections.Glonass.Items;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.NetworkRtkCorrections.Glonass
{
    public class GlonassNetworkResidual : IRtcmMessage
    {
        [RtcmField(0, RtcmType.Uint12)]
        public MessageType MessageType { get; set; }
        
        [RtcmField(1, RtcmType.Uint17)]
        public uint GlonassResidualsEpochTime { get; set; }
        
        [RtcmField(2, RtcmType.Uint12)]
        public ushort ReferenceStationId { get; set; }
        
        [RtcmField(3, RtcmType.Uint7)]
        public byte NRefs { get; set; }
        
        [RtcmField(4, RtcmType.Uint5)]
        public byte GlonassNumberOfSatelliteSignalsProcessed { get; set; }
        
        [RefDataField(8, DataType.RawValue, nameof(GlonassNumberOfSatelliteSignalsProcessed))]
        public GlonassNetworkResidualItem[] Items { get; set; }
    }
}
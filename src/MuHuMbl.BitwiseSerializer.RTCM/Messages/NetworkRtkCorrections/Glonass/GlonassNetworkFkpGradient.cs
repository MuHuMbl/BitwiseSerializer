using MuHuMbl.BitwiseSerializer.Attributes;
using MuHuMbl.BitwiseSerializer.Enums;
using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;
using MuHuMbl.BitwiseSerializer.RTCM.Messages.NetworkRtkCorrections.Glonass.Items;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.NetworkRtkCorrections.Glonass
{
    public class GlonassNetworkFkpGradient: IRtcmMessage
    {
        [RtcmField(0, RtcmType.Uint12)]
        public MessageType MessageType { get; set; }
        
        [RtcmField(1, RtcmType.Uint12)]
        public ushort ReferenceStationId { get; set; }
        
        [RtcmField(2, RtcmType.Uint17)]
        public uint GlonassFkpEpochTime { get; set; }
        
        [RtcmField(3, RtcmType.Uint5)]
        public byte NumberOfGlonassSatelliteSignalsProcessed { get; set; }
        
        [RefDataField(4, DataType.RawValue, nameof(NumberOfGlonassSatelliteSignalsProcessed))]
        public GlonassNetworkFkpGradientItem[] Items { get; set; }
    }
}
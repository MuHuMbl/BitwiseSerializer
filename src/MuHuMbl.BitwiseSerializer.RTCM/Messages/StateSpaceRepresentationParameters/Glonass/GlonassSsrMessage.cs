using MuHuMbl.BitwiseSerializer.Attributes;
using MuHuMbl.BitwiseSerializer.Enums;
using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.StateSpaceRepresentationParameters.Glonass
{
    public abstract class GlonassSsrMessage<TItem> : IRtcmMessage
    {
        [RtcmField(0, RtcmType.Uint12)]
        public MessageType MessageType { get; set; }
        
        [RtcmField(1, RtcmType.Uint17)]
        public uint GlonassEpochTime { get; set; }
        
        [RtcmField(2, RtcmType.Bit, 4)]
        public byte SsrUpdateInterval { get; set; }
        
        [RtcmField(3, RtcmType.Bit)]
        public bool MultipleMessageIndicator { get; set; }
        
        [RtcmField(4, RtcmType.Uint4)]
        public byte IodSsr { get; set; }
        
        [RtcmField(5, RtcmType.Uint16)]
        public ushort SsrProviderId { get; set; }
        
        [RtcmField(6, RtcmType.Uint4)]
        public byte SsrSolutionId { get; set; }
        
        [RtcmField(7, RtcmType.Uint6)]
        public byte SatellitesCount { get; set; }
        
        [RefDataField(8, DataType.RawValue, nameof(SatellitesCount))]
        public TItem[] Items { get; set; }
    }
}
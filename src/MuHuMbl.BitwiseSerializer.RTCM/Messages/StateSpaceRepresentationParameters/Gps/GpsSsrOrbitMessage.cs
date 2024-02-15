using MuHuMbl.BitwiseSerializer.Attributes;
using MuHuMbl.BitwiseSerializer.Enums;
using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;
using MuHuMbl.BitwiseSerializer.RTCM.Messages.StateSpaceRepresentationParameters.Gps.Items;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.StateSpaceRepresentationParameters.Gps
{
    public abstract class GpsSsrOrbitMessage<TItem> : IRtcmMessage
    {
        [RtcmField(0, RtcmType.Uint12)]
        public MessageType MessageType { get; set; }
        
        [RtcmField(1, RtcmType.Uint20)]
        public uint GpsEpochTime { get; set; }
        
        [RtcmField(2, RtcmType.Bit, 4)]
        public byte SsrUpdateInterval { get; set; }
        
        [RtcmField(3, RtcmType.Bit)]
        public bool MultipleMessageIndicator { get; set; }
        
        [RtcmField(4, RtcmType.Bit)]
        public bool SatelliteReferenceDatum { get; set; }
        
        [RtcmField(5, RtcmType.Uint4)]
        public byte IodSsr { get; set; }
        
        [RtcmField(6, RtcmType.Uint16)]
        public ushort SsrProviderId { get; set; }
        
        [RtcmField(7, RtcmType.Uint4)]
        public byte SsrSolutionId { get; set; }
        
        [RtcmField(8, RtcmType.Uint6)]
        public byte SatellitesCount { get; set; }
        
        [RefDataField(9, DataType.RawValue, nameof(SatellitesCount))]
        public TItem[] Items { get; set; }
    }
}
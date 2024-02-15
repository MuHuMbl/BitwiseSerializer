using MuHuMbl.BitwiseSerializer.Attributes;
using MuHuMbl.BitwiseSerializer.Enums;
using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.NetworkRtkCorrections.Glonass
{
    public abstract class GlonassNetworkRtkCorrections<TDataItem> : IRtcmMessage
    {
        [RtcmField(0, RtcmType.Uint12)]
        public MessageType MessageType { get; set; }

        [RtcmField(1, RtcmType.Uint8)]
        public byte NetworkId { get; set; }

        [RtcmField(2, RtcmType.Uint4)]
        public byte SubnetworkId { get; set; }

        [RtcmField(3, RtcmType.Uint20)]
        public uint GlonassEpochTime { get; set; }

        [RtcmField(4, RtcmType.Bit, 1)]
        public bool MultipleMessageIndicator { get; set; }

        [RtcmField(5, RtcmType.Uint12)]
        public ushort MasterReferenceStationId { get; set; }

        [RtcmField(6, RtcmType.Uint12)]
        public ushort AuxiliaryReferenceStationId { get; set; }

        [RtcmField(7, RtcmType.Uint4)]
        public byte GlonassSatellitesCount { get; set; }

        [RefDataField(8, DataType.RawValue, nameof(GlonassSatellitesCount))]
        public TDataItem[] Items { get; set; }
    }
}
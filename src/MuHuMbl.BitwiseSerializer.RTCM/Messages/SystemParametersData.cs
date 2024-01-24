using MuHuMbl.BitwiseSerializer.Attributes;
using MuHuMbl.BitwiseSerializer.Enums;
using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages
{
    public class SystemParametersData<TDataItem> 
    {
        [RtcmField(0, RtcmType.Uint12)]
        public MessageType MessageType { get; set; }

        [RtcmField(1, RtcmType.Uint12)]
        public ushort StationId { get; set; }

        [RtcmField(2, RtcmType.Uint16)]
        public ushort ModifiedJulianDay { get; set; }

        [RtcmField(3, RtcmType.Uint17)]
        public uint SecondsOfDay { get; set; }

        [RtcmField(4, RtcmType.Uint5)]
        public byte MessagesCount { get; set; }

        [RtcmField(5, RtcmType.Uint8)]
        public byte LeapSeconds { get; set; }

        [RefDataField(6, DataType.RawValue, nameof(MessagesCount))]
        public TDataItem[] Items { get; set; }
    }
}
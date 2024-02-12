using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.StationCoordinates
{
    public class PhysicalReferenceStationPosition : IRtcmMessage
    {
        [RtcmField(0, RtcmType.Uint12)]
        public MessageType MessageType { get; set; }
        
        [RtcmField(1, RtcmType.Uint12)]
        public ushort NonPhysicalReferenceStationId { get; set; }
        
        [RtcmField(2, RtcmType.Uint12)]
        public ushort PhysicalReferenceStationId { get; set; }

        [RtcmField(3, RtcmType.Uint6)]
        public byte ItrfEpochYear { get; set; }

        [RtcmField(4, RtcmType.Int38)]
        public long ArpEcefX  { get; set; }

        [RtcmField(5, RtcmType.Int38)]
        public long ArpEcefY { get; set; }
        
        [RtcmField(6, RtcmType.Int38)]
        public long ArpEcefZ { get; set; }
    }
}
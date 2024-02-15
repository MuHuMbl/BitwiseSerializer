using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.TransformationParameterInformation
{
    public class LambertProjectionParameters : IRtcmMessage
    {
        [RtcmField(0, RtcmType.Uint12)]
        public MessageType MessageType { get; set; }
        
        [RtcmField(1, RtcmType.Uint8)]
        public byte SystemIdentificationNumber { get; set; }
        
        [RtcmField(2, RtcmType.Uint6)]
        public byte ProjectionType { get; set; }
        
        [RtcmField(3, RtcmType.Int34)]
        public long LatitudeOfFalseOrigin { get; set; }
        
        [RtcmField(4, RtcmType.Int35)]
        public long LongitudeOfFalseOrigin { get; set; }
        
        [RtcmField(5, RtcmType.Int34)]
        public long LatitudeOfStandardParallel1 { get; set; }
        
        [RtcmField(6, RtcmType.Int34)]
        public long LatitudeOfStandardParallel2 { get; set; }
        
        [RtcmField(7, RtcmType.Uint36)]
        public ulong EastingOfFalseOrigin { get; set; }
        
        [RtcmField(8, RtcmType.Int35)]
        public long NorthingOfFalseOrigin { get; set; }
    }
}
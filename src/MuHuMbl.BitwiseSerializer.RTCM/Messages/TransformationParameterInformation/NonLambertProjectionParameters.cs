using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.TransformationParameterInformation
{
    public class NonLambertProjectionParameters
    {
        [RtcmField(0, RtcmType.Uint12)]
        public MessageType MessageType { get; set; }
        
        [RtcmField(1, RtcmType.Uint8)]
        public byte SystemIdentificationNumber { get; set; }
        
        [RtcmField(2, RtcmType.Uint6)]
        public byte ProjectionType { get; set; }
        
        [RtcmField(3, RtcmType.Int34)]
        public long LatitudeOfNaturalOrigin { get; set; }
        
        [RtcmField(4, RtcmType.Int35)]
        public long LongitudeOfNaturalOrigin { get; set; }
        
        [RtcmField(5, RtcmType.Uint30)]
        public uint ScaleFactorAtNaturalOrigin { get; set; }
        
        [RtcmField(6, RtcmType.Uint36)]
        public ulong FalseEasting { get; set; }
        
        [RtcmField(7, RtcmType.Int35)]
        public long FalseNorthing { get; set; }
    }
}
using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.TransformationParameterInformation
{
    public class ObliqueMercatorProjectionParameters
    {
        [RtcmField(0, RtcmType.Uint12)]
        public MessageType MessageType { get; set; }
        
        [RtcmField(1, RtcmType.Uint8)]
        public byte SystemIdentificationNumber { get; set; }
        
        [RtcmField(2, RtcmType.Uint6)]
        public byte ProjectionType { get; set; }
        
        [RtcmField(3, RtcmType.Bit, 1)]
        public bool RectificationFlag { get; set; }
        
        [RtcmField(4, RtcmType.Int34)]
        public long LatitudeOfProjectionCenter { get; set; }
        
        [RtcmField(5, RtcmType.Int35)]
        public long LongitudeOfProjectionCenter { get; set; }
        
        [RtcmField(6, RtcmType.Uint35)]
        public ulong AzimuthOfInitialLine { get; set; }
        
        [RtcmField(7, RtcmType.Int26)]
        public int AngleFromRectifiedToSkewGridDiff { get; set; }
        
        [RtcmField(8, RtcmType.Uint30)]
        public uint ScaleFactorOnInitialLine { get; set; }
        
        [RtcmField(9, RtcmType.Uint36)]
        public ulong EastingAtProjectionCenter { get; set; }
        
        [RtcmField(10, RtcmType.Int35)]
        public long NorthingAtProjectionCenter { get; set; }
    }
}
using MuHuMbl.BitwiseSerializer.Attributes;
using MuHuMbl.BitwiseSerializer.Enums;
using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.TransformationParameterInformation
{
    public class MolodenskiBadekasTransformationParameters : IRtcmMessage
    {
        [RtcmField(0, RtcmType.Uint12)]
        public MessageType MessageType { get; set; }
        
        [RtcmField(1, RtcmType.Uint5)]
        public byte SourceNameCounter { get; set; }
        
        [RefDataField(2, DataType.RawValue, nameof(SourceNameCounter))]
        public byte[] SourceName { get; set; } 
        
        [RtcmField(3, RtcmType.Uint5)]
        public byte TargetNameCounter { get; set; }
        
        [RefDataField(4, DataType.RawValue, nameof(TargetNameCounter))]
        public byte[] TargetName { get; set; }
        
        [RtcmField(5, RtcmType.Uint8)]
        public byte SystemIdentificationNumber { get; set; }
        
        [RtcmField(6, RtcmType.Bit, 10)]
        public ushort UtilizedTransformationMessageIndicator { get; set; }
        
        [RtcmField(7, RtcmType.Uint5)]
        public byte PlateNumber { get; set; }
        
        [RtcmField(8, RtcmType.Uint4)]
        public byte ComputationIndicator { get; set; }
        
        [RtcmField(9, RtcmType.Uint2)]
        public byte HeightIndicator { get; set; }
        
        [RtcmField(10, RtcmType.Int19)]
        public int LatitudeOfOrigin { get; set; }
        
        [RtcmField(11, RtcmType.Int20)]
        public int LongitudeOfOrigin { get; set; }
        
        [RtcmField(12, RtcmType.Uint14)]
        public ushort NsExtension { get; set; }
        
        [RtcmField(13, RtcmType.Uint14)]
        public ushort EwExtension { get; set; }
        
        [RtcmField(14, RtcmType.Int23)]
        public int TranslationInX { get; set; }
        
        [RtcmField(15, RtcmType.Int23)]
        public int TranslationInY { get; set; }
        
        [RtcmField(16, RtcmType.Int23)]
        public int TranslationInZ { get; set; }
        
        [RtcmField(17, RtcmType.Int32)]
        public int RotationAroundX { get; set; }
        
        [RtcmField(18, RtcmType.Int32)]
        public int RotationAroundY { get; set; }
        
        [RtcmField(19, RtcmType.Int32)]
        public int RotationAroundZ { get; set; }
        
        [RtcmField(20, RtcmType.Int25)]
        public int ScaleCorrection { get; set; }
        
        [RtcmField(21, RtcmType.Int35)]
        public long XCoordinateForMbRotationPoint { get; set; }
        
        [RtcmField(22, RtcmType.Int35)]
        public long YCoordinateForMbRotationPoint { get; set; }
        
        [RtcmField(23, RtcmType.Int35)]
        public long ZCoordinateForMbRotationPoint { get; set; }
        
        [RtcmField(24, RtcmType.Uint24)]
        public uint SemiMajorAxisOfSourceSystemEllipsoid { get; set; }
        
        [RtcmField(25, RtcmType.Uint25)]
        public uint SemiMinorAxisOfSourceSystemEllipsoid { get; set; }
        
        [RtcmField(26, RtcmType.Uint24)]
        public uint SemiMajorAxisOfTargetSystemEllipsoid { get; set; }
        
        [RtcmField(27, RtcmType.Uint25)]
        public uint SemiMinorAxisOfTargetSystemEllipsoid { get; set; }
        
        [RtcmField(28, RtcmType.Uint3)]
        public byte HorizontalHelmertMolodenskiQualityIndicator { get; set; }
        
        [RtcmField(29, RtcmType.Uint3)]
        public byte VerticalHelmertMolodenskiQualityIndicator { get; set; }
    }
}
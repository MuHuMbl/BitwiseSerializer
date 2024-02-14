using MuHuMbl.BitwiseSerializer.Attributes;
using MuHuMbl.BitwiseSerializer.Enums;
using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;
using MuHuMbl.BitwiseSerializer.RTCM.Messages.TransformationParameterInformation.Items;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.TransformationParameterInformation
{
    public class EllipsoidalGridRepresentation : IRtcmMessage
    {
        [RtcmField(0, RtcmType.Uint12)]
        public MessageType MessageType { get; set; }
        
        [RtcmField(1, RtcmType.Uint8)]
        public byte SystemIdentificationNumber { get; set; }
        
        [RtcmField(2, RtcmType.Bit, 1)]
        public bool HorizontalShiftIndicator { get; set; }
        
        [RtcmField(3, RtcmType.Bit, 1)]
        public bool VerticalShiftIndicator { get; set; }
        
        [RtcmField(4, RtcmType.Int21)]
        public int LatitudeOfOriginOfGrids { get; set; }
        
        [RtcmField(5, RtcmType.Int22)]
        public int LongitudeOfOriginOfGrids { get; set; }
        
        [RtcmField(6, RtcmType.Uint12)]
        public ushort NsGridAreaExtension { get; set; }
        
        [RtcmField(7, RtcmType.Uint12)]
        public ushort EwGridAreaExtension { get; set; }
        
        [RtcmField(8, RtcmType.Int8)]
        public sbyte MeanLatitudeOffset { get; set; }
        
        [RtcmField(9, RtcmType.Int8)]
        public sbyte MeanLongitudeOffset { get; set; }
        
        [RtcmField(10, RtcmType.Int15)]
        public short MeanHeightOffset { get; set; }
        
        [DataField(11, DataType.RawValue, 16)]
        public EllipsoidalGridRepresentationItem[] GridPointShifts { get; set; }
        
        [RtcmField(12, RtcmType.Uint2)]
        public byte HorizontalInterpolationMethodIndicator { get; set; }
        
        [RtcmField(13, RtcmType.Uint2)]
        public byte VerticalInterpolationMethodIndicator { get; set; }
        
        [RtcmField(14, RtcmType.Uint3)]
        public byte HorizontalGridQualityIndicator { get; set; }
        
        [RtcmField(15, RtcmType.Uint3)]
        public byte VerticalGridQualityIndicator { get; set; }
        
        [RtcmField(16, RtcmType.Uint16)]
        public ushort ModifiedJulianDayNumber { get; set; }
    }
}
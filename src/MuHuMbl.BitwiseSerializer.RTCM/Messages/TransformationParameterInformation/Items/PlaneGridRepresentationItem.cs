using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.TransformationParameterInformation.Items
{
    public class PlaneGridRepresentationItem
    {
        [RtcmField(0, RtcmType.Int9)]
        public short LocalNorthingResidual { get; set; }
        
        [RtcmField(1, RtcmType.Int9)]
        public short LocalEastingResidual { get; set; }
        
        [RtcmField(2, RtcmType.Int9)]
        public short HeightResidual { get; set; }
    }
}
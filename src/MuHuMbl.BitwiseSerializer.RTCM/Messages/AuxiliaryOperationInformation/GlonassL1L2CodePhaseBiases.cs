using MuHuMbl.BitwiseSerializer.Attributes;
using MuHuMbl.BitwiseSerializer.Enums;
using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;
using MuHuMbl.BitwiseSerializer.RTCM.Messages.AuxiliaryOperationInformation.Items;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.AuxiliaryOperationInformation
{
    public class GlonassL1L2CodePhaseBiases : IRtcmMessage
    {
        [RtcmField(0, RtcmType.Uint12)]
        public MessageType MessageType { get; set; }
        
        [RtcmField(1, RtcmType.Uint12)]
        public ushort ReferenceStationId { get; set; }
        
        [RtcmField(2, RtcmType.Bit, 1)]
        public bool GlonassCodePhaseBiasIndicator { get; set; }
        
        [RtcmField(3, RtcmType.Bit, 3)]
        public bool Reserved { get; set; }
        
        [RtcmField(4, RtcmType.Bit, 4)]
        public FdmaSignalMask GlonassFdmaSignalMask { get; set; }
        
        [RefDataField(5, DataType.RawValue, nameof(GlonassFdmaSignalMask))]
        public GlonassBias[] Items { get; set; }
    }
}
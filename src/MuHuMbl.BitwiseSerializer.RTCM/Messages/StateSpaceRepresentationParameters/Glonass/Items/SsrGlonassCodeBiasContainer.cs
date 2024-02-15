using MuHuMbl.BitwiseSerializer.Attributes;
using MuHuMbl.BitwiseSerializer.Enums;
using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.StateSpaceRepresentationParameters.Glonass.Items
{
    public class SsrGlonassCodeBiasContainer
    {
        [RtcmField(0, RtcmType.Uint5)]
        public byte GlonassSatelliteId { get; set; }
        
        [RtcmField(1, RtcmType.Uint5)]
        public byte BiasesCount { get; set; }
        
        [RefDataField(2, DataType.RawValue, nameof(BiasesCount))]
        public SsrGlonassCodeBiasItem[] Items { get; set; }
    }
}
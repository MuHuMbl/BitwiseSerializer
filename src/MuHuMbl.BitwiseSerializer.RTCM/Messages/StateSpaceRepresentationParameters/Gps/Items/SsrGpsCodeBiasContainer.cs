using MuHuMbl.BitwiseSerializer.Attributes;
using MuHuMbl.BitwiseSerializer.Enums;
using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.StateSpaceRepresentationParameters.Gps.Items
{
    public class SsrGpsCodeBiasContainer
    {
        [RtcmField(0, RtcmType.Uint6)]
        public byte GpsSatelliteId { get; set; }
        
        [RtcmField(1, RtcmType.Uint5)]
        public byte BiasesCount { get; set; }
        
        [RefDataField(2, DataType.RawValue, nameof(BiasesCount))]
        public SsrGpsCodeBiasItem[] Items { get; set; }
    }
}
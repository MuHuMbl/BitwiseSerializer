using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.StateSpaceRepresentationParameters.Glonass.Items
{
    public class SsrGlonassUraItem
    {
        [RtcmField(0, RtcmType.Uint5)]
        public byte GlonassSatelliteId { get; set; }
        
        [RtcmField(1, RtcmType.Bit, 6)]
        public byte SsrUra { get; set; }
    }
}
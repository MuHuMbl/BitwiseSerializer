using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.AuxiliaryOperationInformation.Items
{
    public class GlonassBias
    {
        [RtcmField(0, RtcmType.Int16)]
        public short Value { get; set; }
    }
}
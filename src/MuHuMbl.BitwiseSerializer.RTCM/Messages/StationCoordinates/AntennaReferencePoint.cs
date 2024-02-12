using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.StationCoordinates
{
    public class AntennaReferencePoint : IRtcmMessage
    {
        [RtcmField(0, RtcmType.Uint12)]
        public MessageType MessageType { get; set; }
        
        [RtcmField(1, RtcmType.Uint12)]
        public ushort StationId { get; set; }
        
        [RtcmField(2, RtcmType.Uint6)]
        public byte ReservedForRealizationYear { get; set; }

        [RtcmField(3, RtcmType.Bit, 1)]
        public bool IsGpsSupported { get; set; }

        [RtcmField(4, RtcmType.Bit, 1)]
        public bool IsGlonassSupported { get; set; }

        [RtcmField(5, RtcmType.Bit, 1)]
        public bool IsGalileoSupported { get; set; }
        
        [RtcmField(6, RtcmType.Bit, 1)]
        public bool IsComputedReferenceStation { get; set; }

        [RtcmField(7, RtcmType.Int38)]
        public long ReferencePointX { get; set; }
        
        [RtcmField(8, RtcmType.Bit, 1)]
        public bool SingleReceiverOscillatorIndicator { get; set; }
        
        [RtcmField(9, RtcmType.Bit, 1)]
        public bool Reserved { get; set; }

        [RtcmField(10, RtcmType.Int38)]
        public long ReferencePointY { get; set; }

        [RtcmField(11, RtcmType.Bit, 2)]
        public byte QuarterCycleIndicator { get; set; }

        [RtcmField(12, RtcmType.Int38)]
        public long ReferencePointZ { get; set; }
    }
}
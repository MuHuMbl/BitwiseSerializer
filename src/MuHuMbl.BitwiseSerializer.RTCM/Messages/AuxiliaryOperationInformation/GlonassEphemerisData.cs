using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.AuxiliaryOperationInformation
{
    public class GlonassEphemerisData : IRtcmMessage
    {
        [RtcmField(0, RtcmType.Uint12)]
        public MessageType MessageType { get; set; }

        [RtcmField(1, RtcmType.Uint6)]
        public byte SatelliteId { get; set; }
        
        [RtcmField(2, RtcmType.Uint5)]
        public byte FrequencyChannelNumber { get; set; }
        
        [RtcmField(3, RtcmType.Bit, 1)]
        public bool AlmanacHealth { get; set; }

        [RtcmField(4, RtcmType.Bit, 1)]
        public bool AlmanacHealthAvailabilityIndicator { get; set; }

        [RtcmField(5, RtcmType.Bit, 2)]
        public byte P1 { get; set; }

        [RtcmField(6, RtcmType.Uint5)]
        public byte TkHour { get; set; }

        [RtcmField(7, RtcmType.Uint6)]
        public byte TkMinute { get; set; }
        
        [RtcmField(8, RtcmType.Bit, 1)]
        public bool TkThirtySeconds { get; set; }
        
        [RtcmField(9, RtcmType.Bit, 1)]
        public bool EphemerisHealthFlag { get; set; }
        
        [RtcmField(10, RtcmType.Bit, 1)]
        public bool P2 { get; set; }
        
        [RtcmField(11, RtcmType.Uint7)]
        public byte Tb { get; set; }

        [RtcmField(12, RtcmType.IntS24)]
        public int XVelocity { get; set; }
        
        [RtcmField(13, RtcmType.IntS27)]
        public int XCoordinate { get; set; }
        
        [RtcmField(14, RtcmType.IntS5)]
        public sbyte XAcceleration { get; set; }

        [RtcmField(15, RtcmType.IntS24)]
        public int YVelocity { get; set; }

        [RtcmField(16, RtcmType.IntS27)]
        public int YCoordinate { get; set; }

        [RtcmField(17, RtcmType.IntS5)]
        public sbyte YAcceleration { get; set; }

        [RtcmField(18, RtcmType.IntS24)]
        public int ZVelocity { get; set; }

        [RtcmField(19, RtcmType.IntS27)]
        public int ZCoordinate { get; set; }

        [RtcmField(20, RtcmType.IntS5)]
        public sbyte ZAcceleration { get; set; }

        [RtcmField(21, RtcmType.Bit, 1)]
        public bool P3 { get; set; }

        [RtcmField(22, RtcmType.IntS11)]
        public short DeviationOfPredictedFrequency { get; set; }

        [RtcmField(23, RtcmType.Bit, 2)]
        public byte P { get; set; }

        [RtcmField(24, RtcmType.Bit, 1)]
        public byte LnThirdString { get; set; }

        [RtcmField(25, RtcmType.IntS22)]
        public int TauN { get; set; }

        [RtcmField(26, RtcmType.IntS5)]
        public sbyte DeltaTauN { get; set; }
        
        [RtcmField(27, RtcmType.Uint5)]
        public byte En { get; set; }

        [RtcmField(28, RtcmType.Bit,1)]
        public byte P4 { get; set; }
        
        [RtcmField(29, RtcmType.Uint4)]
        public byte Ft { get; set; }
        
        [RtcmField(30, RtcmType.Uint11)]
        public ushort Nt { get; set; }
        
        [RtcmField(31, RtcmType.Bit, 2)]
        public byte M { get; set; }

        [RtcmField(32, RtcmType.Bit, 1)]
        public byte AdditionalDataAvailability { get; set; }
        
        [RtcmField(33, RtcmType.Uint11)]
        public ushort Na { get; set; }

        [RtcmField(34, RtcmType.IntS32)]
        public int TauC { get; set; }

        [RtcmField(35, RtcmType.Uint5)]
        public byte N4 { get; set; }

        [RtcmField(36, RtcmType.IntS22)]
        public int TauGps { get; set; }

        [RtcmField(37, RtcmType.Bit, 1)]
        public byte LnFifthString { get; set; }
        
        [RtcmField(38, RtcmType.Bit, 7)]
        public byte Reserved { get; set; }
    }
}
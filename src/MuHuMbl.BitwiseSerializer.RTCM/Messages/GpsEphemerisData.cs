using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages
{
    public class GpsEphemerisData 
    {
        [RtcmField(0, RtcmType.Uint12)]
        public MessageType MessageType { get; set; }

        [RtcmField(1, RtcmType.Uint6)]
        public byte SatelliteId { get; set; }

        [RtcmField(2, RtcmType.Uint10)]
        public ushort WeekNumber { get; set; }

        [RtcmField(3, RtcmType.Uint4)]
        public byte SvAccuracy  { get; set; }
        
        [RtcmField(4, RtcmType.Bit, 2)]
        public byte CodeOnL2 { get; set; }

        [RtcmField(5, RtcmType.Int14)]
        public short IDOT { get; set; }
        
        [RtcmField(6, RtcmType.Uint8)]
        public byte IODE { get; set; }
        
        [RtcmField(7, RtcmType.Uint16)]
        public ushort Toc { get; set; }
        
        [RtcmField(8, RtcmType.Int8)]
        public sbyte Af2 { get; set; }
        
        [RtcmField(9, RtcmType.Int16)]
        public short Af1 { get; set; }
        
        [RtcmField(10, RtcmType.Int22)]
        public int Af0 { get; set; }

        [RtcmField(11, RtcmType.Uint10)]
        public ushort IODC { get; set; }

        [RtcmField(12, RtcmType.Int16)]
        public short Crs { get; set; }

        [RtcmField(13, RtcmType.Int16)]
        public short DeltaN { get; set; }

        [RtcmField(14, RtcmType.Int32)]
        public int M0 { get; set; }

        [RtcmField(15, RtcmType.Int16)]
        public short Cuc { get; set; }
        
        [RtcmField(16, RtcmType.Uint32)]
        public uint Eccentricity { get; set; }

        [RtcmField(17, RtcmType.Int16)]
        public short Cus { get; set; }
        
        [RtcmField(18, RtcmType.Uint32)]
        public uint SquareRootA { get; set; }

        [RtcmField(19, RtcmType.Uint16)]
        public ushort Toe { get; set; }

        [RtcmField(20, RtcmType.Int16)]
        public short Cic { get; set; }

        [RtcmField(21, RtcmType.Int32)]
        public int Omega0 { get; set; }
        
        [RtcmField(22, RtcmType.Int16)]
        public short Cis { get; set; }

        [RtcmField(23, RtcmType.Int32)]
        public int I0 { get; set; }
        
        [RtcmField(24, RtcmType.Int16)]
        public short Crc { get; set; }

        [RtcmField(25, RtcmType.Int32)]
        public int ArgumentOfPerigeeOmega { get; set; }
        
        [RtcmField(26, RtcmType.Int24)]
        public int OmegaDot { get; set; }

        [RtcmField(27, RtcmType.Int8)]
        public sbyte Tgd { get; set; }

        [RtcmField(28, RtcmType.Uint6)]
        public byte SvHealth { get; set; }
        
        [RtcmField(29, RtcmType.Bit,1)]
        public bool L2PDataFlag  { get; set; }
        
        [RtcmField(30, RtcmType.Bit,1)]
        public bool FitInterval  { get; set; }
    }
}
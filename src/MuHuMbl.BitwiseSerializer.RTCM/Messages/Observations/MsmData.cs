using MuHuMbl.BitwiseSerializer.Attributes;
using MuHuMbl.BitwiseSerializer.Enums;
using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.Observations
{
    public class MsmData<TSatelliteData, TObservation> : IRtcmMessage
    {
        [RtcmField(0, RtcmType.Uint12)]
        public MessageType MessageType { get; set; }
        
        [RtcmField(1, RtcmType.Uint12)]
        public ushort StationId { get; set; }

        [RtcmField(2, RtcmType.Uint30)]
        public uint GnssEpochTime { get; set; }

        [RtcmField(3, RtcmType.Bit, 1)]
        public bool MultipleMessageBit { get; set; }

        [RtcmField(4, RtcmType.Uint3)]
        public byte IssueOfDataStation { get; set; }

        [RtcmField(5, RtcmType.Bit, 7)]
        public byte Reserved { get; set; }

        [RtcmField(6, RtcmType.Uint2)]
        public byte ClockSteeringIndicator { get; set; }

        [RtcmField(7, RtcmType.Uint2)]
        public byte ExternalClockIndicator { get; set; }
        
        [RtcmField(8, RtcmType.Bit, 1)]
        public bool DivergenceFreeSmoothingIndicator { get; set; }

        [RtcmField(9, RtcmType.Bit, 3)]
        public SmoothingInterval SmoothingInterval { get; set; }
        
        [RtcmField(10, RtcmType.Bit, 64)]
        public ulong SatelliteMask { get; set; }
        
        [RtcmField(11, RtcmType.Bit, 32)]
        public uint SignalMask { get; set; }

        [RefDataField(12, DataType.BitMask, CalcOperation.Multiply, nameof(SatelliteMask), nameof(SignalMask))]
        public ulong CellMask { get; set; }

        [RefDataField(13, DataType.RawValue, nameof(SatelliteMask))]
        public TSatelliteData[] SatelliteData { get; set; }

        [RefDataField(14, DataType.RawValue, nameof(CellMask))]
        public TObservation[] SignalData { get; set; }
    }
}
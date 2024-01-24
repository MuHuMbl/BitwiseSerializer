﻿using MuHuMbl.BitwiseSerializer.Attributes;
using MuHuMbl.BitwiseSerializer.Enums;
using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages
{
    public class GlonassRtkData<TSignal> 
    {
        [RtcmField(0, RtcmType.Uint12)]
        public MessageType MessageType { get; set; }

        [RtcmField(1, RtcmType.Uint12)]
        public ushort StationId { get; set; }

        /// <summary>
        /// Milliseconds
        /// </summary>
        [RtcmField(2, RtcmType.Uint27)]
        public uint GlonassEpochTime { get; set; }

        [RtcmField(3, RtcmType.Bit, 1)]
        public bool SynchronousGnssFlag { get; set; }

        [RtcmField(4, RtcmType.Uint5)]
        public byte SatelliteSignalsCount { get; set; }

        [RtcmField(5, RtcmType.Bit, 1)]
        public bool DivergenceFreeSmoothingIndicator { get; set; }

        [RtcmField(6, RtcmType.Bit, 3)]
        public SmoothingInterval SmoothingInterval { get; set; }

        [RefDataField(7, DataType.RawValue, nameof(SatelliteSignalsCount))]
        public TSignal[] Items { get; set; }
    }
}
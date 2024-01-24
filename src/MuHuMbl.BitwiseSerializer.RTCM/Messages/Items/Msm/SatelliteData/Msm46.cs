﻿using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.Items.Msm.SatelliteData
{
    public class Msm46
    {
        [RtcmField(0, RtcmType.Uint8)]
        public byte SatelliteRoughRangesMilliseconds { get; set; }

        [RtcmField(1, RtcmType.Uint10)]
        public ushort SatelliteRoughRangesModulo { get; set; }
    }
}
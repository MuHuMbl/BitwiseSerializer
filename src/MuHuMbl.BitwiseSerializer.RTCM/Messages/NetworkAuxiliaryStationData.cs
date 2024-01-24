using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages
{
    public class NetworkAuxiliaryStationData 
    {
        [RtcmField(0, RtcmType.Uint12)]
        public MessageType MessageType { get; set; }

        [RtcmField(1, RtcmType.Uint8)]
        public byte NetworkId { get; set; }

        [RtcmField(2, RtcmType.Uint4)]
        public byte SubnetworkId { get; set; }

        [RtcmField(3, RtcmType.Uint5)]
        public byte AuxiliaryStations { get; set; }

        [RtcmField(4, RtcmType.Uint12)]
        public ushort MasterReferenceStationId { get; set; }

        [RtcmField(5, RtcmType.Uint12)]
        public ushort AuxiliaryReferenceStationId { get; set; }
        
        [RtcmField(6, RtcmType.Int20)]
        public int AuxMasterDeltaLatitude { get; set; }

        [RtcmField(7, RtcmType.Int21)]
        public int AuxMasterDeltaLongitude { get; set; }

        [RtcmField(8, RtcmType.Int23)]
        public int AuxMasterDeltaHeight  { get; set; }
    }
}
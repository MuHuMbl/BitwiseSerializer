using MuHuMbl.BitwiseSerializer.Attributes;
using MuHuMbl.BitwiseSerializer.Enums;
using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.AntennaDescription
{
    public class AntennaDescriptorAndSerialNumber: IRtcmMessage
    {
        [RtcmField(0, RtcmType.Uint12)]
        public MessageType MessageType { get; set; }
        
        [RtcmField(1, RtcmType.Uint12)]
        public ushort ReferenceStationId { get; set; }
        
        [RtcmField(2, RtcmType.Uint8)]
        public byte AntennaDescriptorCounterN { get; set; } 
        
        [RefDataField(3, DataType.RawValue, nameof(AntennaDescriptorCounterN))]
        public byte[] AntennaDescriptorValue { get; set; } 
        
        [RtcmField(4, RtcmType.Uint8)]
        public byte AntennaSetupId  { get; set; }
        
        [RtcmField(5, RtcmType.Uint8)]
        public byte SerialNumberCounterM { get; set; } 
        
        [RefDataField(6, DataType.RawValue, nameof(SerialNumberCounterM))]
        public byte[] AntennaSerialNumberValue { get; set; } 
    }
}
using MuHuMbl.BitwiseSerializer.Attributes;
using MuHuMbl.BitwiseSerializer.Enums;
using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.ReceiverAndAntennaDescription
{
    public class ReceiverAndAntennaDescriptors: IRtcmMessage
    {
        [RtcmField(0, RtcmType.Uint12)]
        public MessageType MessageType { get; set; }
        
        [RtcmField(1, RtcmType.Uint12)]
        public ushort ReferenceStationId { get; set; }
        
        [RtcmField(2, RtcmType.Uint8)]
        public byte AntennaDescriptorCounterN  { get; set; } 
        
        [RefDataField(3, DataType.RawValue, nameof(AntennaDescriptorCounterN))]
        public byte[] AntennaDescriptorValue { get; set; } 
        
        [RtcmField(4, RtcmType.Uint8)]
        public byte AntennaSetupId  { get; set; }
        
        [RtcmField(5, RtcmType.Uint8)]
        public byte AntennaSerialNumberCounterM { get; set; } 
        
        [RefDataField(6, DataType.RawValue, nameof(AntennaSerialNumberCounterM))]
        public byte[] AntennaSerialNumberValue { get; set; } 
        
        [RtcmField(7, RtcmType.Uint8)]
        public byte ReceiverTypeDescriptorCounterI  { get; set; } 
        
        [RefDataField(8, DataType.RawValue, nameof(ReceiverTypeDescriptorCounterI))]
        public byte[] ReceiverTypeDescriptorValue { get; set; } 
        
        [RtcmField(9, RtcmType.Uint8)]
        public byte ReceiverFirmwareVersionCounterJ   { get; set; } 
        
        [RefDataField(10, DataType.RawValue, nameof(ReceiverFirmwareVersionCounterJ))]
        public byte[] ReceiverFirmwareVersionValue { get; set; } 
        
        [RtcmField(11, RtcmType.Uint8)]
        public byte ReceiverSerialNumberCounterK   { get; set; } 
        
        [RefDataField(12, DataType.RawValue, nameof(ReceiverSerialNumberCounterK))]
        public byte[] ReceiverSerialNumberValue { get; set; } 
    }
}
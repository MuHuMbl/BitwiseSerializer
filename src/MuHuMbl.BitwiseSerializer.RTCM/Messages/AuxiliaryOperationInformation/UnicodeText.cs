using MuHuMbl.BitwiseSerializer.Attributes;
using MuHuMbl.BitwiseSerializer.Enums;
using MuHuMbl.BitwiseSerializer.RTCM.Attributes;
using MuHuMbl.BitwiseSerializer.RTCM.Enums;
using MuHuMbl.BitwiseSerializer.RTCM.Messages.AuxiliaryOperationInformation.Items;

namespace MuHuMbl.BitwiseSerializer.RTCM.Messages.AuxiliaryOperationInformation
{
    public class UnicodeText : IRtcmMessage
    {
        [RtcmField(0, RtcmType.Uint12)]
        public MessageType MessageType { get; set; }
        
        [RtcmField(1, RtcmType.Uint12)]
        public ushort ReferenceStationId { get; set; }
        
        [RtcmField(2, RtcmType.Uint16)]
        public ushort ModifiedJulianDayNumber { get; set; }
        
        [RtcmField(3, RtcmType.Uint17)]
        public uint SecondsOfDayUtc  { get; set; }
        
        /// <summary>
        /// This represents the number of fully formed Unicode
        /// characters in the message text. It is not necessarily
        /// the number of bytes that are needed to represent the
        /// characters as UTF-8. Note that for some messages it
        /// may not be possible to utilize the full range of this
        /// field, e.g. where many characters require 3 or 4 byte
        /// representations and together will exceed 255 code
        /// units. 
        /// </summary>
        [RtcmField(4, RtcmType.Uint7)]
        public byte NumberOfCharactersToFollow  { get; set; }
        
        [RtcmField(5, RtcmType.Uint8)]
        public byte NumberOfUtf8CodeUnits  { get; set; }
        
        [RefDataField(6, DataType.RawValue, nameof(NumberOfUtf8CodeUnits))]
        public string Text { get; set; }
    }
}
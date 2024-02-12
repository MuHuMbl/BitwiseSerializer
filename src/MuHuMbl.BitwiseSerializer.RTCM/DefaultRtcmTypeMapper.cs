using MuHuMbl.BitwiseSerializer.RTCM.Enums;
using MuHuMbl.BitwiseSerializer.RTCM.Messages;
using MuHuMbl.BitwiseSerializer.RTCM.Messages.AntennaDescription;
using MuHuMbl.BitwiseSerializer.RTCM.Messages.Items;
using MuHuMbl.BitwiseSerializer.RTCM.Messages.NetworkRtkCorrections;
using MuHuMbl.BitwiseSerializer.RTCM.Messages.NetworkRtkCorrections.Items.Gps;
using MuHuMbl.BitwiseSerializer.RTCM.Messages.Observations;
using MuHuMbl.BitwiseSerializer.RTCM.Messages.Observations.Items.Msm.SatelliteData;
using MuHuMbl.BitwiseSerializer.RTCM.Messages.Observations.Items.Msm.SignalData;
using MuHuMbl.BitwiseSerializer.RTCM.Messages.Observations.Items.Rtk.Glonass;
using MuHuMbl.BitwiseSerializer.RTCM.Messages.Observations.Items.Rtk.Gps;
using MuHuMbl.BitwiseSerializer.RTCM.Messages.StationCoordinates;

namespace MuHuMbl.BitwiseSerializer.RTCM
{
    public class DefaultRtcmTypeMapper : IRtcmTypeMapper
    {
        private readonly IDictionary<MessageType, Type> _rtcmTypeMap;

        public DefaultRtcmTypeMapper()
        {
            _rtcmTypeMap = new Dictionary<MessageType, Type>();
            
            _rtcmTypeMap.Add(MessageType.AntennaReferencePoint, typeof(AntennaReferencePoint));
            _rtcmTypeMap.Add(MessageType.AntennaReferencePointWithHeight, typeof(AntennaReferencePoint));
            _rtcmTypeMap.Add(MessageType.PhysicalReferenceStationPosition, typeof(PhysicalReferenceStationPosition));
            
            _rtcmTypeMap.Add(MessageType.AntennaDescriptor, typeof(AntennaDescriptor));
            _rtcmTypeMap.Add(MessageType.AntennaDescriptorAndSerialNumber, typeof(AntennaDescriptorAndSerialNumber));
            
            _rtcmTypeMap.Add(MessageType.GlonassEphemerisData, typeof(GlonassEphemerisData));
            
            _rtcmTypeMap.Add(MessageType.GlonassL1Only, typeof(GlonassRtkData<GlonassL1Only>));
            _rtcmTypeMap.Add(MessageType.GlonassL1OnlyExtended, typeof(GlonassRtkData<GlonassL1OnlyExtended>));
            _rtcmTypeMap.Add(MessageType.GlonassL1L2, typeof(GlonassRtkData<GlonassL1L2>));
            _rtcmTypeMap.Add(MessageType.GlonassL1L2Extended, typeof(GlonassRtkData<GlonassL1L2Extended>));
            
            _rtcmTypeMap.Add(MessageType.GpsEphemerisData, typeof(GpsEphemerisData));
            
            _rtcmTypeMap.Add(MessageType.GpsL1Only, typeof(GpsRtkData<GpsL1Only>));
            _rtcmTypeMap.Add(MessageType.GpsL1OnlyExtended, typeof(GpsRtkData<GpsL1OnlyExtended>));
            _rtcmTypeMap.Add(MessageType.GpsL1L2, typeof(GpsRtkData<GpsL1L2>));
            _rtcmTypeMap.Add(MessageType.GpsL1L2Extended, typeof(GpsRtkData<GpsL1L2Extended>));
            
            _rtcmTypeMap.Add(MessageType.GpsMsm1, typeof(MsmData<Msm123,Msm1>));
            _rtcmTypeMap.Add(MessageType.GpsMsm2, typeof(MsmData<Msm123,Msm2>));
            _rtcmTypeMap.Add(MessageType.GpsMsm3, typeof(MsmData<Msm123,Msm3>));
            _rtcmTypeMap.Add(MessageType.GpsMsm4, typeof(MsmData<Msm46,Msm4>));
            _rtcmTypeMap.Add(MessageType.GpsMsm5, typeof(MsmData<Msm57,Msm5>));
            _rtcmTypeMap.Add(MessageType.GpsMsm6, typeof(MsmData<Msm46,Msm6>));
            _rtcmTypeMap.Add(MessageType.GpsMsm7, typeof(MsmData<Msm57,Msm7>));
            _rtcmTypeMap.Add(MessageType.GlonassMsm1, typeof(MsmData<Msm123,Msm1>));
            _rtcmTypeMap.Add(MessageType.GlonassMsm2, typeof(MsmData<Msm123,Msm2>));
            _rtcmTypeMap.Add(MessageType.GlonassMsm3, typeof(MsmData<Msm123,Msm3>));
            _rtcmTypeMap.Add(MessageType.GlonassMsm4, typeof(MsmData<Msm46,Msm4>)); 
            _rtcmTypeMap.Add(MessageType.GlonassMsm5, typeof(MsmData<Msm57,Msm5>)); 
            _rtcmTypeMap.Add(MessageType.GlonassMsm6, typeof(MsmData<Msm46,Msm6>)); 
            _rtcmTypeMap.Add(MessageType.GlonassMsm7, typeof(MsmData<Msm57,Msm7>)); 
            _rtcmTypeMap.Add(MessageType.GalileoMsm1, typeof(MsmData<Msm123,Msm1>));
            _rtcmTypeMap.Add(MessageType.GalileoMsm2, typeof(MsmData<Msm123,Msm2>));
            _rtcmTypeMap.Add(MessageType.GalileoMsm3, typeof(MsmData<Msm123,Msm3>));
            _rtcmTypeMap.Add(MessageType.GalileoMsm4, typeof(MsmData<Msm46,Msm4>)); 
            _rtcmTypeMap.Add(MessageType.GalileoMsm5, typeof(MsmData<Msm57,Msm5>)); 
            _rtcmTypeMap.Add(MessageType.GalileoMsm6, typeof(MsmData<Msm46,Msm6>)); 
            _rtcmTypeMap.Add(MessageType.GalileoMsm7, typeof(MsmData<Msm57,Msm7>)); 
            
            _rtcmTypeMap.Add(MessageType.NetworkAuxiliaryStationData, typeof(NetworkAuxiliaryStationData));
            
            _rtcmTypeMap.Add(MessageType.GpsIonosphericCorrection, typeof(NetworkRtkData<GpsIonosphericCorrectionDifferences>));
            _rtcmTypeMap.Add(MessageType.GpsGeometricCorrection, typeof(NetworkRtkData<GpsGeometricCorrectionDifferences>));
            _rtcmTypeMap.Add(MessageType.GpsCombinedCorrections, typeof(NetworkRtkData<GpsCombinedCorrectionDifferences>));
            _rtcmTypeMap.Add(MessageType.GpsNetworkResidual, typeof(GpsNetworkResidual));
            _rtcmTypeMap.Add(MessageType.GlonassNetworkResidual, typeof(GlonassNetworkResidual));
            _rtcmTypeMap.Add(MessageType.GpsNetworkFkpGradient, typeof(GpsNetworkFkpGradient));
            _rtcmTypeMap.Add(MessageType.GlonassNetworkFkpGradient, typeof(GlonassNetworkFkpGradient));
            
            
            _rtcmTypeMap.Add(MessageType.SystemParameters, typeof(SystemParametersData));
        }

        public Type GetMessageType(MessageType messageType)
        {
            throw new NotImplementedException();
        }
    }
}
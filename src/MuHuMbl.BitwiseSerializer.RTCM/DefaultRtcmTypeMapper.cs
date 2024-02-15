using MuHuMbl.BitwiseSerializer.RTCM.Enums;
using MuHuMbl.BitwiseSerializer.RTCM.Messages;
using MuHuMbl.BitwiseSerializer.RTCM.Messages.AntennaDescription;
using MuHuMbl.BitwiseSerializer.RTCM.Messages.AuxiliaryOperationInformation;
using MuHuMbl.BitwiseSerializer.RTCM.Messages.NetworkRtkCorrections;
using MuHuMbl.BitwiseSerializer.RTCM.Messages.NetworkRtkCorrections.Glonass;
using MuHuMbl.BitwiseSerializer.RTCM.Messages.NetworkRtkCorrections.Gps;
using MuHuMbl.BitwiseSerializer.RTCM.Messages.Observations.Glonass;
using MuHuMbl.BitwiseSerializer.RTCM.Messages.Observations.Gps;
using MuHuMbl.BitwiseSerializer.RTCM.Messages.Observations.Msm.Galileo;
using MuHuMbl.BitwiseSerializer.RTCM.Messages.Observations.Msm.Glonass;
using MuHuMbl.BitwiseSerializer.RTCM.Messages.Observations.Msm.Gps;
using MuHuMbl.BitwiseSerializer.RTCM.Messages.StateSpaceRepresentationParameters.Glonass;
using MuHuMbl.BitwiseSerializer.RTCM.Messages.StateSpaceRepresentationParameters.Gps;
using MuHuMbl.BitwiseSerializer.RTCM.Messages.StationCoordinates;
using MuHuMbl.BitwiseSerializer.RTCM.Messages.TransformationParameterInformation;

namespace MuHuMbl.BitwiseSerializer.RTCM
{
    public class DefaultRtcmTypeMapper : IRtcmTypeMapper
    {
        private readonly IDictionary<MessageType, Type> _rtcmTypeMap;

        public DefaultRtcmTypeMapper()
        {
            _rtcmTypeMap = new Dictionary<MessageType, Type>();
            
            AddMap<AntennaReferencePoint>(MessageType.AntennaReferencePoint);
            AddMap<AntennaReferencePointWithHeight>(MessageType.AntennaReferencePointWithHeight);  
            AddMap<PhysicalReferenceStationPosition>(MessageType.PhysicalReferenceStationPosition);  
            
            AddMap<AntennaDescriptor>(MessageType.AntennaDescriptor);  
            AddMap<AntennaDescriptorAndSerialNumber>(MessageType.AntennaDescriptorAndSerialNumber);  
            
            AddMap<GpsL1Only>(MessageType.GpsL1Only);
            AddMap<GpsL1OnlyExtended>(MessageType.GpsL1OnlyExtended);  
            AddMap<GpsL1L2>(MessageType.GpsL1L2);  
            AddMap<GpsL1L2Extended>(MessageType.GpsL1L2Extended);
            
            AddMap<GpsMsm1>(MessageType.GpsMsm1);  
            AddMap<GpsMsm2>(MessageType.GpsMsm2);  
            AddMap<GpsMsm3>(MessageType.GpsMsm3);  
            AddMap<GpsMsm4>(MessageType.GpsMsm4);
            AddMap<GpsMsm5>(MessageType.GpsMsm5);  
            AddMap<GpsMsm6>(MessageType.GpsMsm6);  
            AddMap<GpsMsm7>(MessageType.GpsMsm7);
            
            AddMap<GlonassL1Only>(MessageType.GlonassL1Only);
            AddMap<GlonassL1OnlyExtended>(MessageType.GlonassL1OnlyExtended);  
            AddMap<GlonassL1L2>(MessageType.GlonassL1L2);  
            AddMap<GlonassL1L2Extended>(MessageType.GlonassL1L2Extended);
            
            AddMap<GlonassMsm1>(MessageType.GlonassMsm1);  
            AddMap<GlonassMsm2>(MessageType.GlonassMsm2);  
            AddMap<GlonassMsm3>(MessageType.GlonassMsm3);  
            AddMap<GlonassMsm4>(MessageType.GlonassMsm4);
            AddMap<GlonassMsm5>(MessageType.GlonassMsm5);  
            AddMap<GlonassMsm6>(MessageType.GlonassMsm6);  
            AddMap<GlonassMsm7>(MessageType.GlonassMsm7);
            
            AddMap<GalileoMsm1>(MessageType.GalileoMsm1);  
            AddMap<GalileoMsm2>(MessageType.GalileoMsm2);  
            AddMap<GalileoMsm3>(MessageType.GalileoMsm3);  
            AddMap<GalileoMsm4>(MessageType.GalileoMsm4);
            AddMap<GalileoMsm5>(MessageType.GalileoMsm5);  
            AddMap<GalileoMsm6>(MessageType.GalileoMsm6);  
            AddMap<GalileoMsm7>(MessageType.GalileoMsm7);
            
            AddMap<NetworkAuxiliaryStationData>(MessageType.NetworkAuxiliaryStationData);
            
            AddMap<GpsIonosphericCorrection>(MessageType.GpsIonosphericCorrection);
            AddMap<GpsGeometricCorrection>(MessageType.GpsGeometricCorrection);
            AddMap<GpsCombinedCorrections>(MessageType.GpsCombinedCorrections);
            AddMap<GpsNetworkResidual>(MessageType.GpsNetworkResidual);
            AddMap<GpsNetworkFkpGradient>(MessageType.GpsNetworkFkpGradient);
            
            AddMap<GlonassNetworkResidual>(MessageType.GlonassNetworkResidual);
            AddMap<GlonassNetworkFkpGradient>(MessageType.GlonassNetworkFkpGradient);
            AddMap<GlonassIonosphericCorrection>(MessageType.GlonassIonosphericCorrection);
            AddMap<GlonassGeometricCorrection>(MessageType.GlonassGeometricCorrection);
            AddMap<GlonassCombinedCorrections>(MessageType.GlonassCombinedCorrections);
            
            AddMap<SystemParameters>(MessageType.SystemParameters);
            AddMap<GlonassEphemerisData>(MessageType.GlonassEphemerisData);
            AddMap<GpsEphemerisData>(MessageType.GpsEphemerisData);
            AddMap<UnicodeText>(MessageType.UnicodeText);
            AddMap<GlonassL1L2CodePhaseBiases>(MessageType.GlonassL1L2CodePhaseBiases);
            
            AddMap<HelmertAbridgedMolodenskiTransformationParameters>(MessageType.HelmertAbridgedMolodenskiTransformationParameters);
            AddMap<MolodenskiBadekasTransformationParameters>(MessageType.MolodenskiBadekasTransformationParameters);
            AddMap<EllipsoidalGridRepresentation>(MessageType.EllipsoidalGridRepresentation);
            AddMap<PlaneGridRepresentation>(MessageType.PlaneGridRepresentation);
            AddMap<NonLambertProjectionParameters>(MessageType.NonLambertProjectionParameters);
            AddMap<LambertProjectionParameters>(MessageType.LambertProjectionParameters);
            AddMap<ObliqueMercatorProjectionParameters>(MessageType.ObliqueMercatorProjectionParameters);
            
            AddMap<SsrGpsOrbitCorrection>(MessageType.SsrGpsOrbitCorrection);
            AddMap<SsrGpsClockCorrection>(MessageType.SsrGpsClockCorrection);
            AddMap<SsrGpsCodeBias>(MessageType.SsrGpsCodeBias);
            AddMap<SsrGpsCombinedOrbitClockCorrections>(MessageType.SsrGpsCombinedOrbitClockCorrections);
            AddMap<SsrGpsUra>(MessageType.SsrGpsUra);
            AddMap<SsrGpsHighRateClockCorrection>(MessageType.SsrGpsHighRateClockCorrection);
            
            AddMap<SsrGlonassOrbitCorrection>(MessageType.SsrGlonassOrbitCorrection);
            AddMap<SsrGlonassClockCorrection>(MessageType.SsrGlonassClockCorrection);
            AddMap<SsrGlonassCodeBias>(MessageType.SsrGlonassCodeBias);
            AddMap<SsrGlonassCombinedOrbitClockCorrections>(MessageType.SsrGlonassCombinedOrbitClockCorrections);
            AddMap<SsrGlonassUra>(MessageType.SsrGlonassUra);
            AddMap<SsrGlonassHighRateClockCorrection>(MessageType.SsrGlonassHighRateClockCorrection);
        }

        public void AddMap<T>(MessageType messageType, bool replace = false) where T : class, IRtcmMessage
        {
            _rtcmTypeMap.Add(messageType, typeof(T));
        }

        public Type GetMessageType(MessageType messageType)
        {
            if (!_rtcmTypeMap.TryGetValue(messageType, out var messageObjectType))
            {
                throw new NotSupportedException($"{messageType} message type is not supported");
            }

            return messageObjectType;
        }
        
        public bool TryGetMessageType(MessageType messageType, out Type messageObjectType)
        {
            return _rtcmTypeMap.TryGetValue(messageType, out messageObjectType);
        }
    }
}
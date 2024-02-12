namespace MuHuMbl.BitwiseSerializer.RTCM.Enums
{
    public enum MessageType : ushort
    {
        #region Observations
        
        GpsL1Only = 1001,
        GpsL1OnlyExtended = 1002,
        GpsL1L2 = 1003,
        GpsL1L2Extended = 1004,
        GlonassL1Only = 1009,
        GlonassL1OnlyExtended = 1010,
        GlonassL1L2 = 1011,
        GlonassL1L2Extended = 1012,
        GpsMsm1 = 1071,
        GpsMsm2 = 1072,
        GpsMsm3 = 1073,
        GpsMsm4 = 1074,
        GpsMsm5 = 1075,
        GpsMsm6 = 1076,
        GpsMsm7 = 1077,
        GlonassMsm1 = 1081,
        GlonassMsm2 = 1082,
        GlonassMsm3 = 1083,
        GlonassMsm4 = 1084,
        GlonassMsm5 = 1085,
        GlonassMsm6 = 1086,
        GlonassMsm7 = 1087,
        GalileoMsm1 = 1091,
        GalileoMsm2 = 1092,
        GalileoMsm3 = 1093,
        GalileoMsm4 = 1094,
        GalileoMsm5 = 1095,
        GalileoMsm6 = 1096,
        GalileoMsm7 = 1097,
        
        #endregion

        #region Station coordinates
        
        AntennaReferencePoint = 1005,
        AntennaReferencePointWithHeight = 1006,
        PhysicalReferenceStationPosition = 1032,
        
        #endregion

        #region Antenna Description 

        AntennaDescriptor = 1007,
        AntennaDescriptorAndSerialNumber = 1008,

        #endregion

        #region Receiver and Antenna Description

        ReceiverAndAntennaDescriptors = 1033,

        #endregion

        #region Network RTK Corrections 

        NetworkAuxiliaryStationData = 1014,
        GpsIonosphericCorrection = 1015,
        GpsGeometricCorrection = 1016,
        GpsCombinedCorrections = 1017,
        GpsNetworkResidual = 1030,
        GlonassNetworkResidual = 1031,
        GpsNetworkFkpGradient = 1034,
        GlonassNetworkFkpGradient = 1035,
        GlonassIonosphericCorrection = 1037,
        GlonassGeometricCorrection = 1038,
        GlonassCombinedCorrections = 1039,

        #endregion

        #region Auxiliary Operation Information 

        SystemParameters = 1013, 
        GpsEphemerisData = 1019,
        GlonassEphemerisData = 1020,
        UnicodeText = 1029,
        GlonassL1L2CodePhaseBiases = 1230,

        #endregion

        #region Transformation Parameter Information 

        HelmertAbridgedMolodenskiTransformationParameters = 1021,
        MolodenskiBadekasTransformationParameters = 1022,
        EllipsoidalGridRepresentation = 1023,
        PlaneGridRepresentation = 1024,
        NonLambertProjectionParameters = 1025,
        LambertProjectionParameters = 1026,
        ObliqueMercatorProjectionParameters = 1027,

        #endregion

        #region State Space Representation Parameters 

        SsrGpsOrbitCorrection = 1057,
        SsrGpsClockCorrection = 1058,
        SsrGpsCodeBias = 1059,
        SsrGpsCombinedOrbitClockCorrections = 1060,
        SsrGpsUra = 1061,
        SsrGpsHighRateClockCorrection = 1062,
        SsrGlonassOrbitCorrection = 1063,
        SsrGlonassClockCorrection = 1064,
        SsrGlonassCodeBias = 1065,
        SsrGlonassCombinedOrbitClockCorrections = 1066,
        SsrGlonassUra = 1067,
        SsrGlonassHighRateClockCorrection = 1068,

        #endregion
    }
}
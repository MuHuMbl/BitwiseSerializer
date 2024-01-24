namespace MuHuMbl.BitwiseSerializer.RTCM.Enums
{
    public enum SmoothingInterval : byte
    {
        None,
        Less30Seconds,
        From30To60Seconds,
        From1To2Minutes,
        From2To4Minutes,
        From4To8Minutes,
        MoreThan8Minutes,
        Unlimited
    }
}
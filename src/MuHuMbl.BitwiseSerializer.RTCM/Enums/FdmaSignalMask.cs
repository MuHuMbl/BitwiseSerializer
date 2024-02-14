namespace MuHuMbl.BitwiseSerializer.RTCM.Enums
{
    [Flags]
    public enum FdmaSignalMask : byte
    {
        None = 0,
        L1CACodePhaseBias = 1 << 3,
        L1PCodePhaseBias = 1 << 2,
        L2CACodePhaseBias = 1 << 1,
        L2PCodePhaseBias = 1 << 0,
    }
}
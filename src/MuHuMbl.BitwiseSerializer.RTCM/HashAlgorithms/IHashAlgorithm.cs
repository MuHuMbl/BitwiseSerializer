namespace MuHuMbl.BitwiseSerializer.RTCM;

public interface IHashAlgorithm
{
    uint GetHash(byte[] data);
}
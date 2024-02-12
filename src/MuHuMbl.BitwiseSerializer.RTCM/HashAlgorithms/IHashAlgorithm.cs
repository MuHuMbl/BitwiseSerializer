namespace MuHuMbl.BitwiseSerializer.RTCM.HashAlgorithms;

public interface IHashAlgorithm
{
    uint GetHash(byte[] data);
}
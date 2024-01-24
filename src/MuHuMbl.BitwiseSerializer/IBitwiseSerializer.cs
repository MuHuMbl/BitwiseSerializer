namespace MuHuMbl.BitwiseSerializer
{
    public interface IBitwiseSerializer
    {
        int GetSize<T>(object target);

        int GetSize(Type targetType, object target);
        
        byte[] Serialize(object target);

        T Deserialize<T>(byte[] source) where T : class, new();

        object Deserialize(Type type, byte[] source);

        IReadOnlyCollection<BitwisePropertyInfo> GetTypeMap<T>() where T : class, new();
        
        IReadOnlyCollection<BitwisePropertyInfo> GetTypeMap(Type type);
    }
}
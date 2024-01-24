namespace MuHuMbl.BitwiseSerializer;

public class BitwisePropertyInfo
{
    public bool IsMsmValue { get; set; }
    
    public int Order { get; init; }
    
    public string Name { get; init; }
    
    public Type Type { get; init; }
    
    public Func<object, int> SizeGetter { get; init; }
    
    public Func<object, object> PropertyGetter { get; set; }
    
    public Action<object, object> PropertySetter { get; init; }
}
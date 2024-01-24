using MuHuMbl.BitwiseSerializer.Enums;

namespace MuHuMbl.BitwiseSerializer.Attributes
{
    public abstract class BaseDataFieldAttribute : Attribute
    {
        public int Order { get; }
        
        public DataType DataType { get; }

        public abstract Func<object, int> BuildSizeGetter(Type targetType);

        protected BaseDataFieldAttribute(int order, DataType dataType)
        {
            Order = order;
            DataType = dataType;
        }

        
    }
}
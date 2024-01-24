using System.Linq.Expressions;
using MuHuMbl.BitwiseSerializer.Enums;

namespace MuHuMbl.BitwiseSerializer.Attributes
{
    public class DataFieldAttribute : BaseDataFieldAttribute
    {
        private readonly ulong _size;
        public DataFieldAttribute(int order, DataType dataType, ulong size) 
            : base(order, dataType)
        {
            _size = size;
        }

        public override Func<object, int> BuildSizeGetter(Type targetType)
        {
            var instance =  Expression.Parameter(typeof(object), "i");
            var property = Expression.Constant(_size);
            var call = Expression.Convert(property, typeof(int));
            return Expression.Lambda<Func<object, int>>(call, instance).Compile();
        }
    }
}
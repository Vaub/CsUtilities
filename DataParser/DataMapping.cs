using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataParser
{
    /// <summary>
    /// A simple mapping to map a field to a workable data-value
    /// </summary>
    public class DataMapping
    {
        public FieldInfo Field { get; }
        public bool IsNotNull { get; }

        public Func<object, object> ObjectConverter { get; }
        public Func<object, object> DataConverter { get; }

        public DataMapping(
            FieldInfo field,
            Func<object, object> objectConverter, 
            Func<object, object> dataConverter, 
            bool isNotNull = false)
        {
            Field = field;
            IsNotNull = isNotNull;

            ObjectConverter = objectConverter;
            DataConverter = dataConverter;
        }
    }
}

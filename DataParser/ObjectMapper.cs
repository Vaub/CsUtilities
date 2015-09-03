using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataParser
{
    public struct ObjectMapper<T>
    {
        public Dictionary<string, DataMapping> Mappings { get; }

        public ObjectMapper(Dictionary<string, DataMapping> mappings)
        {
            Mappings = mappings;
        }
    }
}

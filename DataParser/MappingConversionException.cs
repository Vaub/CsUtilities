using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataParser
{
    public class MappingConversionException : Exception
    {
        public MappingConversionException(string message, Exception originalException)
            : base($"{message}, exception : {originalException.Message}")
        {
        }
    }
}

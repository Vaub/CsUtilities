using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataParser
{
    /// <summary>
    /// Simple data writer, able to write any reader
    /// </summary>
    public interface IDataWriter<T>
    {
        void Write(IDataReader<T> reader);
    }
}

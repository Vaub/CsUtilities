using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataParser
{
    /// <summary>
    /// In case there's a need in the future.
    /// A reader is, for now, simply an IEnumerable
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDataReader<T> : IEnumerable<T>
    {
    }
}

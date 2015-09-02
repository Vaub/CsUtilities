using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Functional
{
    public static class Functional
    {
        public static void ForEach<T>(this IEnumerable<T> items, Action<T> func)
        {
            foreach (T item in items)
            {
                func(item);
            }
        }
    }
}

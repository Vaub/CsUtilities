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

        /// <summary>
        /// Wrap a value in a List to be used in an Enumerable
        /// Please do a null-check before using
        /// </summary>
        public static List<T> WrapToList<T>(this T value)
        {
            return new List<T>() { value };
        }
    }
}

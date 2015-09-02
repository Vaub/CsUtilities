using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Strings
{
    public static class Strings
    {
        public static string Join(this string separator, IEnumerable<string> items)
        {
            return string.Join(separator, items);
        }
    }
}

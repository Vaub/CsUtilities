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

        public static string ToSnakeCase(this string value)
        {
            return string
                .Concat(value
                    .ToCharArray()
                    .Select(s => char.IsUpper(s) ? "_" + s : s.ToString()))
                .ToLower()
                .Trim('_');
        }
    }
}

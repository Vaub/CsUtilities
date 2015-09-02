using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Strings
{
    public static class Strings
    {
        public static string Join(this char separator, IEnumerable<string> items)
        {
            StringBuilder builder = new StringBuilder();
            foreach (string item in items)
            {
                builder.Append($"{item}{separator}");
            }

            return builder.ToString().TrimEnd(separator);
        }
    }
}

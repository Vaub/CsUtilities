using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Colors
{
    public struct ArgbColor
    {
        public byte Alpha { get; }
        public byte Red { get; }
        public byte Green { get; }
        public byte Blue { get; }

        public ArgbColor(byte red, byte green, byte blue, byte alpha = 255)
        {
            Alpha = alpha;
            Red = red;
            Green = green;
            Blue = blue;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is ArgbColor))
            {
                return false;
            }

            var color = (ArgbColor)obj;
            return Alpha == color.Alpha && Red == color.Red && Green == color.Green && Blue == color.Blue;
        }

        public override int GetHashCode()
        {
            int hash = 37;
            hash = hash * 53 + Alpha.GetHashCode();
            hash = hash * 53 + Red.GetHashCode();
            hash = hash * 53 + Green.GetHashCode();
            hash = hash * 53 + Blue.GetHashCode();

            return hash;
        }


        /// <summary>
        /// Parse an aRGB color from a string
        /// </summary>
        /// <exception cref="FormatException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static ArgbColor FromString(string hexString)
        {
            hexString = hexString.TrimStart('#');
            if (hexString.Length != 6 && hexString.Length != 8)
            {
                throw new ArgumentException("String not a valid color.");
            }

            int color = Convert.ToInt32(hexString, 16);

            // Shifty time of the year
            int alpha = hexString.Length == 8 ? (color >> 24) & 0xFF : 255;
            int red = (color >> 16) & 0xFF;
            int green = (color >> 8) & 0xFF;
            int blue = (color >> 0) & 0xFF;

            return new ArgbColor((byte)red, (byte)green, (byte)blue, (byte)alpha);
        }
    }

    public static class HexColors
    {
        public static ArgbColor Red = new ArgbColor(255, 0, 0);
        public static ArgbColor Green = new ArgbColor(0, 255, 0);
        public static ArgbColor Blue = new ArgbColor(0, 0, 255);
    }
}

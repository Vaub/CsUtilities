using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utilities.Colors;

namespace UtilitiesTests.Colors
{
    [TestClass]
    public class ArgbColorTests
    {
        private const string A_RED_COLOR = "#FF0000";
        private const string A_TRANSPARENT_COLOR = "#00FFFF00";
        private const string AN_INVALID_COLOR = "#ABCZZZ";
        private const string AN_INVALID_COLOR_STRING = "#ABCZZZZ";

        [TestMethod]
        public void GivenAValidRedColorWhenConvertingShouldCreateAColor()
        {
            string hexColor = A_RED_COLOR;
            var color = ArgbColor.FromString(hexColor);
            Assert.AreEqual(HexColors.Red, color);
        }

        [TestMethod]
        public void GivenAValidTransparentColorWhenConvertingShouldCreateAColor()
        {
            string hexColor = A_TRANSPARENT_COLOR;
            var color = ArgbColor.FromString(hexColor);
            Assert.AreEqual(new ArgbColor(255, 255, 0, 0), color);
        }

        [TestMethod, ExpectedException(typeof(FormatException))]
        public void GivenAnInvalidColorWhenConvertingShouldThrowAnException()
        {
            string hexColor = AN_INVALID_COLOR;
            ArgbColor.FromString(hexColor);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void GivenAnInvalidColorStringWhenConvertingShouldThrowAnException()
        {
            string hexColor = AN_INVALID_COLOR_STRING;
            ArgbColor.FromString(hexColor);
        }

        [TestMethod]
        public void HashCodeTest()
        {
            ArgbColor aColor = ArgbColor.FromString(A_RED_COLOR);
            ArgbColor anotherColor = ArgbColor.FromString(A_RED_COLOR);

            Assert.AreEqual(aColor.GetHashCode(), anotherColor.GetHashCode());
        }
    }
}

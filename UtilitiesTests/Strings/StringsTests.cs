using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Utilities.Strings;

namespace UtilitiesTests.Strings
{
    [TestClass]
    public class StringsTests
    {
        private const string A_CAMEL_CASE_STRING = "howAreYou";
        private const string A_SNAKE_CASE_STRING = "how_are_you";

        [TestMethod]
        public void JoinTest()
        {
            IEnumerable<string> strings = new List<string>() { "Hello", "World" };
            var joinedValue = ",".JoinEnum(strings);
            Assert.AreEqual("Hello,World", joinedValue);
        }

        [TestMethod]
        public void ToSnakeCaseTest()
        {
            var thisIsSnakeCase = A_CAMEL_CASE_STRING.ToSnakeCase();
            Assert.AreEqual(A_SNAKE_CASE_STRING, thisIsSnakeCase);
        }
    }
}

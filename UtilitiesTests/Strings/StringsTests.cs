using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Utilities.Strings;

namespace UtilitiesTests.Strings
{
    [TestClass]
    public class StringsTests
    {
        [TestMethod]
        public void JoinTest()
        {
            IEnumerable<string> strings = new List<string>() { "Hello", "World" };
            var joinedValue = ",".Join(strings);
            Assert.AreEqual("Hello,World", joinedValue);
        }
    }
}

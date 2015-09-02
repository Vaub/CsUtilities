using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Utilities.Functional;
using System.Linq;

namespace UtilitiesTests.Functional
{
    [TestClass]
    public class FunctionalTests
    {
        [TestMethod]
        public void ForEachTest()
        {
            IEnumerable<string> strings = new List<string>() { "Hello", "World" };

            int numberOfStrings = 0;
            strings.ForEach((string item) => numberOfStrings++);

            Assert.AreEqual(strings.Count(), numberOfStrings);
        }
    }
}

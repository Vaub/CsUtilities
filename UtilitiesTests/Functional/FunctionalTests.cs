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
        private const string A_VALUE = "Hello!";

        [TestMethod]
        public void ForEachTest()
        {
            IEnumerable<string> strings = new List<string>() { "Hello", "World" };

            int numberOfStrings = 0;
            strings.ForEach((string item) => numberOfStrings++);

            Assert.AreEqual(strings.Count(), numberOfStrings);
        }

        public void ToListTest()
        {
            var aValue = A_VALUE;
            var aWrapedValue = aValue.WrapToList();
            Assert.AreEqual(A_VALUE, aWrapedValue.First());
        }
    }
}

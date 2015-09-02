using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utilities.Option;

namespace UtilitiesTests.Option
{
    [TestClass]
    public class OptionTests
    {
        private int? NotNullObject;
        private int? NullObject;

        [TestInitialize]
        public void Init()
        {
            NotNullObject = 3;
            NullObject = null;
        }

        [TestMethod]
        public void IsPresentTest()
        {
            Assert.IsTrue(NotNullObject.IsPresent());
            Assert.IsFalse(NullObject.IsPresent());
        }

        [TestMethod]
        public void IfPresentTest()
        {
            bool shouldChange = false;
            bool shouldNotChange = true;

            NotNullObject.IfPresent((value) => shouldChange = true);
            NullObject.IfPresent((value) => shouldNotChange = false);

            Assert.IsTrue(shouldChange);
            Assert.IsTrue(shouldNotChange);
        }

        [TestMethod, ExpectedException(typeof(ValueNotPresentException))]
        public void GetTest()
        {
            Assert.AreEqual(NotNullObject, NotNullObject.Get());
            Assert.AreEqual(NullObject, NullObject.Get());
        }

        [TestMethod]
        public void OrElseTest()
        {
            int? orElseValue = 6;

            Assert.AreEqual(NotNullObject, NotNullObject.OrElse(orElseValue));
            Assert.AreEqual(orElseValue, NullObject.OrElse(orElseValue));
        }

        [TestMethod, ExpectedException(typeof(Exception))]
        public void OrElseThrow()
        {
            Assert.AreEqual(NotNullObject, NotNullObject.OrElseThrow(new Exception()));
            Assert.AreEqual(NullObject, NullObject.OrElseThrow(new Exception()));
        }
    }
}

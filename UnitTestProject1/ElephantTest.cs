using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using zoo;

namespace UnitTestProject1
{
    [TestClass]
    public class ElephantTest
    {
        private Elephant _elephant;

        [TestInitialize]
        public void SetupElephant()
        {
             _elephant = new Elephant();
        }

        [TestMethod]
        public void TestWeight()
        {
            _elephant.Weight = 100;
            Assert.AreEqual(100, _elephant.Weight);

            _elephant.Weight = 101;
            Assert.AreEqual(101, _elephant.Weight);

            try
            {
                _elephant.Weight = 99;
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestWeightIllegal()
        {
            _elephant.Weight = 99;
        }
    }
}

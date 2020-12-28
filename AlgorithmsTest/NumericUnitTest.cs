using Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTest
{
    [TestClass]
    public class NumericUnitTest
    {
        [TestMethod]
        public void GcdTestMethod()
        {
            var result = Numeric.Gcd(4851, 3003);
            Assert.AreEqual(result, 231);
        }

        [TestMethod]
        public void FindPrimesTestMethod()
        {
            var result = Numeric.FindPrimes(13);
            Assert.AreEqual(result.Count, 6);
            Assert.AreEqual(result[0], 2);
            Assert.AreEqual(result[1], 3);
            Assert.AreEqual(result[2], 5);
            Assert.AreEqual(result[3], 7);
            Assert.AreEqual(result[4], 11);
            Assert.AreEqual(result[5], 13);
        }
    }
}

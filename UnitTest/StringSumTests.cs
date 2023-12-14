using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class StringSumTests
    {
        [TestMethod]
        public void Should_Sum_Two_Natural_Numbers()
        {
            int sum = StringSum.Sum("1", "1");
            Assert.AreEqual(2, sum);
        }
        [TestMethod]
        public void Should_Sum_Zero_and_Natural_Numbers()
        {
            int sum = StringSum.Sum("-1", "1");
            Assert.AreEqual(1, sum);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_Send_an_Error()
        {
            int sum = StringSum.Sum("uno", "1");
        }
        [TestMethod]
        public void Should_Treat_As_Zero_Decimal_Numbers()
        {
            int sum = StringSum.Sum("1.1", "1");
            Assert.AreEqual(1, sum);         
        }
        [TestMethod]
        public void Should_Treat_As_Zero_Decimal_Numbers_2()
        {
            int sum = StringSum.Sum("1.1", "10.5");
            Assert.AreEqual(0, sum);
        }
    }
}

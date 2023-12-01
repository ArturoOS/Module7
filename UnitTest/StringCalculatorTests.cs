using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class StringCalculatorTests
    {
        [TestMethod]
        public void Should_sum_two_numbers()
        {
            int sum = StringCalculator.Add("1,2,3");
            Assert.AreEqual(6, sum);
        }
        [TestMethod]
        public void Shoudl_sum_two_numbers_delimiters()
        {
            int sum = StringCalculator.Add("1;2\n3");
            Assert.AreEqual(6, sum);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_Send_an_Error_negative()
        {
            int sum = StringCalculator.Add("-1,2,3");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_Send_an_Error_string()
        {
            int sum = StringCalculator.Add("uno,2,3");
        }
    }
}

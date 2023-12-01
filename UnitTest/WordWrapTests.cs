using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class WordWrapTests
    {
        [TestMethod]
        public void Should_return_space_count()
        {
            int count = WordWrap.Wrap("THIS is a SMALL test 123");
            Assert.AreEqual(5, count);
        }
        [TestMethod]
        public void Should_return_newline_count()
        {
            int count = WordWrap.Wrap("THIS is another \n SMALL test 123");
            Assert.AreEqual(5, count);
        }
        [TestMethod]
        public void Should_return_newline_and_space_count()
        {
            int count = WordWrap.Wrap("   THIS is another \n SMALL test 123    ");
            Assert.AreEqual(5, count);
        }
        [TestMethod]
        public void Should_return_multinewline_and_space_count()
        {
            int count = WordWrap.Wrap("  \nTHIS is another \n SMALL test 123    ");
            Assert.AreEqual(5, count);
        }
    }
}

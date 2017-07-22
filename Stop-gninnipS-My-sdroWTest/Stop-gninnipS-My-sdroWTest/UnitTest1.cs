using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Stop_gninnipS_My_sdroWTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_Empty_Should_Be_Empty()
        {
            var input = string.Empty;
            var expected = string.Empty;
            var actual = Kata.spinWords(input);
            Assert.AreEqual(expected,actual);
        }
    }

    public class Kata
    {
        public static string spinWords(string input)
        {
            return input;
        }
    }
}

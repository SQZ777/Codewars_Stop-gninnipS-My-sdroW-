using System;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Stop_gninnipS_My_sdroWTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_Empty_Should_Be_Empty()
        {
            spinResult(string.Empty, string.Empty);
        }

        [TestMethod]
        public void Input_aAAa_Should_Be_aAAa()
        {
            spinResult("aAAa", "aAAa");
        }

        [TestMethod]
        public void Input_Hello_Should_Be_olleH()
        {
            spinResult("Hello", "olleH");
        }
        
        private static void spinResult(string input, string expected)
        {
            var actual = Kata.spinWords(input);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public static string spinWords(string input)
        {
            if (input.Length > 4)
            {
                char[] inputArray = input.ToCharArray();
                Array.Reverse(inputArray);
                return new string(inputArray);
            }
            return input;
        }
    }
}

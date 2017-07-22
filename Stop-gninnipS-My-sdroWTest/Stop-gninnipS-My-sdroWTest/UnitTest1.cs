using System;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

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

        [TestMethod]
        public void Input_Hello_World_Should_Be_olleH_dlroW()
        {
            spinResult("Hello World", "olleH dlroW");
        }

        [TestMethod]
        public void Input_Welcome_Should_Be_emocleW()
        {
            spinResult("Welcome", "emocleW");
        }

        [TestMethod]
        public void Input_Hey_fellow_warriors_Should_Be_Hey_wollef_sroirraw()
        {
            spinResult("Hey fellow warriors","Hey wollef sroirraw");
        }

        [TestMethod]
        public void Input_This_is_a_test_Should_Be_This_is_a_test()
        {
            spinResult("This is a test","This is a test");
        }

        [TestMethod]
        public void Input_This_is_another_test_Should_Be_This_is_rehtona_test()
        {
            spinResult("This is another test", "This is rehtona test");
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
            string[] inputArray = input.Split();
            for (int i = 0; i < inputArray.Length; i++)
                inputArray[i] = reverseArray(inputArray[i].ToCharArray());
            return string.Join(" ", inputArray);
        }
        private static string reverseArray(char[] inputArray)
        {
            if (inputArray.Length > 4)
                Array.Reverse(inputArray);
            return new string(inputArray);
        }
    }
}

using System.Globalization;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_ConvertStringToCamelCase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_dash_Should_Be_Empty()
        {
            Assert.AreEqual(string.Empty, Kata.ToCamelCase("-"));
        }

        [TestMethod]
        public void Input_underscore_Should_Be_Empty()
        {
            Assert.AreEqual(string.Empty, Kata.ToCamelCase("_"));
        }

        [TestMethod]
        public void Input_adash_Should_Be_a()
        {
            Assert.AreEqual("a", Kata.ToCamelCase("a-"));
        }

        [TestMethod]
        public void UpperTitle_Input_Abc_Should_Be_abc()
        {
            Assert.AreEqual("Abc", Kata.UpperTitle("abc"));
        }

    }

    public class Kata
    {
        public static string ToCamelCase(string s)
        {
            var strs = s.Split(s.Contains("-") ? '-' : '_');
            return strs.Aggregate(string.Empty, (current, str) => current + str);
        }


        public static string UpperTitle(string str)
        {
            return str.Substring(0, 1).ToUpper() + (str.Length > 1 ? str.Substring(1) : string.Empty);
        }
    }
}

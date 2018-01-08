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
            Assert.AreEqual("a",Kata.ToCamelCase("a-"));
        }

        [TestMethod]
        public void Input_adashb_Should_Be_aB()
        {
            Assert.AreEqual("aB",Kata.ToCamelCase("a-b"));
        }

    }

    public class Kata
    {
        public static string ToCamelCase(string s)
        {
            var strs = s.Split(s.Contains("-") ? '-' : '_');
            return strs.Aggregate(string.Empty, (current, str) => current + str);
        }
    }
}

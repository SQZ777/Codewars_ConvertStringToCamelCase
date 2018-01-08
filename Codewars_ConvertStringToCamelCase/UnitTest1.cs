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

    }

    public class Kata
    {
        public static string ToCamelCase(string s)
        {
            string[] strs;
            if (s.Contains("-"))
            {
                strs = s.Split('-');
            }
            else
            {
                strs = s.Split('_');
            }
            var result = string.Empty;
            foreach (var str in strs)
            {
                result += str;
            }
            return result;
        }
    }
}

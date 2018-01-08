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
            Assert.AreEqual(string.Empty,Kata.ToCamelCase("-"));
        }
    }

    public class Kata
    {
        public static string ToCamelCase(string s)
        {
            var strs = s.Split('-');
            var result = string.Empty;
            foreach (var str in strs)
            {
                result += str;
            }
            return result;
        }
    }
}

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
            throw new System.NotImplementedException();
        }
    }
}

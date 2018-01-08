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

        [TestMethod]
        public void UpperTitle_Input_aBC_Should_Be_Abc()
        {
            Assert.AreEqual("Abc", Kata.UpperTitle("aBC"));
        }

        [TestMethod]
        public void Input_adashb_Should_Be_aB()
        {
            Assert.AreEqual("aB", Kata.ToCamelCase("a-b"));
        }

        [TestMethod]
        public void Input_aunderb_Should_Be_aB()
        {
            Assert.AreEqual("aB", Kata.ToCamelCase("a_b"));
        }

        [TestMethod]
        public void Input_Aunderb_Should_Be_AB()
        {
            Assert.AreEqual("AB", Kata.ToCamelCase("A_b"));
        }

        [TestMethod]
        public void Input_appledashBIRD_Should_Be_appleBird()
        {
            Assert.AreEqual("appleBird", Kata.ToCamelCase("apple-BIRD"));
        }

        [TestMethod]
        public void Input_ASIApeople_Should_Be_AsiaPeople()
        {
            Assert.AreEqual("Asiapeople", Kata.ToCamelCase("ASIApeople"));
        }

    }

    public class Kata
    {
        public static string ToCamelCase(string s)
        {
            var strs = s.Split(s.Contains("-") ? '-' : '_');
            strs[0] = (strs[0].Length > 1) ? strs[0][0] + strs[0].Substring(1).ToLower() : strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                strs[i] = UpperTitle(strs[i]);
            }
            return string.Join("", strs);
        }


        public static string UpperTitle(string str)
        {
            if (string.IsNullOrEmpty(str))
                return string.Empty;
            return str.Substring(0, 1).ToUpper() + (str.Length > 1 ? str.Substring(1).ToLower() : string.Empty);
        }
    }
}

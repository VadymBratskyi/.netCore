using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssertSamplesTest
{
    [TestClass]
    public class StringAssertsMethod
    {
        [TestMethod]
        public void StringContainsTest()
        {
            StringAssert.Contains("Hello World", "World");
        }

        [TestMethod]
        public void StringMatchesTest()
        {
            StringAssert.Matches("123", new Regex(@"\d{3}") );
        }

        [TestMethod]
        public void StringStartWithTest()
        {
            StringAssert.StartsWith("Hello World","Hello");
        }

        [TestMethod]
        public void StringEndsWithTest()
        {
            StringAssert.EndsWith("Hello World", "World");
        }
    }
}

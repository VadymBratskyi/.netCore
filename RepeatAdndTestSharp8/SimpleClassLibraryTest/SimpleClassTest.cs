using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleClassLibrary;

namespace SimpleClassLibraryTest
{
    [TestClass]
    public class SimpleClassTest
    {
        [TestMethod]
        public void Add_2_3_Result_5()
        {
            SimpleClass instance = new SimpleClass();
            int x = 2, y = 3, expected = 5;

            int actual = instance.Add(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Div_10_2_Result_5()
        {
            SimpleClass instance = new SimpleClass();
            int x = 10, y = 2, expected = 5;

            int actual = instance.Div(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Div_10_0_Result_ExceptionExpected()
        {
            SimpleClass instance = new SimpleClass();
            int x = 10, y = 0;

            int actual = instance.Div(x, y);

        }
    }
}

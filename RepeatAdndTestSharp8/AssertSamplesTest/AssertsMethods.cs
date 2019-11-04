using System;
using AssertSamples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssertSamplesTest
{
    [TestClass]
    public class AssertsMethods
    {
        [TestMethod]
        public void IsSqrtTest()
        {
            //arrange
            const double input = 4;
            const double expected = 2;

            //act
            double actual = MyClass.GeSqrt(input);

            //assert
            Assert.AreEqual(expected, actual, "Sqrt of {0} should have been {1}", input, expected);
        }

        [TestMethod]
        public void DeltaTest()
        {
            //arrange
            const double expected = 3.1;
            const double delta = 0.07;

            //act
            double actual = MyClass.GeSqrt(10);

            //assert
            Assert.AreEqual(expected, actual, delta, "fail message!!!");
        }

        [TestMethod]
        public void StringAreEqualTest()
        {
            //arrange
            const string a = "HELLO";
            const string b = "hello";
            
            //assert
            Assert.AreEqual(a, b, true);
        }


        [TestMethod]
        public void StringSameTest()
        {
            //arrange
            const string a = "hello";
            const string b = "hello";
            
            //assert
            Assert.AreSame(a, b);
        }

        [TestMethod]
        public void IntSameTest()
        {
            //arrange
            const int a = 10;
            const int b = 10;

            //assert
            Assert.AreSame(a, b);
        }

    }
}

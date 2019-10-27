using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalcLibrery;

namespace MyCalcTest
{
    [TestClass]
    public class MyCalcTests
    {
        [TestMethod]
        public void Sum_10and20_30returned()
        {
            //arrange
            var x = 10;
            var y = 20;
            int expected = 30;
            
            //act
            MyCalc c = new MyCalc();
            var actual = c.Sum(x, y);
            
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sum_30and20_50returned()
        {
            //arrange
            var x = 30;
            var y = 20;
            int expected = 50;

            //act
            MyCalc c = new MyCalc();
            var actual = c.Sum(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}

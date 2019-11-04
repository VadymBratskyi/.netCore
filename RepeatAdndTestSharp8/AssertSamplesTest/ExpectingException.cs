using System;
using AssertSamples;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AssertSamplesTest
{
    [TestClass]
    public class ExpectingException
    {
        [ExpectedException(typeof(ArgumentNullException), "Exception wos not throw")]
        [TestMethod]
        public void MyClass_SayHello_Exception()
        {
            MyClass my = new MyClass();
            my.SayHello(null);
        }

        [TestMethod]
        public void MyClass_SayHello_ReturnVados()
        {
            var name = "Vados";
            var expected = "Hello Vados";

            MyClass my = new MyClass();
            var actual = my.SayHello(name);

            Assert.AreEqual(expected, actual);
        }
    }
}

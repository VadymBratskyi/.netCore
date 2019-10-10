using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalcLibrery;

namespace PasswordChekerTest
{
    [TestClass]
    public class PasswordStrengthChekerTests
    {
        [TestMethod]
        public void GetPassw0rdStrength_AllChars_5Point()
        {
            //arrange
            var password = "P2ssw0rd#";
            int expected = 5;

            //act
            int actual = PasswordStrengthCheker.GetPassw0rdStrength(password);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPasswordStrength_UpperCase_3Point()
        {
            //arrange
            var password = "Password";
            int expected = 3;


            //act
            int actual = PasswordStrengthCheker.GetPassw0rdStrength(password);
            
            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void GetPasswordStrength_ContainsNumber_0_4Point()
        {
            //arrange
            var password = "Passw0rd";
            int expected = 4;


            //act
            int actual = PasswordStrengthCheker.GetPassw0rdStrength(password);

            //assert
            Assert.AreEqual(expected, actual);

        }

    }
}

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssertSamplesTest
{
    [TestClass]
    public class CollectionAssertsMethods
    {
        static List<string> employees;

        [ClassInitialize]
        public static void InitCurrentTest(TestContext context)
        {
            employees = new List<string>()
            {
                "Ivan", "Anton", "Sergey", "Roman"
            };
        }


        [TestMethod]
        public void AllItemsAreNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(employees, "Not null field");
        }

        [TestMethod]
        public void AllItemsAreUnique()
        {
            CollectionAssert.AllItemsAreUnique(employees, "Uniquess field");
        }

        [TestMethod]
        public void AreEqual()
        {
            var employeeTest = new List<string>()
            {
                "Anton", "Ivan", "Sergey", "Roman"
            };
            //проверка на равенство и порядок еолементов
            CollectionAssert.AreEqual(employees, employeeTest);
        }

        [TestMethod]
        public void AreEquivalent()
        {
            var employeeTest = new List<string>()
            {
                "Sergey", "Ivan", "Anton", "Roman"
            };
            //проверка на равенство на елементы но не порядок
            CollectionAssert.AreEquivalent(employees, employeeTest);
        }

        [TestMethod]
        public void employee_Subset()
        {
            var employeeTest = new List<string>();

            employeeTest.Add(employees[2]);
            //employeeTest.Add("Alex");
            //проверка двух массивов на вход одинакових елементов
            CollectionAssert.IsSubsetOf(employeeTest, employees, "failed");
        }
    }
}

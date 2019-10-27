using System;
using System.Configuration;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopingCartLibrary;

namespace ShopingCartTest
{
    [TestClass]
    public class ClassInitAndCleanUp
    {
        private static ShopingCart cart;

        //запуск один раз перед запуском первого тест метода
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Debug.WriteLine("ClassInitialize");
            var item = new Item();
            item.Name = "Unit Test Sho Cart";
            item.Quantity = 10;

            cart = new ShopingCart();
            cart.Add(item);

        }

        //запуск один раз после последнего тест метода 
        [ClassCleanup]
        public static void CleanUp()
        {
            Debug.WriteLine("ClassCleanUp");
            cart.Dispose();
        }

        [TestMethod]
        public void ShopingCart_AddToCart()
        {
            var expected = cart.Count + 1;

            cart.Add(new Item() { Name = "Test", Quantity = 1});

            Assert.AreEqual(expected, cart.Count);

        }

        [TestMethod]
        public void ShopingCart_Contains()
        {
            var expected = 2;

            Assert.AreEqual(expected, cart.Count);

        }
    }
}

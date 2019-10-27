using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopingCartLibrary;

namespace ShopingCartTest
{
    [TestClass]
    public class MethodInitAndCleanUp
    {
        private ShopingCart cart;
        private Item item;

        //запуск перед каждим тест методом
        [TestInitialize]
        public void TestInitialize()
        {
            Debug.WriteLine("TestInitialize");
            item = new Item();
            item.Name = "Unit Test Sho Cart";
            item.Quantity = 10;

            cart = new ShopingCart();
            cart.Add(item);
        }

        //запуск после каждого тест метода
        [TestCleanup]
        public void CleanUp()
        {
            Debug.WriteLine("TestCleanUp");
            cart.Dispose();
        }

        [TestMethod]
        public void ShopingCart_CheckOut_ContainsItems()
        {
            CollectionAssert.Contains(cart.Items, item);
        }

        [TestMethod]
        public void ShopingCart_RemoveItem_Empty()
        {
            var expected = 0;

            cart.Remove(item);

            Assert.AreEqual(expected, cart.Count);
        }
    }
}

using System;
using System.Collections.Generic;

namespace ShopingCartLibrary
{
    public class ShopingCart: IDisposable
    {
        public List<Item> Items = new List<Item>();

        public int Count
        {
            get { return Items.Count; }
        }

        public void Add(Item item)
        {
            Items.Add(item);
        }

        public void Remove(Item item)
        {
            Items.Remove(item);
        }

        public void Dispose()
        {
            //cleanup
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}

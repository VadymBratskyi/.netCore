using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatAdndTestSharp8.SDerializable
{
    [Serializable]
    public class City
    {
        public string Name { get; set; }

        public City() { }
        public City(string name) {
            Name = name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatAdndTestSharp8.SDerializable
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Year { get; set; }

        private string Phone { get; set; }//for xml not visible

        [NonSerialized]
        public string accNumber;

        public City City { get; set; }

        public Person()
        {
        }

        public Person(string name, int year, string acc)
        {
            Name = name;
            Year = year;
            accNumber = acc;
            Phone = "102";
        }
    }
}

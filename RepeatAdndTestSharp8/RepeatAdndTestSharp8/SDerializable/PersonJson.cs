using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace RepeatAdndTestSharp8.SDerializable
{
    [DataContract]
    public class PersonJson
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Year { get; set; }
        [DataMember]
        public CityJson City { get; set; }

        public PersonJson()
        {
        }

        public PersonJson(string name, int year, string acc)
        {
            Name = name;
            Year = year;
            City = new CityJson("JSCity");
        }
    }
}

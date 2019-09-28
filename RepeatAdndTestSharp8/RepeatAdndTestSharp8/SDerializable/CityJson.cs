using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace RepeatAdndTestSharp8.SDerializable
{
    [DataContract]
    public class CityJson
    {
        [DataMember]
        public string Name { get; set; }

        public CityJson() { }
        public CityJson(string name) {
            Name = name;
        }
    }
}

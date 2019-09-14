using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatAdndTestSharp8.Models
{
    class Employee : People
    {
        public string Company { get; set; }
        public Employee(string name, string company) : base(name)
        {
            Company = company;
        }

        public void Display() { }
    }
}

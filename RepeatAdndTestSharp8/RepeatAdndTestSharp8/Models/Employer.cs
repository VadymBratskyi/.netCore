using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatAdndTestSharp8.Models
{
    class Employer : People
    {
        public string Bank { get; set; }
        public Employer(string name, string bank) : base(name)
        {
            Bank = bank;
        }
    }
}

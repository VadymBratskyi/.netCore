using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerLibrary.CLasses
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public Address Email { get; set; }
        public StatusLevel StatusLevel { get; set; }

        public Customer() { }
        public Customer(string firstName, string lasName) {
            FirstName = firstName;
            LastName = lasName;
        }

        public Customer(string fullName)
        {
            FullName = fullName;
        }

    }
}

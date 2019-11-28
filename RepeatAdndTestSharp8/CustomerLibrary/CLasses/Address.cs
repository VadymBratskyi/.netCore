using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerLibrary.CLasses
{
    public class Address
    {
        public string Email { get; set; }

        public Address(CustomerTDO customerTDO) {
            Email = customerTDO.LastName + customerTDO.FirstName + "@gmil.com";
        }

    }
}

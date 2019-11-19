using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerLibrary.CLasses
{
    public class CustomerTDO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public StatusLevel StatusLevel { get; set; }
        public string Email { get; set; }

    }
}

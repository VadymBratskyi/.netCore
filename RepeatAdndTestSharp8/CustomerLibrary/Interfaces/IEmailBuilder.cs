using CustomerLibrary.CLasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerLibrary.Interfaces
{
    public interface IEmailBuilder
    {
        Address From(CustomerTDO customer);
    }
}

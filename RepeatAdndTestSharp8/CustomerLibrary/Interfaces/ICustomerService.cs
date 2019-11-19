using CustomerLibrary.CLasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerLibrary.Interfaces
{
    public interface ICustomerService
    {
        void Save(Customer customer);
        void SaveExtended(Customer customer);
    }
}

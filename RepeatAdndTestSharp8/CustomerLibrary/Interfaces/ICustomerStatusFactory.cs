using CustomerLibrary.CLasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerLibrary.Interfaces
{
    public interface ICustomerStatusFactory
    {
        StatusLevel CreateFrom(CustomerTDO customer);

		Address CreateAdreesFrom(CustomerTDO customer);

	}
}

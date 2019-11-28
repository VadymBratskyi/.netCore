using CustomerLibrary.CLasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerLibrary.Interfaces
{
    public interface IMailAddressFactory
    {
        bool TryParse(string mail, out Address mailAddress);
		void CreateMessage(string message);
    }
}

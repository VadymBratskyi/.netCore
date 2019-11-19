using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerLibrary.Interfaces
{
    public interface IFullNameBuilder
    {
        string CreateFullName(string firstName, string lastName);
    }
}

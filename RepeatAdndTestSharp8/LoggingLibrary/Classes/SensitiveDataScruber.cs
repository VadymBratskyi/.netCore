using LoggingLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingLibrary.Classes
{
    public class SensitiveDataScruber : ISensitiveDataScruber
    {
        public string ClearMessage(string message)
        {
            return "SensitiveDataScruber.ClearMessage: " + message;
        }
    }
}

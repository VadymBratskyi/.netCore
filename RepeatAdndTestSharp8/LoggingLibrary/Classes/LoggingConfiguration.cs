using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggingLibrary.Interfaces;

namespace LoggingLibrary.Classes
{
    public class LoggingConfiguration : ILoggingConfiguration
    {
        public bool LogSteckFor(LogLevel level)
        {
            if (level == LogLevel.Error)
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}

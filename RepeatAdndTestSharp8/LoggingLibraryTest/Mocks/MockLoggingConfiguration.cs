using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggingLibrary;
using LoggingLibrary.Interfaces;

namespace LoggingLibraryTest.Mocks
{
    public class MockLoggingConfiguration : ILoggingConfiguration
    {
        public bool LogSteckFor(LogLevel level)
        {
            return false;
        }
    }
}

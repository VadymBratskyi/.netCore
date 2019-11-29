using LoggingLibrary;
using LoggingLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingLibraryTest.Mocks
{
    public class MockMessageHeaderGenerator : IMessageHeaderGenerator
    {
        public bool CreateHeaderWasCalled { get; private set; }
        public void CreateHeader(LogLevel level)
        {
            CreateHeaderWasCalled = true;
        }
    }
}

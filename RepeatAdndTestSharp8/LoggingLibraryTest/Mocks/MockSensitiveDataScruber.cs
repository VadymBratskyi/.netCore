using LoggingLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingLibraryTest.Mocks
{
    public class MockSensitiveDataScruber : ISensitiveDataScruber
    {
        public bool ClearMessageWasCalled { get; private set; }
        public string ClearMessage(string message)
        {
            ClearMessageWasCalled = true;
            return message;
        }
    }
}

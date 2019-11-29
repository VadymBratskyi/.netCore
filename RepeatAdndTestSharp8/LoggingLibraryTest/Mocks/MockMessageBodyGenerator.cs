using LoggingLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingLibraryTest.Mocks
{
    public class MockMessageBodyGenerator : IMessageBodyGenerator
    {
        public bool CreateBodyWasCalled { get; private set; }
        public void CreateBody(string message)
        {
            CreateBodyWasCalled = true;
        }
    }
}

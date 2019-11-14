using LoggingLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingLibrary.Classes
{
    public class MessageBodyGenerator : IMessageBodyGenerator
    {
        public void CreateBody(string message)
        {
            Debug.WriteLine("MessageBodyGenerator.CreateBody");
        }
    }
}

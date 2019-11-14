using LoggingLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingLibrary.Classes
{
    public class MessageHeaderGenerator : IMessageHeaderGenerator
    {
        public void CreateHeader(LogLevel level)
        {
            Debug.WriteLine("MessageHeaderGenerator.CreateHeader");
        }
    }
}

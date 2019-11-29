using LoggingLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingLibrary
{
    public class Logger
    {
        private ISensitiveDataScruber _sensitiveDataScruber;
        private IMessageBodyGenerator _messageBodyGenerator;
        private IMessageHeaderGenerator _messageHeaderGenerator;
        private ILoggingConfiguration _loggingConfiguration;

        public Logger (ISensitiveDataScruber sensitiveDataScruber, IMessageBodyGenerator messageBodyGenerator,
            IMessageHeaderGenerator messageHeaderGenerator, ILoggingConfiguration loggingConfiguration)
        {
            _sensitiveDataScruber = sensitiveDataScruber;
            _messageBodyGenerator = messageBodyGenerator;
            _messageHeaderGenerator = messageHeaderGenerator;
            _loggingConfiguration = loggingConfiguration;
        }


        public void CreteEntry(string message, LogLevel level) {

            _messageHeaderGenerator.CreateHeader(level);

            if (_loggingConfiguration.LogSteckFor(level)) {
                Console.WriteLine("Stack: ");
            }

            var clearMessage = _sensitiveDataScruber.ClearMessage(message);
            _messageBodyGenerator.CreateBody(message);

        }
        
    }
}

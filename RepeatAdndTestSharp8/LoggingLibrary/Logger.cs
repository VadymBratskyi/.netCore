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
        
    }
}

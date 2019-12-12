﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingLibrary.Interfaces
{
    public interface IMessageBodyGenerator
    {
        void CreateBody(string message);
    }
}
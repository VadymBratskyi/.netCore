using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppStudy.Services
{
    public class MyService : IMyServices
    {
        public string Send()
        {
            return "Hello my service<br/>";
        }
    }
}

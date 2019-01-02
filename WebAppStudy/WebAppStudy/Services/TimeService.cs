using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppStudy.Services
{
    public class TimeService
    {
        public TimeService()
        {
            Time = DateTime.Now.ToString("dd.MM.yyyy hh:MM:ss");
        }

        public string Time { get; }
    }
}

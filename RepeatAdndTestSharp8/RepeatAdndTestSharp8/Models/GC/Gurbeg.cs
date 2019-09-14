using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatAdndTestSharp8.Models.GC
{
    public class Gurbeg : IDisposable
    {
        ~Gurbeg()
        {
            Console.Beep();
        }

        public void Dispose()
        {
            Console.Beep();
            Console.Beep();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatAdndTestSharp8.Models.ExUnplicit
{
    class Counter
    {
        public int Seconds { get; set; }

        public static implicit operator Counter(int number)
        {
            return new Counter() { Seconds = number };
        }

        public static explicit operator int(Counter count)
        {
            return count.Seconds;
        }

        public static explicit operator Counter(Timer timer)
        {
            int h = timer.Hours * 3600;
            int m = timer.Minutes * 60;
            return new Counter { Seconds = h + m + timer.Seconds };
        }

        public static implicit operator Timer(Counter counter)
        {
            int h = counter.Seconds / 3600;
            int m = (counter.Seconds - h * 3600) / 60;
            int s = counter.Seconds - h * 3600 - m * 60;
            return new Timer { Hours = h, Minutes = m, Seconds = s };
        }
    }
}

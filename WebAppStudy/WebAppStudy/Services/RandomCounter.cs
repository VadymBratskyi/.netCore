using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppStudy.Services
{
    public class RandomCounter : ICounter
    {
        static Random Random =  new Random();

        private int _value;

        public RandomCounter()
        {
            _value = Random.Next(0, 1000000);
        }

        public int Value
        {
            get { return _value; }
        }

    }
}

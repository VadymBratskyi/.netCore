using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatern.Models.Ducks.Quack
{
    class NoQuack : IQuackable
    {
        public string Quack()
        {
            return null;
        }
    }
}

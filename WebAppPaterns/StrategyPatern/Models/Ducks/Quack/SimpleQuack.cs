using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatern.Models.Ducks.Quack
{
    public class SimpleQuack : IQuackable
    {
        public string Quack()
        {
            return "Quack! Quack!";
        }
        
    }
}

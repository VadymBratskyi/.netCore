using System;
using System.Collections.Generic;
using System.Text;
using StrategyPatern.Models.Ducks.Fly;
using StrategyPatern.Models.Ducks.Quack;

namespace StrategyPatern.Models.Ducks
{
    public class WoodenDuck : DuckBase
    {
        public WoodenDuck()
        {
            flyable = new NoFly();
            quackable = new NoQuack();
        }

        public override string Display()
        {
            return "Hi! I'm a wooden duck.";
        }
    }
}

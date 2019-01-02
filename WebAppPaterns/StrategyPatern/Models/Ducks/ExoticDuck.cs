using System;
using System.Collections.Generic;
using System.Text;
using StrategyPatern.Models.Ducks.Quack;

namespace StrategyPatern.Models.Ducks
{
    public class ExoticDuck : DuckBase
    {
        public ExoticDuck() {
            quackable = new ExoticQuack();
        }

        public override string Display()
        {
            return "Hi! I'm exotic duck.";
        }
    }
}

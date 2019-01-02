using System;
using System.Collections.Generic;
using System.Text;
using StrategyPatern.Models.Ducks.Fly;

namespace StrategyPatern.Models.Ducks
{
    public class RubberDuck : DuckBase
    {
        public RubberDuck()
        {
            flyable = new NoFly();
        }

        public override string Display()
        {
            return "Hi! I'm a rubber duck.";
        }
    }
}

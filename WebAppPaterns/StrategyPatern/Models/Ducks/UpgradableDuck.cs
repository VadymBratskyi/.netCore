using System;
using System.Collections.Generic;
using System.Text;
using StrategyPatern.Models.Ducks.Fly;
using StrategyPatern.Models.Ducks.Quack;

namespace StrategyPatern.Models.Ducks
{
    public class UpgradableDuck : DuckBase
    {
        public UpgradableDuck()
        {
            quackable = new NoQuack();
            flyable = new NoFly();
        }

        public override string Display()
        {
            return "Hi! I'm an upgradable duck!";
        }
    }
}

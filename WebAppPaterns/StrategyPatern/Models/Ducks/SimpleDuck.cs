using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatern.Models.Ducks
{
    public class SimpleDuck : DuckBase
    {
        public override string Display()
        {
            return "Hi! I'm a simple duck.";
        }
    }
}

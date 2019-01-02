using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatern.Models.Ducks.Fly
{
    class SimpleFly : IFlyable
    {
        public string Fly()
        {
            return "I'm flying with my wings";
        }

    }
}

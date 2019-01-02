using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatern.Models.Ducks.Fly
{
    public class ExoticFly : IFlyable
    {
        public string Fly()
        {
            return "I'm exotin flying with my wings";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatern.Models.Ducks.Fly
{
    public class NoFly : IFlyable
    {
        public string Fly()
        {
            return null;
        }
    }
}

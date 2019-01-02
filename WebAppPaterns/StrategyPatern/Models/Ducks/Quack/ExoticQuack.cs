using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatern.Models.Ducks.Quack
{
    public class ExoticQuack : IQuackable
    {
        public string Quack()
        {
            return "Meaow! Meaow!";
        }
    }
}

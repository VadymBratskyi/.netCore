using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatern.Models.Beverage2
{
    public class GreenTea: BeverageBase
    {
        public GreenTea()
        {
            Description = "Green tea";
        }

        public override double GetCoast()
        {
            return 12.00f;
        }
    }
}

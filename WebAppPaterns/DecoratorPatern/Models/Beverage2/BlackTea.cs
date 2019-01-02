using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatern.Models.Beverage2
{
    public class BlackTea : BeverageBase
    {
        public BlackTea()
        {
            Description = "Black tea";
        }

        public override double GetCoast()
        {
            return 7.00f;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatern.Models.Beverage
{
    public class BlackTea : BeverageBase
    {
        public BlackTea()
        {
            Description = "Black tea";
        }

        public override double GetCoast()
        {
            return 7.00f + base.GetCoast();
        }

        public override bool HasMilk()
        {
            return false;
        }

        public override bool HasSuger()
        {
            return false;
        }

        public override bool HasChocolate()
        {
            return false;
        }
    }
}

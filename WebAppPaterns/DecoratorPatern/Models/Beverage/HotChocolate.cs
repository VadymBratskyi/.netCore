using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatern.Models.Beverage
{
    public class HotChocolate : BeverageBase
    {
        public HotChocolate()
        {
            Description = "Sweet hot chocolate";
        }

        public override double GetCoast()
        {
            return 20.00f + base.GetCoast();
        }

        public override bool HasMilk()
        {
            return true;
        }

        public override bool HasSuger()
        {
            return true;
        }

        public override bool HasChocolate()
        {
            return true;
        }
    }
}

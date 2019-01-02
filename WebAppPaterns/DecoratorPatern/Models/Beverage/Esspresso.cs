using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatern.Models.Beverage
{
    public class Esspresso : BeverageBase
    {
        public Esspresso()
        {
            Description = "Fast coffee";
        }

        public override double GetCoast()
        {
            return 15.00f + base.GetCoast();
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

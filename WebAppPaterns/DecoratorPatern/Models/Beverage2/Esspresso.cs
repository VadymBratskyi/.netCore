using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatern.Models.Beverage2
{
    public class Esspresso : BeverageBase
    {
        public Esspresso()
        {
            Description = "Fast coffee";
        }

        public override double GetCoast()
        {
            return 15.00f;
        }

    }
}

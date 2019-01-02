using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatern.Models.Beverage
{
    public class Capuccino : BeverageBase
    {
        public Capuccino()
        {
            Description = "Coffee with milk";
        }

        public override double GetCoast()
        {
            return 24.00f + base.GetCoast();
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
            return false;
        }
    }
}

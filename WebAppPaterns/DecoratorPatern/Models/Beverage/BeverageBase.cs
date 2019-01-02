using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatern.Models.Beverage
{
    public abstract class BeverageBase
    {
        protected string Description = "";
        protected double MilkPrice = 1.50;
        protected double SugarPrice = 0.10;
        protected double ChocolatePrice = 1.50;

        public string GetDescription()
        {
            return Description;
        }

        public virtual double GetCoast()
        {
            double cost = 0;
            if (HasMilk())
            {
                cost += MilkPrice;
            }

            if (HasSuger())
            {
                cost += SugarPrice;
            }

            if (HasChocolate())
            {
                cost += ChocolatePrice;
            }

            return cost;
        }

        public abstract bool HasMilk();
        public abstract bool HasSuger();
        public abstract bool HasChocolate();
    }
}

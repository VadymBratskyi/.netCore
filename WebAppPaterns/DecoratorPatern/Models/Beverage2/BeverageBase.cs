using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatern.Models.Beverage2
{
    public abstract class BeverageBase
    {
        protected string Description = "";

        public string GetDescription()
        {
            return Description;
        }

        public abstract double GetCoast();

    }
}

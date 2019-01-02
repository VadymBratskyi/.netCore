using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatern.Models.Beverage2.Decorators
{
    public class MilkCondiment: CondimentDecoratorBase
    {
        private BeverageBase _beverage;

        public MilkCondiment(BeverageBase beverage)
        {
            _beverage = beverage;
            Description = _beverage.GetDescription() + " +Milk";
        }

        public override double GetCoast()
        {
            return _beverage.GetCoast() + 1.50f;
        }
    }
}

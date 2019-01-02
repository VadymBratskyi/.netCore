using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatern.Models.Beverage2.Decorators
{
    public class ChocolateCondiment: CondimentDecoratorBase
    {
        private BeverageBase _beverage;

        public ChocolateCondiment(BeverageBase beverage)
        {
            _beverage = beverage;
            Description = _beverage.GetDescription() + " +Chocolate";
        }

        public override double GetCoast()
        {
            return _beverage.GetCoast() + 1.50f;
        }
    }
}

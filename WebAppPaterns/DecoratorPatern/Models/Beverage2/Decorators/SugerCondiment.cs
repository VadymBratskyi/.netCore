using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatern.Models.Beverage2.Decorators
{
    public class SugerCondiment: CondimentDecoratorBase
    {
        private BeverageBase _beverage;

        public SugerCondiment(BeverageBase beverage)
        {
            _beverage = beverage;
            Description = _beverage.GetDescription() + " +Suger";
        }

        public override double GetCoast()
        {
            return _beverage.GetCoast() + 1.50f;
        }
    }
}

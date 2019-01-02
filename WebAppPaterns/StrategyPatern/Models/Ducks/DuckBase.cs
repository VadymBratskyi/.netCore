using System;
using System.Collections.Generic;
using System.Text;
using StrategyPatern.Models.Ducks.Fly;
using StrategyPatern.Models.Ducks.Quack;

namespace StrategyPatern.Models.Ducks
{
    public abstract class DuckBase
    {
        protected IFlyable flyable;
        protected IQuackable quackable;

        public DuckBase()
        {
            quackable= new SimpleQuack();
            flyable = new SimpleFly();
        }

        public void SetQuackable(IQuackable quack)
        {
            quackable = quack;
        }

        public void SetFlyable(IFlyable fly)
        {
            flyable = fly;
        }

        public string Swim()
        {
            return "I'm swiming";
        }

        public string Quack()
        {
            return quackable.Quack();
        }

        public string Fly()
        {
            return flyable.Fly();
        }

        public abstract string Display();
    }
}

using System;

namespace MyCalcLibrery
{
    public class MyCalc : ICalculate
	{
        public int Sum(int x, int y)
        {
            return x + y;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatAdndTestSharp8.Models.Delrgates
{
    class OfferNetDelegates
    {

        public void RunFunction() {
            Func<int, int> retFunction = Factorial;
            int n1 = GetInt(6, retFunction);
            Console.WriteLine(n1);

            int n2 = GetInt(6, x => x * x);
            Console.WriteLine(n2); // 36
        }

        public void RunPredicate() {
            Predicate<int> isPositive = (int x) => x > 0;
            Console.WriteLine(isPositive(20));
            Console.WriteLine(isPositive(-20));
        }

        public void RunAction() {
            Action<int, int> op;
            op = Add;
            Operation(6, 4, op);
            op = Substract;
            Operation(10, 6, op);
        }


        private static void Operation(int x1, int x2, Action<int, int> op)
        {
            if (x1 > x2)
                op(x1, x2);
        }

        private static void Add(int x1, int x2)
        {
            Console.WriteLine("Сумма чисел: " + (x1 + x2));
        }

        private static void Substract(int x1, int x2)
        {
            Console.WriteLine("Разность чисел: " + (x1 - x2));
        }

        private static int GetInt(int x1, Func<int, int> retF)
        {
            int result = 0;
            if (x1 > 0)
                result = retF(x1);
            return result;
        }
        private static int Factorial(int x)
        {
            int result = 1;
            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}

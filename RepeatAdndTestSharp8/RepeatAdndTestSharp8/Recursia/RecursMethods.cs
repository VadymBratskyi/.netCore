﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatAdndTestSharp8.Recursia
{
    static class RecursMethods
    {
        public static int Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }

        public static int Fibonachi(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatAdndTestSharp8.Models.Delrgates
{
    class SomeClass
    {
        public void SomeMethod1(int a, double b) { }
        public int SomeMethod2(int a, double b) => (int)(a + b);
        public void SomeMethod3(double a, int b) { }
        public void SomeMethod4(ref int a, double b) { }
        public void SomeMethod5(out int a, double b) { a = 6; }

        public static void Hello() {
            Console.WriteLine("Hello");
        }

        public static void HowAreYou()
        {
            Console.WriteLine("How are you?");
        }

    }
}

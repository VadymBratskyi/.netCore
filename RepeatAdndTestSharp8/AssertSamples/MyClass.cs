using System;

namespace AssertSamples
{
    public class MyClass
    {

        public static double GeSqrt(double value)
        {
            return Math.Sqrt(value);
        }

        public string SayHello(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("Parameter is null");
            }

            return "Hello" + name;
        }

    }
}

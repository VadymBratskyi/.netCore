using System;

namespace HelloWorldApp
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine(args[0]);

            if (args[0] == "Hello World") {
                return 0;//success
            }

            return 1;//arror
        }
    }
}

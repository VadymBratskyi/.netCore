using _002_ConstructorInjection.DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_ConstructorInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "file2.log";

            FileManager manager = new FileManager();

            if (manager.FindLogFile(fileName))
            {

                Console.WriteLine("File {0} is found", fileName);

            }
            else 
            {

                Console.WriteLine("File {0} isn`t found!", fileName);
            
            }

            Console.ReadKey();

        }
    }
}

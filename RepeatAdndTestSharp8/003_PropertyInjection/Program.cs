using _003_PropertyInjection.DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_PropertyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "file2.log";

            FileManager manager = new FileManager();
            manager.DataAccessObject = new FileDataObject();

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

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_ExtractAndOwerride
{
    class Program
    {

        //class TestStubClass : FileManager {

        //    public override List<string> GetFiles()
        //    {
        //        return new List<string> { "file2.log" };
        //    }
        //}

        static void Main(string[] args)
        {
            string fileName = "file2.log";

            FileManager manager = new FileManager();

            if (manager.FindlogFile(fileName))
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

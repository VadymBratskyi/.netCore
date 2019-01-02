using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatern.Models.Car1
{
    public class Car
    {
        protected string Name = "";
        protected string Body = "Caravan";

        protected string Engine = "Diesel";
        protected string PaintColor = "White";
        protected string Wheels = "16 inch";
        

        public string Configure()
        {
            return $"Configuring: {Name}; " +
                   $"Engine is: {Engine}; " +
                   $"Body is: {Body}; " +
                   $"PaintColor is: {PaintColor}; " +
                   $"Wheels are {Wheels};";
        }

        public string AssembleBody()
        {
            return "Body is assembled";
        }
        public string InstallEngine()
        {
            return "Engine is in its plce";
        }
        public string Paint()
        {
            return "Car is painted";
        }
        public string InstallWheels()
        {
            return "Wheels are installed";
        }
    }
}

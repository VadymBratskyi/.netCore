using System;
using System.Collections.Generic;
using System.Text;
using FactoryPatern.Models.Car2.Parts;

namespace FactoryPatern.Models.Car2
{
    public abstract class Car2
    {
        protected string Name = "";
        protected string Body = "Caravan";

        protected Engine Engine;
        protected Paint PaintColor;
        protected Wheels Wheels;


        public abstract string Configure();

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

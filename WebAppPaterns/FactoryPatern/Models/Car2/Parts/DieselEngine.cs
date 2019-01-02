using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatern.Models.Car2.Parts
{
    public class DieselEngine : Engine
    {
        public override string GetEngineType()
        {
            return "Engine is Diesel";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatern.Models.Car2.Parts
{
    public class MediumWheels : Wheels
    {
        public override string GetTypeWheels()
        {
            return "Wheels are Medium 16d";
        }
    }
}

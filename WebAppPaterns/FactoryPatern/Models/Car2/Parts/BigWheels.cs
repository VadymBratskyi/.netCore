using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatern.Models.Car2.Parts
{
    public class BigWheels : Wheels
    {
        public override string GetTypeWheels()
        {
            return "Wheels are Big 17d";
        }
    }
}

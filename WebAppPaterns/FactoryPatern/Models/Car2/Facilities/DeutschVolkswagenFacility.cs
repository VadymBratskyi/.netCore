using System;
using System.Collections.Generic;
using System.Text;
using FactoryPatern.Models.Car2.PartsFactory;

namespace FactoryPatern.Models.Car2.Facilities
{
    public class DeutschVolkswagenFacility : VolkswagenFacility
    {
        public override Car2 CreateCar(string type)
        {
            DeutschPartsFactory factory = new DeutschPartsFactory();

            if (type == "Golf")
            {
                return new Golf(factory);
            }
            else if (type == "Passat")
            {
                return new Passat(factory);
            }
            else if (type == "Tiguan")
            {
                return new Tiguan(factory);
            }
            else if (type == "Toureg")
            {
                return new Toureg(factory);
            }

            return null;
        }
    }
}

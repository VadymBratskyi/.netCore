using System;
using System.Collections.Generic;
using System.Text;
using FactoryPatern.Models.Car1.Factory;

namespace FactoryPatern.Models.Car2.Facilities
{
    public abstract class VolkswagenFacility
    {

        public Car2 GetCar(string type)
        {
            Car2 car = CreateCar(type);

            return car;
        }

        public abstract Car2 CreateCar(string type);
    }
}

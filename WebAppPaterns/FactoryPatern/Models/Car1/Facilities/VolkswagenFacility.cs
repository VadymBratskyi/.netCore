using System;
using System.Collections.Generic;
using System.Text;
using FactoryPatern.Models.Car1.Factory;

namespace FactoryPatern.Models.Car1.Facilities
{
    public abstract class VolkswagenFacility
    {
        //private SimpeFactory _factory;

        //public VolkswagenFacility(SimpeFactory simpeFactory)
        //{
        //    _factory = simpeFactory;
        //}

        //public Car GetCar(string type)
        //{
        //    Car car = _factory.GetCar(type);

        //    return car;
        //}

        public Car GetCar(string type)
        {
            Car car = CreateCar(type);

            return car;
        }

        public abstract Car CreateCar(string type);
    }
}

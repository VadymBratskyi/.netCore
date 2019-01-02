using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatern.Models.Car1.Facilities
{
    public class UkrainVolkswagenFacility : VolkswagenFacility
    {
        public override Car CreateCar(string type)
        {
            Car car;

            if (type == "Golf")
            {
                car = new UkrainGolf();
            }
            else if (type == "Passat")
            {
                car = new UkrainPassat();
            }
            else if (type == "Tiguan")
            {
                car = new UkrainTiguan();
            }
            else if (type == "Toureg")
            {
                car = new UkrainToureg();
            }
            else
            {
                car = new Car();
            }

            return car;
        }
    }
}

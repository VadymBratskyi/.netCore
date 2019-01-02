using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatern.Models.Car1.Factory
{
    public class SimpeFactory
    {
        public Car GetCar(string type)
        {
            Car car;

            if (type == "Golf")
            {
                car = new DeutschGolf();
            }
            else if (type == "Passat")
            {
                car = new DeutschPassat();
            }
            else if (type == "Tiguan")
            {
                car = new DeutschTiguan();
            }
            else if (type == "Toureg")
            {
                car = new DeutschToureg();
            }
            else
            {
                car = new Car();
            }

            return car;
        }
    }
}

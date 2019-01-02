using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatern.Models.Car1
{
    public class DeutschPassat : Car
    {
        public DeutschPassat()
        {
            Name = "Passat";
            Body = "Sedan";
        }
    }
}

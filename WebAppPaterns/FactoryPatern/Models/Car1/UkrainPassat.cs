using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatern.Models.Car1
{
    public class UkrainPassat : Car
    {
        public UkrainPassat()
        {
            Name = "Passat";
            Body = "Sedan";
            Engine = "Gasolin";
        }
    }
}

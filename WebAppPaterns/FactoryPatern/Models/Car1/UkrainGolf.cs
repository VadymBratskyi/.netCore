using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatern.Models.Car1
{
    public class UkrainGolf : Car
    {
        public UkrainGolf()
        {
            Name = "Golf";
            Body = "Hatchback";
            Engine = "Gasolin";
        }
    }
}

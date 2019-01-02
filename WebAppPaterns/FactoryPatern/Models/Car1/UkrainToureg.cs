using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatern.Models.Car1
{
    public class UkrainToureg : Car
    {
        public UkrainToureg()
        {
            Name = "Toureg";
            Body = "Big Crossower";
            Engine = "Gasolin";
        }
    }
}

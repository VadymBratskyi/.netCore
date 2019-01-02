using System;
using System.Collections.Generic;
using System.Text;
using FactoryPatern.Models.Car2.Parts;

namespace FactoryPatern.Models.Car2.PartsFactory
{
    public abstract class CarPartsFactory
    {
        public abstract Engine CreateEngine();

        public abstract Paint CreatePaint();

        public abstract Wheels CreateWheels();
    }
}

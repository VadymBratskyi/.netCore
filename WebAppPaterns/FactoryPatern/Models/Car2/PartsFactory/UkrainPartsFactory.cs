using System;
using System.Collections.Generic;
using System.Text;
using FactoryPatern.Models.Car2.Parts;

namespace FactoryPatern.Models.Car2.PartsFactory
{
    class UkrainPartsFactory : CarPartsFactory
    {
        public override Engine CreateEngine()
        {
            return  new GasolinEngine();
        }

        public override Paint CreatePaint()
        {
            return  new BlackPaint();
        }

        public override Wheels CreateWheels()
        {
            return new MediumWheels();
        }
    }
}

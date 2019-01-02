using System;
using System.Collections.Generic;
using System.Text;
using FactoryPatern.Models.Car2.Parts;

namespace FactoryPatern.Models.Car2.PartsFactory
{
    class DeutschPartsFactory : CarPartsFactory
    {
        public override Engine CreateEngine()
        {
            return  new DieselEngine();
        }

        public override Paint CreatePaint()
        {
            return  new WhitePaint();
        }

        public override Wheels CreateWheels()
        {
            return new BigWheels();
        }
    }
}

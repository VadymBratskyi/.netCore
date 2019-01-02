using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatern.Models.Car2.Parts
{
    public class BlackPaint : Paint
    {
        public override string GetColor()
        {
            return "Paint is Black";
        }
    }
}

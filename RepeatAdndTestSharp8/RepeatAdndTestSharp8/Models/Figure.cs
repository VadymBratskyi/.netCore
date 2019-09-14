using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatAdndTestSharp8.Models
{
    abstract class Figure
    {
        public int x { get; set; }
        public int y { get; set; }

        public abstract float Perimeter();
        public abstract float Area();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatern.Models.ControlledSystem
{
    public class Tv : ISystem
    {
        public State State { get; set; }

        public string TurnOn()
        {
            State = State.On;
            return "Tv turned On";
        }

        public string TurnOff()
        {
            State = State.Off;
            return "Tv turned Off";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatern.Models.ControlledSystem
{
    public class Teapot : ISystem
    {
        public State State { get; set; }

        public string TurnOn()
        {
            State = State.On;
            return "Teapot turned On";
        }

        public string TurnOff()
        {
            State = State.Off;
            return "Teapot turned Off";
        }
    }
}

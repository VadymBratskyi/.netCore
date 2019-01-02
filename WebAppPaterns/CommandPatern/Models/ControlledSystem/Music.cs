using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatern.Models.ControlledSystem
{
    public class Music : ISystem
    {
        public State State { get; set; }

        public string TurnOn()
        {
            State = State.On;
            return "Music turned On";
        }

        public string TurnOff()
        {
            State = State.Off;
            return "Music turned Off";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatern.Models.ControlledSystem
{
    interface ISystem
    {
        State State { get; set; }
        string TurnOn();
        string TurnOff();
    }
}

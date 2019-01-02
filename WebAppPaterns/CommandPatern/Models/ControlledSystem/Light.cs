using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatern.Models.ControlledSystem
{
    public class Light : ISystem
    {
        public State State { get; set; }

        public LightState LightState { get; set; }


        public string ToggleLight()
        {
            switch (LightState)
            {
                case LightState.Low:
                    LightState = LightState.Medium;
                    return "light is Medium";
                case LightState.Medium:
                    LightState = LightState.Hight;
                    return "light is Hight";
                case LightState.Hight:
                    LightState = LightState.Low;
                    return "light is Low"; 
            }
            return "light is Low";
        }

        public string TurnOn()
        {
            State = State.On;
            LightState = LightState.Low;
            return "Light turned On and lightstate "+ LightState.Low;
        }

        public string TurnOff()
        {
            State = State.Off;
            return "Light turned Off";
        }
    }
}

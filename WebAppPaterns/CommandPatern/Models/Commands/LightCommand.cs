using System;
using System.Collections.Generic;
using System.Text;
using CommandPatern.Models.ControlledSystem;

namespace CommandPatern.Models.Commands
{
    public class LightCommand: ICommand
    {
        private Light _light;

        public LightCommand(Light light)
        {
            _light = light;
        }

        public string ToggleLight()
        {
            return _light.ToggleLight();
        }

        public string Execute()
        {
            return _light.TurnOn();
        }

        public string Undo()
        {
            return _light.TurnOff();
        }

        public override string ToString()
        {
            return "Turn on the Light";
        }
    }
}

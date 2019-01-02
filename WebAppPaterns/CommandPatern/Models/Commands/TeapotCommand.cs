using System;
using System.Collections.Generic;
using System.Text;
using CommandPatern.Models.ControlledSystem;

namespace CommandPatern.Models.Commands
{
    public class TeapotCommand : ICommand
    {
        private Teapot _teapot;

        public TeapotCommand(Teapot teapot)
        {
            _teapot = teapot;
        }

        public string Execute()
        {
            return _teapot.TurnOn();
        }

        public string Undo()
        {
            return _teapot.TurnOff();
        }

        public override string ToString()
        {
            return "Turn on the Teapot";
        }
    }
}

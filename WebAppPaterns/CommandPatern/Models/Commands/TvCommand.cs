using System;
using System.Collections.Generic;
using System.Text;
using CommandPatern.Models.ControlledSystem;

namespace CommandPatern.Models.Commands
{
    public class TvCommand: ICommand
    {
        private Tv _tv;

        public TvCommand(Tv tv)
        {
            _tv = tv;
        }

        public string Execute()
        {
            return _tv.TurnOn();
        }

        public string Undo()
        {
            return _tv.TurnOff();
        }

        public override string ToString()
        {
            return "Turn on the Tv";
        }
    }
}

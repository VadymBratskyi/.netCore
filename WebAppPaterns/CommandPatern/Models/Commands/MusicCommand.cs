using System;
using System.Collections.Generic;
using System.Text;
using CommandPatern.Models.ControlledSystem;

namespace CommandPatern.Models.Commands
{
    public class MusicCommand : ICommand
    {
        private Music _music;

        public MusicCommand(Music music)
        {
            _music = music;
        }

        public string Execute()
        {
            return _music.TurnOn();
        }

        public string Undo()
        {
            return _music.TurnOff();
        }

        public override string ToString()
        {
            return "Turn on the Music";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using CommandPatern.Models.Commands;

namespace CommandPatern.Models
{
    public class RemoteControl
    {
        private int prsedButton;
        private Dictionary<int, ICommand> _commands;

        public RemoteControl()
        {
            _commands = new Dictionary<int, ICommand>();
        }

        public string ToggleLight()
        {
            if (prsedButton == 1)
            {
                return (_commands[1] as LightCommand).ToggleLight();
            }
            else
            {
                return "Light is turn off";
            }
        }

        public string PerformAction(int input)
        {
            prsedButton = input;

            if (_commands.ContainsKey(input))
            {
                return _commands[input].Execute();
            }
            return "Commad is not found";
        }

        public string UndoAction(int input)
        {
            if (_commands.ContainsKey(input))
            {
                return _commands[input].Undo();
            }
            return "Commad is not found";
        }

        public void SetComand(int buton, ICommand cmd)
        {
            _commands[buton] = cmd;
        }

        public override string ToString()
        {
            var stb = new StringBuilder();

            foreach (var commandsKey in _commands.Keys)
            {
                stb.AppendFormat("<strong>{0}</strong> - {1}<br/>", commandsKey, _commands[commandsKey]);
            }
            stb.Append("<strong>ex.</strong> - Exit");

            return stb.ToString();
        }
    }
}

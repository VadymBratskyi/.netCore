using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatern.Models.Commands
{
    public interface ICommand
    {
        string Execute();

        string Undo();

    }
}

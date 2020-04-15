using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Commands
{
    public class MoveCommand : OsbCommand<CommandPosition>
    {
        public MoveCommand()
        {
            Identifier = "M";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Commands
{
    public interface IOsbCompoundCommand : IOsbCommand
    {
        public IEnumerable<IOsbSpriteCommand> OsbCommands { get; set; }
    }
}

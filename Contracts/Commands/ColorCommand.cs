using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Commands
{
    public class ColorCommand : OsbCommand<CommandColor>
    {
        private CommandColor _defaultValue = new CommandColor(255, 255, 255);
        public override CommandColor DefaultValue => _defaultValue;
    }
}

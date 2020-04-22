using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Commands
{
    public class VectorScaleCommand : OsbCommand<CommandScale>
    {
        public override CommandScale DefaultValue => new CommandScale(1, 1);
    }
}

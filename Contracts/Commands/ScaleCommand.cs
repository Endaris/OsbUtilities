using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Commands
{
    public class ScaleCommand : OsbCommand<double>
    {
        public override double DefaultValue => 1;
    }
}

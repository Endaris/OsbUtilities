using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Commands
{
    public class RotateCommand : OsbCommand<double>
    {
        public override double DefaultValue => 0;
    }
}

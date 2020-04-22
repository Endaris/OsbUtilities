using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Commands
{
    public class FadeCommand : OsbCommand<double>
    {
        private double _defaultValue = 0;
        public override double DefaultValue => _defaultValue;
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Contracts.Enums;

namespace Contracts.Commands
{
    public class ParameterCommand : OsbCommand<ParameterType>
    {
        public override ParameterType DefaultValue => ParameterType.None;
    }
}

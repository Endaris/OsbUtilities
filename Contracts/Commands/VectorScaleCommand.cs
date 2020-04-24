using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Commands
{
    public class VectorScaleCommand : OsbCommand<CommandScale>
    {
        public override CommandScale DefaultValue => new CommandScale(1, 1);
        public override string TestString =>
             $@"new VectorScaleCommand()
{{
    Identifier = ""{Identifier}"",
    Easing = OsbEasing.{Easing},
    StartTime = {StartTime},
    EndTime = {EndTime},
    StartValue = new CommandScale({StartValue}),
    EndValue = new CommandScale({EndValue}),
    Line = {Line},
}};";
    }
}

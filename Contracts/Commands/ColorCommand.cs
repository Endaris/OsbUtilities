using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Commands
{
    public class ColorCommand : OsbCommand<CommandColor>
    {
        private CommandColor _defaultValue = new CommandColor(255, 255, 255);
        public override CommandColor DefaultValue => _defaultValue;      
        public override string TestString =>
             $@"new ColorCommand()
{{
    Identifier = ""{Identifier}"",
    Easing = OsbEasing.{Easing},
    StartTime = {StartTime},
    EndTime = {EndTime},
    StartValue = new CommandColor({StartValue}),
    EndValue = new CommandColor({EndValue}),
    Line = {Line},
}};";
    }
}

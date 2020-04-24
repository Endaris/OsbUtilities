using System;
using System.Collections.Generic;
using System.Text;
using Contracts.Enums;

namespace Contracts.Commands
{
    public class ParameterCommand : OsbCommand<ParameterType>
    {
        public override ParameterType DefaultValue => ParameterType.None;
        public override string TestString =>
             $@"new ParameterCommand()
{{
    Identifier = ""{Identifier}"",
    Easing = OsbEasing.{Easing},
    StartTime = {StartTime},
    EndTime = {EndTime},
    StartValue = ParameterType.{StartValue},
    EndValue = ParameterType.{EndValue},
    Line = {Line},
}};";
    }
}

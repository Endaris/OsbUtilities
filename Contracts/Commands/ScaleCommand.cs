using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Commands
{
    public class ScaleCommand : OsbCommand<double>
    {
        public override double DefaultValue => 1;
        public override string TestString =>
             $@"new ScaleCommand()
{{
    Easing = OsbEasing.{Easing},
    StartTime = {StartTime},
    EndTime = {EndTime},
    StartValue = {StartValue.ToString(System.Globalization.CultureInfo.InvariantCulture)},
    EndValue = {EndValue.ToString(System.Globalization.CultureInfo.InvariantCulture)},
    Line = {Line},
}};";
        public override string Identifier => "S";
    }
}

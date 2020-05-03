using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Commands
{
    public class FadeCommand : OsbCommand<double>
    {
        private double _defaultValue = 0;
        public override double DefaultValue => _defaultValue;
        public override string TestString =>
             $@"new FadeCommand()
{{
    Easing = OsbEasing.{Easing},
    StartTime = {StartTime},
    EndTime = {EndTime},
    StartValue = {StartValue.ToString(System.Globalization.CultureInfo.InvariantCulture)},
    EndValue = {EndValue.ToString(System.Globalization.CultureInfo.InvariantCulture)},
    Line = {Line},
}};";
        public override string Identifier => "F";
    }
}

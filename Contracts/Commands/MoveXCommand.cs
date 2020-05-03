using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Commands
{
    public class MoveXCommand :  OsbCommand<double>
    {
        private double _defaultValue = -79200;

        public override double DefaultValue
        {
            get
            {//this is bad but it still seems more practical than having to supply it through the constructor...
                if (_defaultValue == -79200)
                    throw new Exception(@$"Error trying to access the default value of {Identifier} command at line {Line}
                                           The defaultvalue must be set from the sprite before accessing it on the {Identifier} command");
                else
                    return _defaultValue;
            }
        }
        public void SetDefaultValue(CommandPosition position)
        {
            if (position.X == -79200)
                throw new Exception($"Your sprite initialisation for the sprite with the command at line {this.Line} sucks. Stop bullying my messy code.");
            else
                _defaultValue = position.X;
        }

        public override string TestString =>
             $@"new MoveXCommand()
{{
    Easing = OsbEasing.{Easing},
    StartTime = {StartTime},
    EndTime = {EndTime},
    StartValue = {StartValue.ToString(System.Globalization.CultureInfo.InvariantCulture)},
    EndValue = {EndValue.ToString(System.Globalization.CultureInfo.InvariantCulture)},
    Line = {Line},
}};";

        public override string Identifier => "MX";
    }
}

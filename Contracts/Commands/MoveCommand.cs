using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Commands
{
    public class MoveCommand : OsbCommand<CommandPosition>
    {
        private CommandPosition _defaultValue;

        public override CommandPosition DefaultValue 
        { 
            get
            {//this is bad but it still seems more practical than having to supply it through the constructor...
                if (_defaultValue == null)
                    throw new Exception(@$"Error trying to access the default value of {Identifier} command at line {Line}
                                           The defaultvalue must be set from the sprite before accessing it on the {Identifier} command");
                else
                    return _defaultValue;
            } 
        }
        public void SetDefaultValue(CommandPosition position)
        {
            _defaultValue = position;
        }

        public override string TestString =>
             $@"new MoveCommand()
{{
    Easing = OsbEasing.{Easing},
    StartTime = {StartTime},
    EndTime = {EndTime},
    StartValue = new CommandPosition({StartValue}),
    EndValue = new CommandPosition({EndValue}),
    Line = {Line},
}};";

        public override string Identifier => "M";
    }
}

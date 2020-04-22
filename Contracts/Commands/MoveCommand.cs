using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Commands
{
    public class MoveCommand : OsbCommand<CommandPosition>
    {
        public MoveCommand()
        {
            Identifier = "M";
        }

        private CommandPosition _defaultValue;

        public override CommandPosition DefaultValue 
        { 
            get
            {//this sucks but it still seems more practical than having to supply it through the constructor...
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
    }
}

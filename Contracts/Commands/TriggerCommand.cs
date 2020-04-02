using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Commands
{
    public class TriggerCommand : IOsbCompoundCommand
    {
        public IEnumerable<IOsbSpriteCommand> OsbCommands { get; set; }
        public double StartTime { get; set; }
        public double EndTime { get; set; }
        public string Identifier { get; set; }
        public int Line { get; set; }
        public int TriggerGroup { get; set; }
        public string TriggerName { get; set; }
    }
}

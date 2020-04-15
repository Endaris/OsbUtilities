using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contracts.Commands
{
    public class LoopCommand : IOsbCompoundCommand
    {
        public IEnumerable<IOsbSpriteCommand> OsbCommands { get; set; }
        public double StartTime { get; set; }
        public double EndTime => StartTime + LoopCount * OsbCommands.Max(c => c.EndTime);
        public string Identifier { get; set; }
        public int Line { get; set; }
        public int LoopCount { get; set; }
        public double LoopDuration { get
            {
                return OsbCommands.Select(c => c.EndTime).OrderBy(t => t).Last();
            } 
        }
    }
}

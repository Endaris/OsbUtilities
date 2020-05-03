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
        public double ActualStartTime => StartTime + OsbCommands.Min(c => c.StartTime);
        public double EndTime => ActualStartTime + LoopCount * LoopDuration;
        public double Duration => EndTime - ActualStartTime;
        public string Identifier => "L";
        public int Line { get; set; }
        public int LoopCount { get; set; }
        public double LoopDuration { get
            {
                return OsbCommands.Max(c => c.EndTime) - OsbCommands.Min(c => c.StartTime);
            } 
        }

        public string TestString => $@"new {this.GetType().Name}()
{{
    Identifier = ""{Identifier}"",
    StartTime = {StartTime},
    Line = {Line},
    LoopCount = {LoopCount},
    OsbCommands = new List<IOsbSpriteCommand>()
    {{
        {String.Join(Environment.NewLine + "    ", this.OsbCommands.Select(c => c.TestString.Replace(';', ',')))}
    }},
}};";
    }
}

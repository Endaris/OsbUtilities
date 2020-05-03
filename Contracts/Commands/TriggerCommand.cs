using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contracts.Commands
{
    public class TriggerCommand : IOsbCompoundCommand
    {
        public IEnumerable<IOsbSpriteCommand> OsbCommands { get; set; }
        public double StartTime { get; set; }
        public double EndTime { get; set; }
        public double Duration => EndTime - StartTime;
        public string Identifier => "T";
        public int Line { get; set; }
        public int TriggerGroup { get; set; }
        public string TriggerName { get; set; }
        public string TestString => $@"new {this.GetType().Name}()
{{
    Identifier = ""{Identifier}"",
    StartTime = {StartTime},
    EndTime = {EndTime},
    Line = {Line},
    TriggerName = ""{TriggerName}"",
    TriggerGroup = {TriggerGroup},
    OsbCommands = new List<IOsbSpriteCommand>()
    {{
        {String.Join(Environment.NewLine + "    ", this.OsbCommands.Select(c => c.TestString.Replace(';', ',')))}
    }},
}};";
    }
}

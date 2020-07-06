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
        //loops without commands actually parse
        public double ActualStartTime => StartTime + (OsbCommands.Count() > 0 ? OsbCommands.Min(c => c.StartTime) : 0);
        public double EndTime => ActualStartTime + LoopCount * LoopDuration;
        public double Duration => EndTime - ActualStartTime;
        public string Identifier => "L";
        public int Line { get; set; }
        public int LoopCount { get; set; }
        public double LoopDuration { get
            {   //loops without commands actually parse
                if (OsbCommands.Count() > 0)
                    return OsbCommands.Max(c => c.EndTime) - OsbCommands.Min(c => c.StartTime);
                else
                    return 0;
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

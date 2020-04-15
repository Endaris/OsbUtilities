using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Contracts.Commands;
using Contracts.Enums;

namespace Contracts
{
    public class VisualElement
    {
        public OsbLayer Layer { get; set; }
        public OsbOrigin Anchor { get; set; }
        public int LineNumber { get; set; }
        public string LineInitialisation { get; set; }
        public string RelativePath { get; set; }
        public IEnumerable<IOsbCommand> Commands { get; set; }
        public int zIndex { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public double StartTime { get { return Commands.Select(c => c.StartTime).OrderBy(t => t).First(); } }
        public double EndTime { 
            get { 
                return Commands.Select(c => 
                    { 
                        if (c is TriggerCommand)
                        {
                            var t = (TriggerCommand)c;
                            return t.EndTime + t.OsbCommands.Select(c => c.EndTime).OrderBy(t => t).Last();
                        }
                        return c.EndTime; 
                    }).OrderBy(t => t).Last(); 
            } 
        }
    }
}

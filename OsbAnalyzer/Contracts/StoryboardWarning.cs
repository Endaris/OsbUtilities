using System;
using System.Collections.Generic;
using System.Text;
using OsbAnalyser.Warnings;

namespace OsbAnalyser.Contracts
{
    public abstract class StoryboardWarning
    {
        public virtual int OffendingLine { get; set; }
        public abstract override string ToString();
        public Warnings.WarningLevel WarningLevel { get; set; }
    }
}

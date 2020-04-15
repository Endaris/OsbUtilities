using System;
using System.Collections.Generic;
using System.Text;

namespace OsbAnalyzer.Contracts
{
    public abstract class StoryboardWarning
    {
        public virtual int OffendingLine { get; set; }
        public abstract override string ToString();
    }
}

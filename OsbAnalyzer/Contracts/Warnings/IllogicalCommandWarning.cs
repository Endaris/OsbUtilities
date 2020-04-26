using System;
using System.Collections.Generic;
using System.Text;
using OsbAnalyzer.Contracts;

namespace OsbAnalyzer.Warnings
{
    public class IllogicalCommandWarning : StoryboardWarning
    {
        public override string ToString()
        {
            return $"Command at line {OffendingLine} has its end time before its start time.";
        }
    }
}

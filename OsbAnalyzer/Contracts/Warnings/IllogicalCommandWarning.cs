using System;
using System.Collections.Generic;
using System.Text;
using OsbAnalyser.Contracts;

namespace OsbAnalyser.Warnings
{
    public class IllogicalCommandWarning : StoryboardWarning
    {
        public override string ToString()
        {
            return $"Command at line {OffendingLine} has its end time before its start time.";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using OsbAnalyser.Contracts;

namespace OsbAnalyser.Warnings
{
    public class ProlongedActivityWarning : StoryboardWarning
    {
        public double timeProlonged { get; set; } 
        public double percentageProlonged { get; set; }

        public override string ToString()
        {
            return $"Active time of sprite at line {OffendingLine} is prolonged for {timeProlonged}ms ({percentageProlonged}% of its active time) unnecessarily.";
        }
    }
}

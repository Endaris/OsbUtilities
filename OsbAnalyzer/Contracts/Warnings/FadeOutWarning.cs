using System;
using System.Collections.Generic;
using System.Text;

namespace OsbAnalyser.Contracts.Warnings
{
    public class FadeOutWarning : StoryboardWarning
    {
        public double timeInvisible { get; set; }
        public double percentageInvisible { get; set; }

        public override string ToString()
        {
            return $"Sprite at line {OffendingLine} is invisible for {timeInvisible}ms ({percentageInvisible * 100}%) of its active time.";
        }
    }
}

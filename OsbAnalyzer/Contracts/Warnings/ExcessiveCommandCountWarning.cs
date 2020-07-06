using System;
using System.Collections.Generic;
using System.Text;
using OsbAnalyser.Contracts;

namespace OsbAnalyzer.Contracts.Warnings
{
    public class ExcessiveCommandCountWarning : StoryboardWarning
    {
        public int CommandCount { get; set; }
        public double ActiveDuration { get; set; }
        public override string ToString()
        {
            return $"Sprite at line {OffendingLine} has {CommandCount} commands over a duration of {ActiveDuration}ms. Consider splitting the sprite into multiple sprites with shorter durations and less commands in order to improve performance.";
        }
    }
}

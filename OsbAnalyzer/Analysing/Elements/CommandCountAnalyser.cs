using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;
using OsbAnalyser.Contracts;
using OsbAnalyser.Contracts.Warnings;
using OsbAnalyzer.Contracts.Warnings;

namespace OsbAnalyzer.Analysing.Elements
{
    public class CommandCountAnalyser : IAnalyser
    {
        public List<StoryboardWarning> Analyse(VisualElement visualElement)
        {
            var warnings = new List<StoryboardWarning>();
            var warningLevel = GetWarningLevel(visualElement.Commands.Count(), visualElement.Duration);

            //this is more of a guesswork metric for optimisation rather than something wrong, so we should cut at a bottom line of relevance
            if (warningLevel >= WarningLevel.Medium)
            {
                var warning = new ExcessiveCommandCountWarning()
                {
                    ActiveDuration = visualElement.Duration,
                    CommandCount = visualElement.Commands.Count(),
                    OffendingLine = visualElement.Line,
                    WarningLevel = warningLevel
                };
                warnings.Add(warning);
            }
            return warnings;
        }

        private WarningLevel GetWarningLevel(int commandCount, double duration)
        {
            double averageCommandDensity = commandCount / duration;

            int warningLevelCount = (int)Math.Floor(commandCount / 100.0);
            //to raise the warning level for sprites with many commands that are spread over a long time
            //-1 assumes that 10 commands per second are a good bottom line of density standard for sprites that have many commands in the first place
            int warningLevelDensity = (int)Math.Round((((1 / averageCommandDensity) / 100.0) - 1) * Math.Min(1, commandCount / 100));

            //very high density + high command count is still bad, so high density shouldn't actually reduce the warning level
            if (warningLevelDensity < 0)
                warningLevelDensity = 0;

            int warningResult = warningLevelCount + warningLevelDensity;
            if (warningResult >= 5)
                return WarningLevel.Critical;
            else
                return (WarningLevel)warningResult;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;
using OsbAnalyser.Analysing.Helper;
using OsbAnalyser.Contracts;
using OsbAnalyser.Warnings;

namespace OsbAnalyser.Analysing.Elements
{
    public class IllogicalAnalyser : IAnalyser
    {
        public List<StoryboardWarning> Analyse(VisualElement visualElement)
        {
            return FindIllogicalCommands(visualElement);
        }

        private List<StoryboardWarning> FindIllogicalCommands(VisualElement visualElement)
        {
            List<StoryboardWarning> illogicalCommandWarnings = new List<StoryboardWarning>();

            var commands = AnalysingHelper.ResolveLoops(visualElement.Commands);
            commands = AnalysingHelper.ResolveTriggers(commands);

            foreach(var cmd in commands)
            {
                if (cmd.EndTime < cmd.StartTime)
                {
                    illogicalCommandWarnings.Add(new IllogicalCommandWarning()
                    {
                        OffendingLine = cmd.Line,
                        WarningLevel = Contracts.Warnings.WarningLevel.Critical,
                    });
                }
            }

            return illogicalCommandWarnings;
        }
    }
}

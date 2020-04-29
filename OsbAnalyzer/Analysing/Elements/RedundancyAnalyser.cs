using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;
using OsbAnalyser.Contracts;
using OsbAnalyser.Warnings;

namespace OsbAnalyser.Analysing.Elements
{
    public class RedundancyAnalyser : IAnalyser
    {
        public List<StoryboardWarning> Analyse(VisualElement visualElement)
        {
            return FindRedundancies(visualElement);
        }

        private List<StoryboardWarning> FindRedundancies(VisualElement visualElement)
        {
            List<StoryboardWarning> illogicalCommandWarnings = new List<StoryboardWarning>();

            foreach(var cmdGroup in visualElement.Commands.Where(c => c is IOsbSpriteCommand)
                                                          .Select(c => (IOsbSpriteCommand)c)
                                                          .GroupBy(c => c.Identifier)
                                                          .Where(g => g.Count() > 1))
            {
                illogicalCommandWarnings.AddRange(FindRedundancies(cmdGroup));
            }

            foreach(var cmdGroup in visualElement.Commands.Where(c => c is IOsbCompoundCommand)
                                                          .Select(c => (IOsbCompoundCommand)c)
                                                          .SelectMany(c => c.OsbCommands)
                                                          .GroupBy(c => c.Identifier)
                                                          .Where(g => g.Count() > 1))
            {
                illogicalCommandWarnings.AddRange(FindRedundancies(cmdGroup));
            }

            return illogicalCommandWarnings;
        }

        private List<RedundantTransformationWarning> FindRedundancies(IGrouping<string, IOsbSpriteCommand> cmdGroup)
        {
            var list = new List<RedundantTransformationWarning>();
            var orderedCommands = cmdGroup.OrderBy(c => c.StartTime);

            for(int i = 0; i < orderedCommands.Count() - 1; i++)
            {
                var cmd1 = orderedCommands.ElementAt(i);
                var cmd2 = orderedCommands.ElementAt(i + 1);

                if (cmd2.StartValue.Equals(cmd2.EndValue) && cmd2.StartValue.Equals(cmd1.EndValue))
                {
                    list.Add(new RedundantTransformationWarning()
                    {
                        OffendingLine = cmd2.Line,
                        RelatedLine = cmd1.Line,
                        Identifier = cmdGroup.Key,
                        WarningLevel = Contracts.Warnings.WarningLevel.MaybeRankable
                    });
                }
            }

            return list;
        }
    }
}

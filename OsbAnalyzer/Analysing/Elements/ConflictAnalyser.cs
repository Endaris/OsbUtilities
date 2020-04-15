using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;
using OsbAnalyzer.Contracts.Warnings;
using OsbAnalyzer.Analysing.Helper;

namespace OsbAnalyzer.Analysing.Elements
{
    public class ConflictAnalyser
    {
        public List<ConflictingCommandsWarning> FindConflicts(VisualElement visualElement)
        {
            List<ConflictingCommandsWarning> conflictingCommandsWarnings = new List<ConflictingCommandsWarning>();
            var commands = AnalysingHelper.ResolveLoops(visualElement.Commands);
            commands = AnalysingHelper.ResolveTriggers(commands);

            var commandGroups = commands.GroupBy(c => c.Identifier);
            var spriteCommandGroups = commands.Where(c => c is IOsbSpriteCommand).GroupBy(c => c.Identifier);

            foreach(var group in spriteCommandGroups)
            {
                for(int i = 0; i < group.Count(); i++)
                {
                    for (int j = i + 1; j < group.Count(); j++)
                    {
                        conflictingCommandsWarnings.AddRange(FindConflictingTimes(group.ElementAt(i), group.ElementAt(j)));
                    }
                }
            }

            conflictingCommandsWarnings.AddRange(FindConflictingCommandTypes(visualElement));

            return conflictingCommandsWarnings;
        }

        public List<ConflictingCommandsWarning> FindConflictingTimes(IOsbCommand cmd1, IOsbCommand cmd2)
        {
            List<ConflictingCommandsWarning> list = new List<ConflictingCommandsWarning>();

            if (cmd1.Identifier != cmd2.Identifier)
                return list; //you need to put in actually comparable commands, dummy

            if (cmd1.StartTime == cmd2.StartTime && cmd1.EndTime == cmd2.EndTime)
            {
                list.Add(new ConflictingCommandsWarning()
                {
                    Conflict = Conflict.SameTime,
                    RelatedLine = cmd1.Line,
                    OffendingLine = cmd2.Line,
                });

                return list;
            }
            else if (cmd2.StartTime > cmd1.StartTime && cmd2.StartTime < cmd1.EndTime)
            {
                list.Add(new ConflictingCommandsWarning()
                {
                    Conflict = Conflict.Overlapping,
                    RelatedLine = cmd1.Line,
                    OffendingLine = cmd2.Line,
                });
            }

            return list;
        }

        public List<ConflictingCommandsWarning> FindConflictingCommandTypes(VisualElement visualElement)
        {
            List<ConflictingCommandsWarning> list = new List<ConflictingCommandsWarning>();

            var commandGroups = visualElement.Commands.GroupBy(c => c.Identifier);

            if (commandGroups.Any(g => g.Key == "M") && commandGroups.Any(g => g.Key == "MX" || g.Key == "MY"))
            {
                var relatedLine = commandGroups.Where(g => g.Key == "M").SelectMany(g => g).First().Line;
                foreach(var cmd in commandGroups.Where(g => g.Key == "MX" || g.Key == "MY").SelectMany(g => g))
                {
                    list.Add(new ConflictingCommandsWarning()
                    {
                        Conflict = Conflict.IncompatibleCommands,
                        OffendingLine = cmd.Line,
                        RelatedLine = relatedLine,
                    });
                }
            }

            return list;
        }
    }
}

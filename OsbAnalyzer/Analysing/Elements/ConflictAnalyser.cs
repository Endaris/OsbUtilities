﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;
using OsbAnalyzer.Contracts.Warnings;
using OsbAnalyzer.Analysing.Helper;
using OsbAnalyzer.Contracts;

namespace OsbAnalyzer.Analysing.Elements
{
    public class ConflictAnalyser : IAnalyser
    {
        public List<StoryboardWarning> Analyse(VisualElement visualElement)
        {
            return FindConflicts(visualElement);
        }


        public List<StoryboardWarning> FindConflicts(VisualElement visualElement)
        {
            List<StoryboardWarning> conflictingCommandsWarnings = new List<StoryboardWarning>();
            var commands = AnalysingHelper.ResolveLoops(visualElement.Commands);
            commands = AnalysingHelper.ResolveTriggers(commands);

            var spriteCommandGroups = commands.Where(c => c is IOsbSpriteCommand)
                                              .Select(c => (IOsbSpriteCommand)c)
                                              .GroupBy(c => c.Identifier);
            //var spriteCommandGroup = commands.Where(c => c is IOsbSpriteCommand).GroupBy(c => c.Identifier);

            foreach (var group in spriteCommandGroups)
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

        public List<ConflictingCommandsWarning> FindConflictingTimes(IOsbSpriteCommand cmd1, IOsbSpriteCommand cmd2)
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
                    WarningLevel = WarningLevel.MostLikelyNotRankable,
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
                    WarningLevel = GetWarningLevelForTimeConflict(cmd1, cmd2),
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
                        WarningLevel = WarningLevel.CompletelyBroken,
                    });
                }
            }

            return list;
        }

        private WarningLevel GetWarningLevelForTimeConflict(IOsbSpriteCommand cmd1, IOsbSpriteCommand cmd2)
        {
            double overlapDuration;
            if (cmd2.EndTime > cmd1.EndTime)
                overlapDuration = cmd1.EndTime - cmd2.StartTime;
            else
                return WarningLevel.CompletelyBroken;

            double percentageOfFirst = overlapDuration / cmd1.Duration;
            double percentageOfSecond;
            if (cmd2.Duration == 0)
                percentageOfSecond = 1;
            else
                percentageOfSecond = overlapDuration / cmd2.Duration;

            double warningLevel = 2 * (percentageOfFirst + percentageOfSecond);

            return (WarningLevel)(int)Math.Round(warningLevel);

        }
    }
}

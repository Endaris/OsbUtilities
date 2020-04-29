using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;
using Contracts;
using Contracts.Commands;
using OsbAnalyser.Analysing.Helper;
using Contracts.Enums;

namespace OsbAnalyser.Test
{
    public class AnalyzingHelperTest
    {
        private IEnumerable<IOsbCommand> resolveLoopCmds = new List<IOsbCommand>()
        {
            new LoopCommand()
            {
                Identifier = "L",
                Line = 1,
                LoopCount = 24,
                StartTime = 11599,
                OsbCommands = new List<IOsbSpriteCommand>()
                {
                    new ScaleCommand()
                    {
                        StartTime = 0,
                        EndTime = 624,
                        Line = 2,
                        Identifier = "S",
                        StartValue = 0.24,
                        EndValue = 0.2,
                    },
                    new ScaleCommand()
                    {
                        StartTime = 624,
                        EndTime = 724,
                        Line = 3,
                        Identifier = "S",
                        StartValue = 0.2,
                        EndValue = 0.24,
                    },
                }
            },
            new MoveCommand()
            {
                StartTime = 10599,
                EndTime = 10801,
                Identifier = "M",
                Line = 4,
                StartValue = new CommandPosition(440, 240),
                EndValue = new CommandPosition(440, 240),
            }
        };

        [Fact]
        public void ResolveLoopsTest1()
        {
            var result = AnalysingHelper.ResolveLoops(resolveLoopCmds);

            Assert.True(result.Count() == 49);
            Assert.True(result.ElementAt(4).StartTime == 13047);
            Assert.True(result.ElementAt(5).StartTime == 13671);
            Assert.True(result.ElementAt(48).Identifier == "M");
        }

        private IEnumerable<IOsbCommand> resolveTriggerCmds = new List<IOsbCommand>()
        {
            new MoveCommand()
            {
                StartTime = 290749,
                EndTime = 295762,
                Identifier = "M",
                Line = 1,
                StartValue = new CommandPosition(-83, 34),
                EndValue = new CommandPosition(-98, 42.66026),
            },
            new MoveCommand()
            {
                StartTime = 295762,
                EndTime = 300775,
                Identifier = "M",
                Line = 2,
                StartValue = new CommandPosition(-98, 42.66026),
                EndValue = new CommandPosition(-98, 25.33975),
            },
            new TriggerCommand()
            {
                StartTime = 24665,
                EndTime = 36177,
                Identifier = "T",
                Line = 3,
                TriggerGroup = 0,
                TriggerName = "HitSoundSoftClap",
                OsbCommands = new List<IOsbSpriteCommand>()
                {
                    new VectorScaleCommand()
                    {
                        Line = 4,
                        Identifier = "V",
                        StartTime = 0,
                        EndTime = 500,
                        Easing = OsbEasing.InElastic,
                        StartValue = new CommandScale(24, 6),
                        EndValue = new CommandScale(24, 2),
                    }
                },
            }
        };

        [Fact]
        public void ResolveTriggersTest1()
        {
            var result = AnalysingHelper.ResolveTriggers(resolveTriggerCmds);

            Assert.True(result.Count() == 3);
            Assert.True(result.ElementAt(2).EndTime == 36677);
        }

    }
}

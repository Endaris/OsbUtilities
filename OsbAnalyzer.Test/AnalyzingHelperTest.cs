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
                        StartValue = 0.24,
                        EndValue = 0.2,
                    },
                    new ScaleCommand()
                    {
                        StartTime = 624,
                        EndTime = 724,
                        Line = 3,
                        StartValue = 0.2,
                        EndValue = 0.24,
                    },
                }
            },
            new MoveCommand()
            {
                StartTime = 10599,
                EndTime = 10801,
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

        private IEnumerable<IOsbCommand> resolveLoopsCmds2 = new List<IOsbCommand>()
        {
            new LoopCommand()
            {
                Line = 1,
                LoopCount = 64,
                StartTime = 0,
                OsbCommands = new List<IOsbSpriteCommand>()
                {
                    new ScaleCommand()
                    {
                        Easing = OsbEasing.None,
                        StartTime = 9736,
                        EndTime = 9736,
                        StartValue = 0.4666666,
                        EndValue = 0.4666666,
                        Line = 2,
                    },
                    new MoveCommand()
                    {
                        Easing = OsbEasing.InOutQuint,
                        StartTime = 9736,
                        EndTime = 10433,
                        StartValue = new CommandPosition(320,240),
                        EndValue = new CommandPosition(320, 229.3333),
                        Line = 3,
                    },
                    new RotateCommand()
                    {
                        Easing = OsbEasing.InOutQuint,
                        StartTime = 9736,
                        EndTime = 10433,
                        StartValue = 0,
                        EndValue = 0.02133331,
                        Line = 4,
                    },
                    new MoveCommand()
                    {
                        Easing = OsbEasing.InOutQuint,
                        StartTime = 10433,
                        EndTime = 11131,
                        StartValue = new CommandPosition(320,229.3333),
                        EndValue = new CommandPosition(320, 240),
                        Line = 5,
                    },
                    new RotateCommand()
                    {
                        Easing = OsbEasing.InOutQuint,
                        StartTime = 10433,
                        EndTime = 11131,
                        StartValue = 0.02133331,
                        EndValue = 0,
                        Line = 6,
                    },
                }
            }
        };

        [Fact]
        public void ResolveLoopsTest2()
        {
            var result = AnalysingHelper.ResolveLoops(resolveLoopsCmds2);

            Assert.True(result.Count() == 5 * 64);
            Assert.True(result.OrderBy(c => c.StartTime).First().StartTime == 9736);
            Assert.True(result.OrderBy(c => c.EndTime).Last().EndTime == 9736 + 64 * 1395); // = 99016
        }

        private IEnumerable<IOsbCommand> resolveTriggerCmds = new List<IOsbCommand>()
        {
            new MoveCommand()
            {
                StartTime = 290749,
                EndTime = 295762,
                Line = 1,
                StartValue = new CommandPosition(-83, 34),
                EndValue = new CommandPosition(-98, 42.66026),
            },
            new MoveCommand()
            {
                StartTime = 295762,
                EndTime = 300775,
                Line = 2,
                StartValue = new CommandPosition(-98, 42.66026),
                EndValue = new CommandPosition(-98, 25.33975),
            },
            new TriggerCommand()
            {
                StartTime = 24665,
                EndTime = 36177,
                Line = 3,
                TriggerGroup = 0,
                TriggerName = "HitSoundSoftClap",
                OsbCommands = new List<IOsbSpriteCommand>()
                {
                    new VectorScaleCommand()
                    {
                        Line = 4,
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

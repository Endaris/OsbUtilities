using System;
using Xunit;
using OsbAnalyser.Analysing.Elements;
using Contracts;
using Contracts.Enums;
using System.Collections.Generic;
using Contracts.Commands;
using OsbAnalyser.Warnings;
using System.Linq;

namespace OsbAnalyser.Test
{
    public class ConflictAnalyserTest
    {
        private ConflictAnalyser ConflictAnalyser = new ConflictAnalyser();

        private OsbCommand<CommandPosition> cmd1 = new MoveCommand()
        {
            Easing = OsbEasing.None,
            StartTime = 17,
            EndTime = 124,
            Identifier = "M",
            StartValue = new CommandPosition(15, 320),
            EndValue = new CommandPosition(320, 240),
            Line = 29,
        };

        private OsbCommand<CommandPosition> cmd2 = new MoveCommand()
        {
            Easing = OsbEasing.None,
            StartTime = 1700,
            EndTime = 12400,
            Identifier = "M",
            StartValue = new CommandPosition(15, 320),
            EndValue = new CommandPosition(320, 240),
            Line = 74,
        };

        private OsbCommand<CommandPosition> cmd3 = new MoveCommand()
        {
            Easing = OsbEasing.None,
            StartTime = 9600,
            EndTime = 17300,
            Identifier = "M",
            StartValue = new CommandPosition(15, 320),
            EndValue = new CommandPosition(320, 240),
            Line = 124,
        };
        private OsbCommand<CommandPosition> cmd4 = new MoveCommand()
        {
            Easing = OsbEasing.None,
            StartTime = 9600,
            EndTime = 17300,
            Identifier = "M",
            StartValue = new CommandPosition(15, 320),
            EndValue = new CommandPosition(320, 240),
            Line = 125,
        };

        private OsbCommand<double> cmd5 = new MoveXCommand()
        {
            Easing = OsbEasing.None,
            StartTime = 10000,
            EndTime = 20000,
            Identifier = "MX",
            StartValue = 320,
            EndValue = 640,
            Line = 128,
        };

        private OsbCommand<double> cmd6 = new MoveYCommand()
        {
            Easing = OsbEasing.None,
            StartTime = 10000,
            EndTime = 20000,
            Identifier = "MY",
            StartValue = 240,
            EndValue = 480,
            Line = 129,
        };


        [Fact]
        public void FindConflictingCommandTypesTest1()
        {
            VisualElement visualElement = new VisualElement()
            {
                Commands = new List<IOsbCommand>() { cmd1, cmd2, cmd3, cmd4, cmd5, cmd6},
            };
            var result = ConflictAnalyser.FindConflictingCommandTypes(visualElement);

            Assert.True(result.Count == 2);
            Assert.True(result[0].Conflict == Contracts.Warnings.Conflict.IncompatibleCommands);
            Assert.True(result[0].OffendingLine == 128 || result[0].OffendingLine == 129);
        }

        [Fact]
        public void FindConflictingTimesTest1()
        {
            var result = ConflictAnalyser.FindConflictingTimes(cmd1, cmd2);

            Assert.True(result.Count == 0);
        }

        [Fact]
        public void FindConflictingTimesTest2()
        {
            var result = ConflictAnalyser.FindConflictingTimes(cmd2, cmd3);

            Assert.True(result.Count == 1);
            Assert.True(result[0].Conflict == Contracts.Warnings.Conflict.Overlapping);
        }

        [Fact]
        public void FindConflictingTimesTest3()
        {
            var result = ConflictAnalyser.FindConflictingTimes(cmd3, cmd4);

            Assert.True(result.Count == 1);
            Assert.True(result[0].Conflict == Contracts.Warnings.Conflict.SameTime);
        }



        [Fact]
        public void FindConflictingTimesTest4()
        {
            var visualElement = new VisualElement()
            {
                Layer = OsbLayer.Background,
                Anchor = OsbOrigin.Centre,
                Line = 5880,
                InitialPosition = new CommandPosition(0, 0),
                zIndex = 0,
                RelativePath = @"sb\l.png",
                Commands = new List<IOsbCommand>()
                {
                    new LoopCommand()
                    {
                        Identifier = "L",
                        StartTime = 283852,
                        Line = 5880,
                        LoopCount = 2,
                        OsbCommands = new List<IOsbSpriteCommand>()
                        {
                            new MoveYCommand()
                            {
                                Identifier = "MY",
                                Easing = OsbEasing.None,
                                StartTime = 0,
                                EndTime = 17594,
                                StartValue = 188,
                                EndValue = -100,
                                Line = 5881,
                            },
                                new MoveYCommand()
                            {
                                Identifier = "MY",
                                Easing = OsbEasing.None,
                                StartTime = 17594,
                                EndTime = 36654,
                                StartValue = 500,
                                EndValue = 188,
                                Line = 5882,
                            },
                        },
                    },
                    new LoopCommand()
                    {
                        Identifier = "L",
                        StartTime = 283852,
                        Line = 5880,
                        LoopCount = 2,
                        OsbCommands = new List<IOsbSpriteCommand>()
                        {
                            new MoveXCommand()
                            {
                                Identifier = "MX",
                                Easing = OsbEasing.Out,
                                StartTime = 0,
                                EndTime = 7675,
                                StartValue = 159,
                                EndValue = 109,
                                Line = 5881,
                            },
                                new MoveXCommand()
                            {
                                Identifier = "MX",
                                Easing = OsbEasing.In,
                                StartTime = 7675,
                                EndTime = 15351,
                                StartValue = 109,
                                EndValue = 159,
                                Line = 5882,
                            },
                                new MoveXCommand()
                            {
                                Identifier = "MX",
                                Easing = OsbEasing.Out,
                                StartTime = 15351,
                                EndTime = 23027,
                                StartValue = 159,
                                EndValue = 209,
                                Line = 5883,
                            },
                                new MoveXCommand()
                            {
                                Identifier = "MX",
                                Easing = OsbEasing.In,
                                StartTime = 23027,
                                EndTime = 30702,
                                StartValue = 209,
                                EndValue = 159,
                                Line = 5884,
                            },
                        },
                    },
                    new LoopCommand()
                    {
                        Identifier = "L",
                        StartTime = 283943,
                        Line = 5880,
                        LoopCount = 5,
                        OsbCommands = new List<IOsbSpriteCommand>()
                        {
                            new FadeCommand()
                            {
                                Identifier = "F",
                                Easing = OsbEasing.None,
                                StartTime = 0,
                                EndTime = 4357,
                                StartValue = 0.15,
                                EndValue = 0.5,
                                Line = 5881,
                            },
                                new ScaleCommand()
                            {
                                Identifier = "S",
                                Easing = OsbEasing.None,
                                StartTime = 0,
                                EndTime = 4357,
                                StartValue = 0.02045512,
                                EndValue = 0.02659166,
                                Line = 5882,
                            },
                                new FadeCommand()
                            {
                                Identifier = "F",
                                Easing = OsbEasing.None,
                                StartTime = 4357,
                                EndTime = 8715,
                                StartValue = 0.5,
                                EndValue = 0.15,
                                Line = 5883,
                            },
                                new ScaleCommand()
                            {
                                Identifier = "S",
                                Easing = OsbEasing.None,
                                StartTime = 4357,
                                EndTime = 8715,
                                StartValue = 0.02659166,
                                EndValue = 0.02045512,
                                Line = 5884,
                            },
                        },
                    },
                    new ParameterCommand()
                    {
                        Identifier = "P",
                        Easing = OsbEasing.None,
                        StartTime = 280095,
                        EndTime = 337488,
                        StartValue =  ParameterType.AdditiveBlending,
                        EndValue =  ParameterType.AdditiveBlending,
                        Line = 5894,
                    },
                    new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.In,
                        StartTime = 280277,
                        EndTime = 283943,
                        StartValue = 0,
                        EndValue = 0.15,
                        Line = 5895,
                    },
                    new ColorCommand()
                    {
                        Identifier = "C",
                        Easing = OsbEasing.In,
                        StartTime = 283943,
                        EndTime = 287608,
                        StartValue = new CommandColor(0,0,0),
                        EndValue = new CommandColor(87,87,43),
                        Line = 5896,
                    },
                    new ColorCommand()
                    {
                        Identifier = "C",
                        Easing = OsbEasing.None,
                        StartTime = 287608,
                        EndTime = 312735,
                        StartValue = new CommandColor(87,87,43),
                        EndValue = new CommandColor(108,65,32),
                        Line = 5897,
                    },
                    new ColorCommand()
                    {
                        Identifier = "C",
                        Easing = OsbEasing.Out,
                        StartTime = 312735,
                        EndTime = 327397,
                        StartValue = new CommandColor(108,65,32),
                        EndValue = new CommandColor(0,0,0),
                        Line = 5898,
                    },
                    new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 327488,
                        EndTime = 327488,
                        StartValue = 0,
                        EndValue = 0,
                        Line = 5899,
                    },
                    new ScaleCommand()
                    {
                        Identifier = "S",
                        Easing = OsbEasing.None,
                        StartTime = 327488,
                        EndTime = 327488,
                        StartValue = 0,
                        EndValue = 0,
                        Line = 5900,
                    },
                    new ColorCommand()
                    {
                        Identifier = "C",
                        Easing = OsbEasing.None,
                        StartTime = 327488,
                        EndTime = 327488,
                        StartValue = new CommandColor(0,0,0),
                        EndValue = new CommandColor(0,0,0),
                        Line = 5901,
                    },
                },
            };

            var result = ConflictAnalyser.Analyse(visualElement);

            Assert.InRange(result.FirstOrDefault().WarningLevel,
                Contracts.Warnings.WarningLevel.Insignificant,
                Contracts.Warnings.WarningLevel.Critical);
        }
    }
}

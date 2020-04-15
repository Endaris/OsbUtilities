using System;
using Xunit;
using OsbAnalyzer.Analysing.Elements;
using Contracts;
using Contracts.Enums;
using System.Collections.Generic;

namespace OsbAnalyzer.Test
{
    public class ConflictAnalyserTest
    {
        private ConflictAnalyser ConflictAnalyser = new ConflictAnalyser();

        private OsbCommand<CommandPosition> cmd1 = new OsbCommand<CommandPosition>()
        {
            Easing = OsbEasing.None,
            StartTime = 17,
            EndTime = 124,
            Identifier = "M",
            StartValue = new CommandPosition(15, 320),
            EndValue = new CommandPosition(320, 240),
            Line = 29,
        };

        private OsbCommand<CommandPosition> cmd2 = new OsbCommand<CommandPosition>()
        {
            Easing = OsbEasing.None,
            StartTime = 1700,
            EndTime = 12400,
            Identifier = "M",
            StartValue = new CommandPosition(15, 320),
            EndValue = new CommandPosition(320, 240),
            Line = 74,
        };

        private OsbCommand<CommandPosition> cmd3 = new OsbCommand<CommandPosition>()
        {
            Easing = OsbEasing.None,
            StartTime = 9600,
            EndTime = 17300,
            Identifier = "M",
            StartValue = new CommandPosition(15, 320),
            EndValue = new CommandPosition(320, 240),
            Line = 124,
        };
        private OsbCommand<CommandPosition> cmd4 = new OsbCommand<CommandPosition>()
        {
            Easing = OsbEasing.None,
            StartTime = 9600,
            EndTime = 17300,
            Identifier = "M",
            StartValue = new CommandPosition(15, 320),
            EndValue = new CommandPosition(320, 240),
            Line = 125,
        };

        private OsbCommand<double> cmd5 = new OsbCommand<double>()
        {
            Easing = OsbEasing.None,
            StartTime = 10000,
            EndTime = 20000,
            Identifier = "MX",
            StartValue = 320,
            EndValue = 640,
            Line = 128,
        };

        private OsbCommand<double> cmd6 = new OsbCommand<double>()
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
    }
}

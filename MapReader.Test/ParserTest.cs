using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using MapReader.Parsing;
using static MapReader.Test.ParsingElementResources;
using Contracts.Commands;
using Contracts;

namespace MapReader.Test
{
    public class ParserTest
    {
        Parser Parser = new Parser();


        [Fact] 
        public void GetCompoundCommandLinesTest1()
        {
            var result = Parser.GetCompoundCommandLines(Parsify(doubleLoopTestString), 1);

            Assert.True(result.Count == 3);
        }

        [Fact]
        public void GetCompoundCommandLinesTest2()
        {
            var result = Parser.GetCompoundCommandLines(Parsify(endTriggerTestString), 3);

            Assert.True(result.Count == 2);
        }

        [Fact]
        public void ParseTest1()
        {
            var result = Parser.Parse(Parsify(moveDefaultValueTestString));

            Assert.True(result.Commands.Where(c => c is MoveCommand).All(mc => ((MoveCommand)mc).DefaultValue == result.InitialPosition));
            Assert.True(result.Commands.Where(c => c is MoveXCommand).All(mc => ((MoveXCommand)mc).DefaultValue == result.InitialPosition.X));
            Assert.True(result.Commands.Where(c => c is MoveYCommand).All(mc => ((MoveYCommand)mc).DefaultValue == result.InitialPosition.Y));
        }

        [Fact]
        public void ParseTest2()
        {
            var result = Parser.Parse(Parsify(brokenWarningLevel1));

            Assert.True(result.Commands.Count() == 11);
        }

    }
}

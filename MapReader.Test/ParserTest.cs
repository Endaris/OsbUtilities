using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using MapReader.Parsing;
using static MapReader.Test.ParsingElementResources;

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

    }
}

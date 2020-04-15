using System;
using System.Linq;
using Xunit;

namespace MapReader.Test
{
    public class OsbReaderTest
    {
        [Fact]
        public void ValidSBParses()
        {
            OsbReader osbReader = new OsbReader();
            var sb = osbReader.GetMainStoryboard(Properties.Resources.FarEastNightbird_osb.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None).ToList());

            Assert.True(sb.OsbElements.Count() > 0);
            Assert.True(sb.OsbElements.All(e => e.Commands.Count() > 0));
        }


    }
}

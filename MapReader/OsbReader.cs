using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Contracts;
using Contracts.Enums;
using MapReader.Parsing;

namespace MapReader
{
    public class OsbReader
    {
        public Storyboard GetMainStoryboard(List<string> fileContent)
        {
            List<string> OsbContent = Prepare(fileContent);
            EventsToObjectMapper eventsToObjectMapper = new EventsToObjectMapper();
            return eventsToObjectMapper.GetStoryboard(OsbContent);
        }


        private List<string> Prepare(List<string> fileContent)
        {
            VariableResolver variableResolver = new VariableResolver();
            return variableResolver.Resolve(fileContent);
        }
    }
}

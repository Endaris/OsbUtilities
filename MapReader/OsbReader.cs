using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Contracts;
using Contracts.Enums;

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
            //TODO: Implement converting variables into their respective values and remove the variables part from the osbContent
            // for now the assumption is made that there is no longer a variable section and all variables are already applied in the event section
            VariableResolver variableResolver = new VariableResolver();
            return variableResolver.Resolve(fileContent);
        }
    }
}

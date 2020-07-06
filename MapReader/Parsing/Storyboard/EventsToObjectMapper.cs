using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using Contracts;
using Contracts.Commands;
using Contracts.Enums;

namespace MapReader.Parsing
{
    public class EventsToObjectMapper
    {
        public Storyboard GetStoryboard(List<string> content)
        {
            int lineStart = GetEventSectionStartAsLineNumber(content);

            if (lineStart < 0)
                throw new FormatException("Content contains no Event section");

            List<ParsingElement> parsingElements = GetParsingElements(content, lineStart);
            Storyboard storyboard = new Storyboard();
            Parser parser = new Parser();

            foreach(ParsingElement parsingElement in parsingElements)
            {
                storyboard.OsbElements = storyboard.OsbElements.Append(parser.Parse(parsingElement));
            }

            return storyboard;
        }

        private int GetEventSectionStartAsLineNumber(List<string> content)
        {
            int index = content.IndexOf("[Events]");
            if (index < 0)
                throw new InvalidOperationException("Give me an [Events] line so I know where to start...");
            else
                return index + 1;
        }

        private List<ParsingElement> GetParsingElements(List<string> content, int lineStart)
        {
            List<ParsingElement> parsingElements = new List<ParsingElement>();
            ParsingElement parsingElement = new ParsingElement();
            //<= because it's 1 based for the linenumber, not 0 based for the index
            for (int lineNumber = lineStart; lineNumber <= content.Count; lineNumber++)
            {
                string line = content[lineNumber - 1];

                //we reached the end of the eventsection
                if (string.IsNullOrWhiteSpace(line))
                    break;

                //we don't do storyboarded hitsounds (yet)
                if (line.StartsWith("//Storyboard Sound Samples"))
                    break;

                if (line.StartsWith("//") || line == "[Events]")
                    continue;

                if (!line.StartsWith(' '))
                {
                    parsingElement = new ParsingElement();
                    parsingElement.LineStart = lineNumber;
                    parsingElements.Add(parsingElement);
                }

                parsingElement.Lines.Add(line);
            }
            return parsingElements;
        }
    }
}

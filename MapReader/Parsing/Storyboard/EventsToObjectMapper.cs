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
        public int LineOffset = 0;

        public Storyboard GetStoryboard(IEnumerable<string> content)
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

        private int GetEventSectionStartAsLineNumber(IEnumerable<string> content)
        {
            int index = content.ToList().IndexOf("[Events]");
            if (index < 0)
                throw new InvalidOperationException("Give me an [Events] line so I know where to start...");
            else
                return index + 1;
        }

        private List<ParsingElement> GetParsingElements(IEnumerable<string> content, int lineStart)
        {
            List<ParsingElement> parsingElements = new List<ParsingElement>();
            ParsingElement parsingElement = new ParsingElement();

            bool skip = true;
            //<= because it's 1 based for the linenumber, not 0 based for the index
            for (int lineNumber = lineStart; lineNumber <= content.Count(); lineNumber++)
            {
                string line = content.ElementAt(lineNumber - 1);

                //we reached the end of the eventsection
                if (string.IsNullOrWhiteSpace(line))
                    break;

                //we don't do storyboarded hitsounds (yet)
                if (line.StartsWith("//Storyboard Sound Samples"))
                    break;

                //ignore background and video events and break periods for simplicity's sake (for now)
                if (line.StartsWith("//Storyboard Layer 0 (Background)"))
                    skip = false;

                if (line.StartsWith("//") || line == "[Events]")
                    continue;            

                if (!line.StartsWith(' ') && !skip)
                {
                    parsingElement = new ParsingElement();
                    parsingElement.LineStart = lineNumber + LineOffset;
                    parsingElements.Add(parsingElement);
                }

                parsingElement.Lines.Add(line);
            }
            return parsingElements;
        }
    }
}

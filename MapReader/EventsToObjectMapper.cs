using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using Contracts;
using Contracts.Commands;
using Contracts.Enums;

namespace MapReader
{
    internal class EventsToObjectMapper
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
                return index;
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

    class ParsingElement
    {
        public List<string> Lines { get; set; } = new List<string>();
        public int LineStart { get; set; }
    }

    class Parser
    {
        public OsbElement Parse(ParsingElement element)
        {
            OsbElement osbElement = GetOsbElement(element.Lines.FirstOrDefault(), element.LineStart);

            for (int i = 1; i < element.Lines.Count; i++)
            {
                var values = element.Lines[i].Trim().Split(',');

                if (IsCompoundCommand(values[0]))
                {
                    List<string> Lines = element.Lines.TakeLast(element.Lines.Count - i)
                                                      .TakeWhile(l => l.TakeWhile(Char.IsWhiteSpace).Count() > element.Lines[i].TakeWhile(Char.IsWhiteSpace).Count()
                                                                   || l.Equals(element.Lines[i]))
                                                      .ToList();
                    osbElement.Commands = osbElement.Commands.Append(ParseCompoundCommandLine(Lines, element.LineStart));
                    i = i + Lines.Count - 1;
                }
                else
                {
                    osbElement.Commands = osbElement.Commands.Append(ParseCommandLine(element.Lines[i], element.LineStart + i));
                    
                }
            }

            return osbElement;
        }

        private IOsbSpriteCommand ParseCommandLine(string line, int lineNumber)
        {
            var values = line.Trim().Split(',');

            if (string.IsNullOrEmpty(values[3]))
                values[3] = values[2];

            var commandType = values[0];
            var easing = (OsbEasing)int.Parse(values[1]);
            var startTime = double.Parse(values[2], CultureInfo.InvariantCulture);
            var endTime = double.Parse(values[3], CultureInfo.InvariantCulture);

            switch (commandType)
            {
                case "F":
                    {
                        var startValue = double.Parse(values[4], CultureInfo.InvariantCulture);
                        var endValue = values.Length > 5 ? double.Parse(values[5], CultureInfo.InvariantCulture) : startValue;
                        return new OsbCommand<double>()
                        {
                            Easing = easing,
                            Identifier = commandType,
                            StartTime = startTime,
                            EndTime = endTime,
                            StartValue = startValue,
                            EndValue = endValue,
                            Line = lineNumber,
                        };
                    }
                case "S":
                    {
                        var startValue = double.Parse(values[4], CultureInfo.InvariantCulture);
                        var endValue = values.Length > 5 ? double.Parse(values[5], CultureInfo.InvariantCulture) : startValue;
                        return new OsbCommand<double>()
                        {
                            Easing = easing,
                            Identifier = commandType,
                            StartTime = startTime,
                            EndTime = endTime,
                            StartValue = startValue,
                            EndValue = endValue,
                            Line = lineNumber,
                        };
                    }
                case "V":
                    {
                        var startX = double.Parse(values[4], CultureInfo.InvariantCulture);
                        var startY = double.Parse(values[5], CultureInfo.InvariantCulture);
                        var endX = values.Length > 6 ? double.Parse(values[6], CultureInfo.InvariantCulture) : startX;
                        var endY = values.Length > 7 ? double.Parse(values[7], CultureInfo.InvariantCulture) : startY;
                        return new OsbCommand<CommandScale>()
                        {
                            Easing = easing,
                            Identifier = commandType,
                            StartTime = startTime,
                            EndTime = endTime,
                            StartValue = new CommandScale() { X = startX, Y = startY },
                            EndValue = new CommandScale() { X = endX, Y = endY },
                            Line = lineNumber,
                        };
                    }
                case "R":
                    {
                        var startValue = double.Parse(values[4], CultureInfo.InvariantCulture);
                        var endValue = values.Length > 5 ? double.Parse(values[5], CultureInfo.InvariantCulture) : startValue;
                        return new OsbCommand<double>()
                        {
                            Easing = easing,
                            Identifier = commandType,
                            StartTime = startTime,
                            EndTime = endTime,
                            StartValue = startValue,
                            EndValue = endValue,
                            Line = lineNumber,
                        };
                    }
                case "M":
                    {
                        var startX = double.Parse(values[4], CultureInfo.InvariantCulture);
                        var startY = double.Parse(values[5], CultureInfo.InvariantCulture);
                        var endX = values.Length > 6 ? double.Parse(values[6], CultureInfo.InvariantCulture) : startX;
                        var endY = values.Length > 7 ? double.Parse(values[7], CultureInfo.InvariantCulture) : startY;
                        return new OsbCommand<CommandPosition>()
                        {
                            Easing = easing,
                            Identifier = commandType,
                            StartTime = startTime,
                            EndTime = endTime,
                            StartValue = new CommandPosition() { X = startX, Y = startY },
                            EndValue = new CommandPosition() { X = endX, Y = endY },
                            Line = lineNumber,
                        };
                    }
                case "MX":
                    {
                        var startValue = double.Parse(values[4], CultureInfo.InvariantCulture);
                        var endValue = values.Length > 5 ? double.Parse(values[5], CultureInfo.InvariantCulture) : startValue;
                        return new OsbCommand<double>()
                        {
                            Easing = easing,
                            Identifier = commandType,
                            StartTime = startTime,
                            EndTime = endTime,
                            StartValue = startValue,
                            EndValue = endValue,
                            Line = lineNumber,
                        };
                    }
                case "MY":
                    {
                        var startValue = double.Parse(values[4], CultureInfo.InvariantCulture);
                        var endValue = values.Length > 5 ? double.Parse(values[5], CultureInfo.InvariantCulture) : startValue;
                        return new OsbCommand<double>()
                        {
                            Easing = easing,
                            Identifier = commandType,
                            StartTime = startTime,
                            EndTime = endTime,
                            StartValue = startValue,
                            EndValue = endValue,
                            Line = lineNumber,
                        };
                    }
                case "C":
                    {
                        var startR = byte.Parse(values[4], CultureInfo.InvariantCulture);
                        var startG = byte.Parse(values[5], CultureInfo.InvariantCulture);
                        var startB = byte.Parse(values[6], CultureInfo.InvariantCulture);
                        var endR = values.Length > 7 ? byte.Parse(values[7], CultureInfo.InvariantCulture) : startR;
                        var endG = values.Length > 8 ? byte.Parse(values[8], CultureInfo.InvariantCulture) : startG;
                        var endB = values.Length > 9 ? byte.Parse(values[9], CultureInfo.InvariantCulture) : startB;
                        return new OsbCommand<CommandColor>()
                        {
                            Easing = easing,
                            Identifier = commandType,
                            StartTime = startTime,
                            EndTime = endTime,
                            StartValue = new CommandColor() { R = startR, G = startG, B = startB },
                            EndValue = new CommandColor() { R = endR, G = endG, B = endB },
                            Line = lineNumber,
                        };
                    }
                case "P":
                    {
                        var type = GetParameterType(values[4]);
                        return new OsbCommand<ParameterType>()
                        {
                            Easing = easing,
                            Identifier = commandType,
                            StartTime = startTime,
                            EndTime = endTime,
                            StartValue = type,
                            EndValue = type,
                            Line = lineNumber,
                        };
                    }
                default:
                    throw new FormatException($"Invalid Commandtype {commandType} detected");
            }
        }

        private IOsbCompoundCommand ParseCompoundCommandLine(List<string> lines, int lineStart)
        {
            IOsbCompoundCommand osbCompoundCommand = GetOsbCompoundCommand(lines.FirstOrDefault(), lineStart);

            for(int i = 1; i < lines.Count; i++)
            {
                osbCompoundCommand.OsbCommands = osbCompoundCommand.OsbCommands.Append(ParseCommandLine(lines[i], lineStart + i));
            }

            return osbCompoundCommand;
        }

        private IOsbCompoundCommand GetOsbCompoundCommand(string line, int lineStart)
        {
            if (string.IsNullOrWhiteSpace(line))
                throw new FormatException($"CompoundCommand in line {lineStart} cannot be read");

            var values = line.Trim().Split(',');

            switch (values[0])
            {
                case "T":
                    {
                        var triggerName = values[1];
                        var startTime = double.Parse(values[2], CultureInfo.InvariantCulture);
                        var endTime = double.Parse(values[3], CultureInfo.InvariantCulture);
                        var groupNumber = values.Length > 4 ? int.Parse(values[4]) : 0;
                        return new TriggerCommand()
                        {
                            StartTime = startTime,
                            EndTime = endTime,
                            Line = lineStart,
                            Identifier = values[0],
                            TriggerName = triggerName,
                            TriggerGroup = groupNumber,
                            OsbCommands = new List<IOsbSpriteCommand>(),
                        };
                    }
                case "L":
                    {
                        var startTime = double.Parse(values[1], CultureInfo.InvariantCulture);
                        var loopCount = int.Parse(values[2]);
                        return new LoopCommand()
                        {
                            StartTime = startTime,
                            Line = lineStart,
                            Identifier = values[0],
                            LoopCount = loopCount,
                            OsbCommands = new List<IOsbSpriteCommand>(),
                        };
                    }
                default:
                    {
                        throw new FormatException($"Invalid CompoundCommandtype {values[0]} detected");
                    }
            }
        }

        private bool IsCompoundCommand(string identifier)
        {
            switch (identifier)
            {
                case "T":
                case "L":
                    return true;
                default:
                    return false;
            }
        }

        private ParameterType GetParameterType(string paramIdentifier)
        {
            switch (paramIdentifier)
            {
                case "A": return ParameterType.AdditiveBlending;
                case "H": return ParameterType.FlipHorizontal;
                case "V": return ParameterType.FlipVertical;
                default: return ParameterType.None;
            }
        }

        private OsbElement GetOsbElement(string line, int lineNumber)
        {
            if (string.IsNullOrWhiteSpace(line))
                throw new FormatException("Sprite Initialisation could not be read");

            var values = line.Trim().Split(',');

            var layerName = values[1];
            var origin = (OsbOrigin)Enum.Parse(typeof(OsbOrigin), values[2]);
            var path = removePathQuotes(values[3]);
            var x = float.Parse(values[4], CultureInfo.InvariantCulture);
            var y = float.Parse(values[5], CultureInfo.InvariantCulture);
            return new OsbElement()
            {
                Anchor = origin,
                Layer = GetLayer(layerName),
                LineNumber = lineNumber,
                LineInitialisation = line,
                X = x,
                Y = y,
                Path = path,
                Sprite = GetRectangle(path),
                Commands = new List<IOsbCommand>(),
            };
        }

        private OsbLayer GetLayer(string layerName)
        {
            switch (layerName)
            {
                case "Background":
                    return OsbLayer.Background;
                case "Fail":
                    return OsbLayer.Fail;
                case "Pass":
                    return OsbLayer.Pass;
                case "Foreground":
                    return OsbLayer.Foreground;
                case "Overlay":
                    return OsbLayer.Overlay;
                default:
                    return OsbLayer.Background;
            }
        }

        private static string removePathQuotes(string path)
        {
            return path.StartsWith("\"") && path.EndsWith("\"") ? path.Substring(1, path.Length - 2) : path;
        }

        public Rectangle GetRectangle(string RelativePath)
        {
            return new Rectangle();
            //TODO: needs to be moved
            //string path = System.IO.Path.Combine(@".\", RelativePath);
            //Image image = Image.FromStream(System.IO.File.OpenRead(path), false, false);
            //return new Rectangle(0, 0, image.Width, image.Height);
        }
    }
}

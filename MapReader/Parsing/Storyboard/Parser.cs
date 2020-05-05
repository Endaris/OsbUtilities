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
    public class Parser
    {
        public VisualElement Parse(ParsingElement element)
        {
            try
            {
                VisualElement osbElement = GetOsbElement(element.Lines.FirstOrDefault(), element.LineStart);

                for (int i = 1; i < element.Lines.Count; i++)
                {
                    var values = element.Lines[i].Trim().Split(',');

                    if (IsCompoundCommand(values[0]))
                    {
                        List<string> Lines = GetCompoundCommandLines(element, i);
                        osbElement.Commands = osbElement.Commands.Append(ParseCompoundCommandLine(Lines, element.LineStart, osbElement.InitialPosition));
                        i = i + Lines.Count - 1;
                    }
                    else
                    {
                        osbElement.Commands = osbElement.Commands.Append(ParseCommandLine(element.Lines[i], element.LineStart + i, osbElement.InitialPosition));
                    }
                }

                return osbElement;
            }        
            catch (Exception)
            {
                throw new Exception($"Parsing commands failed for element at line {element.LineStart}");
            }
        }

        public List<string> GetCompoundCommandLines(ParsingElement element, int i)
        {
            var lines = element.Lines.GetRange(i, element.Lines.Count - i);
            return lines.TakeWhile(l => l.TakeWhile(char.IsWhiteSpace).Count() > lines[0].TakeWhile(char.IsWhiteSpace).Count()
                                      || ReferenceEquals(l, lines[0])).ToList();
        }

        public IOsbSpriteCommand ParseCommandLine(string line, int lineNumber, CommandPosition initialPosition)
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
                        return new FadeCommand()
                        {
                            Easing = easing,
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
                        return new ScaleCommand()
                        {
                            Easing = easing,
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
                        return new VectorScaleCommand()
                        {
                            Easing = easing,
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
                        return new RotateCommand()
                        {
                            Easing = easing,
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

                        var m = new MoveCommand()
                        {
                            Easing = easing,
                            StartTime = startTime,
                            EndTime = endTime,
                            StartValue = new CommandPosition() { X = startX, Y = startY },
                            EndValue = new CommandPosition() { X = endX, Y = endY },
                            Line = lineNumber,
                        };
                        m.SetDefaultValue(initialPosition);
                        return m;
                    }
                case "MX":
                    {
                        var startValue = double.Parse(values[4], CultureInfo.InvariantCulture);
                        var endValue = values.Length > 5 ? double.Parse(values[5], CultureInfo.InvariantCulture) : startValue;
                        var mx = new MoveXCommand()
                        {
                            Easing = easing,
                            StartTime = startTime,
                            EndTime = endTime,
                            StartValue = startValue,
                            EndValue = endValue,
                            Line = lineNumber,
                        };
                        mx.SetDefaultValue(initialPosition);
                        return mx;
                    }
                case "MY":
                    {
                        var startValue = double.Parse(values[4], CultureInfo.InvariantCulture);
                        var endValue = values.Length > 5 ? double.Parse(values[5], CultureInfo.InvariantCulture) : startValue;
                        var my = new MoveYCommand()
                        {
                            Easing = easing,
                            StartTime = startTime,
                            EndTime = endTime,
                            StartValue = startValue,
                            EndValue = endValue,
                            Line = lineNumber,
                        };
                        my.SetDefaultValue(initialPosition);
                        return my;
                    }
                case "C":
                    {
                        var startR = byte.Parse(values[4], CultureInfo.InvariantCulture);
                        var startG = byte.Parse(values[5], CultureInfo.InvariantCulture);
                        var startB = byte.Parse(values[6], CultureInfo.InvariantCulture);
                        var endR = values.Length > 7 ? byte.Parse(values[7], CultureInfo.InvariantCulture) : startR;
                        var endG = values.Length > 8 ? byte.Parse(values[8], CultureInfo.InvariantCulture) : startG;
                        var endB = values.Length > 9 ? byte.Parse(values[9], CultureInfo.InvariantCulture) : startB;
                        return new ColorCommand()
                        {
                            Easing = easing,
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
                        return new ParameterCommand()
                        {
                            Easing = easing,
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

        private IOsbCompoundCommand ParseCompoundCommandLine(List<string> lines, int lineStart, CommandPosition initialPosition)
        {
            IOsbCompoundCommand osbCompoundCommand = GetOsbCompoundCommand(lines.FirstOrDefault(), lineStart);

            for (int i = 1; i < lines.Count; i++)
            {
                osbCompoundCommand.OsbCommands = osbCompoundCommand.OsbCommands.Append(ParseCommandLine(lines[i], lineStart + i, initialPosition));
            }

            return osbCompoundCommand;
        }

        public IOsbCompoundCommand GetOsbCompoundCommand(string line, int lineStart)
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
                default: throw new FormatException($"Unknown parametertype '{paramIdentifier}'");
            }
        }

        private VisualElement GetOsbElement(string line, int lineNumber)
        {
            if (string.IsNullOrWhiteSpace(line))
                throw new FormatException("Sprite Initialisation could not be read");

            var values = line.Trim().Split(',');

            var layerName = values[1];
            var origin = (OsbOrigin)Enum.Parse(typeof(OsbOrigin), values[2]);
            var path = removePathQuotes(values[3]);
            var x = float.Parse(values[4], CultureInfo.InvariantCulture);
            var y = float.Parse(values[5], CultureInfo.InvariantCulture);
            return new VisualElement()
            {
                Anchor = origin,
                Layer = GetLayer(layerName),
                Line = lineNumber,
                LineInitialisation = line,
                InitialPosition = new CommandPosition(x, y),
                RelativePath = path,
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
                    throw new FormatException($"Unknown layername '{layerName}'");
            }
        }

        private static string removePathQuotes(string path)
        {
            return path.StartsWith("\"") && path.EndsWith("\"") ? path[1..^1] : path;
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

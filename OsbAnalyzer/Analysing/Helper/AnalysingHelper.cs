using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;
using Contracts.Commands;

namespace OsbAnalyzer.Analysing.Helper
{
    public static class AnalysingHelper
    {
        /// <summary>
        /// Resolves all loop commands into the resulting sprite commands
        /// </summary>
        /// <param name="originalCommands"></param>
        /// <returns></returns>
        public static IEnumerable<IOsbCommand> ResolveLoops(IEnumerable<IOsbCommand> originalCommands)
        {
            var loopCommands = originalCommands.Where(c => c is LoopCommand).ToList();
            var cmds = originalCommands.ToList();

            if (loopCommands.Count() > 0)
            {
                foreach(LoopCommand loopCommand in loopCommands)
                {
                    int index = cmds.IndexOf(loopCommand);
                    cmds.RemoveAt(index);
                    for(int i = loopCommand.LoopCount - 1; i >= 0; i--)
                    {
                        for(int j = loopCommand.OsbCommands.Count() - 1; j >= 0; j--)
                        {
                            IOsbSpriteCommand ogCommand = loopCommand.OsbCommands.ElementAt(j);
                            IOsbSpriteCommand newCommand = CreateNewSpriteCommand(ogCommand);
                            newCommand.StartTime = loopCommand.StartTime + loopCommand.LoopDuration * i + newCommand.StartTime;
                            newCommand.EndTime = loopCommand.StartTime + loopCommand.LoopDuration * i + newCommand.EndTime;
                            cmds.Insert(index, newCommand);
                        }
                    }
                }
            }

            return cmds;
        }

        public static IEnumerable<IOsbCommand> ResolveTriggers(IEnumerable<IOsbCommand> originalCommands)
        {
            var triggerCommands = originalCommands.Where(c => c is TriggerCommand).ToList();
            var cmds = originalCommands.ToList();

            if (triggerCommands.Count() > 0)
            {
                foreach(TriggerCommand triggerCommand in triggerCommands)
                {
                    int index = cmds.IndexOf(triggerCommand);
                    cmds.RemoveAt(index);
                    for(int i = triggerCommand.OsbCommands.Count() - 1; i >= 0; i--)
                    {
                        IOsbSpriteCommand ogCommand = triggerCommand.OsbCommands.ElementAt(i);
                        IOsbSpriteCommand newCommand = CreateNewSpriteCommand(ogCommand);
                        newCommand.StartTime = triggerCommand.StartTime + newCommand.StartTime;
                        newCommand.EndTime = triggerCommand.EndTime + newCommand.EndTime;
                        cmds.Insert(index, newCommand);
                    }
                }
            }

            return cmds;
        }

        private static IOsbSpriteCommand CreateNewSpriteCommand(IOsbSpriteCommand bluePrint)
        {
            var type = bluePrint.GetType();
            IOsbSpriteCommand spriteCommand = (IOsbSpriteCommand)Activator.CreateInstance(type);
            spriteCommand.Identifier = bluePrint.Identifier;
            spriteCommand.StartTime = bluePrint.StartTime;
            spriteCommand.EndTime = bluePrint.EndTime;
            spriteCommand.StartValue = bluePrint.StartValue;
            spriteCommand.EndValue = bluePrint.EndValue;
            spriteCommand.Line = bluePrint.Line;
            return spriteCommand;
        }
    }
}

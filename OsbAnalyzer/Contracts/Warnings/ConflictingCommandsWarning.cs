using System;
using System.Collections.Generic;
using System.Text;

namespace OsbAnalyser.Contracts.Warnings
{
    public class ConflictingCommandsWarning : StoryboardWarning
    {
        public override int OffendingLine { get; set; }
        public int RelatedLine { get; set; }
        public Conflict Conflict { get; set; }
        public override string ToString()
        {
            switch(Conflict)
            {
                case Conflict.SameTime:
                    return $"Command at line {OffendingLine} happens at the same time and thus conflicts with the command of the same type at line {RelatedLine}.";
                case Conflict.Overlapping:
                    return $"Command at line {OffendingLine} overlaps in time and thus conflicts with the command of the same type at line {RelatedLine}.";
                case Conflict.IncompatibleCommands:
                    return $"Commandtypes used in line {OffendingLine} and {RelatedLine} are incompatible.";
                default:
                    throw new InvalidOperationException("You're trying to do a string output for an undefined Conflicttype");
            }
        }
    }

    public enum Conflict
    {
        SameTime,
        Overlapping,
        IncompatibleCommands //M MX
    }
}

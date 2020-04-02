using System;
using System.Collections.Generic;
using System.Text;
using Contracts.Enums;

namespace Contracts
{
    public interface IOsbCommand
    {
        double StartTime { get; }
        double EndTime { get; }
        string Identifier { get; }
        int Line { get; }
    }

    public interface IOsbSpriteCommand : IOsbCommand
    {
        Type ValueType { get; }
        object StartValue { get; }
        object EndValue { get; }
    }

    public interface IOsbSpriteCommand<TValue> : IOsbSpriteCommand
    {       
        OsbEasing Easing { get; }     
        double Duration => EndTime - StartTime;
        new TValue StartValue { get; }
        new TValue EndValue { get; }
        int Depth { get; }
    }
}

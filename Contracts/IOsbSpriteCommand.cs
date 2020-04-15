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
        new double StartTime { get; set; }
        new double EndTime { get; set; }
        new string Identifier { get; set; }
        new int Line { get; set;  }
        Type ValueType { get; }
        object StartValue { get; set; }
        object EndValue { get; set; }
    }

    public interface IOsbSpriteCommand<TValue> : IOsbSpriteCommand
    {       
        OsbEasing Easing { get; }     
        double Duration => EndTime - StartTime;
        new TValue StartValue { get; }
        new TValue EndValue { get; }
    }
}

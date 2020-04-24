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
        double Duration { get; }
        string Identifier { get; }
        int Line { get; }
        //this only exists so I have a slightly easier time generating objects for the test projects and I don't know how to do it better
        string TestString { get; }
    }

    public interface IOsbSpriteCommand : IOsbCommand
    {
        new double StartTime { get; set; }
        new double EndTime { get; set; }
        new double Duration { get; }
        new string Identifier { get; set; }
        new int Line { get; set;  }
        //this funky construct allows to access start and end value in collections where the valuetype does not need to be specified
        Type ValueType { get; }
        object StartValue { get; set; }
        object EndValue { get; set; }
        object DefaultValue { get; }
    }

    public interface IOsbSpriteCommand<TValue> : IOsbSpriteCommand
    {       
        OsbEasing Easing { get; }     
        new double Duration => EndTime - StartTime;
        new TValue StartValue { get; }
        new TValue EndValue { get; }
        new TValue DefaultValue { get; }
    }
}

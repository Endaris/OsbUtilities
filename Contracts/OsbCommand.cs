using System;
using System.Collections.Generic;
using System.Text;
using Contracts.Enums;

namespace Contracts
{
    public class OsbCommand<TValue> : IOsbSpriteCommand<TValue>
    {
        public string Identifier { get; set; }
        public OsbEasing Easing { get; set; }
        public double StartTime { get; set; }
        public double EndTime { get; set; }
        public double Duration => EndTime - StartTime;
        public TValue StartValue { get; set; }
        public TValue EndValue { get; set; }
        object IOsbSpriteCommand.StartValue => StartValue;
        object IOsbSpriteCommand.EndValue => EndValue;
        public Type ValueType { get { return typeof(TValue); } }
        public int Depth { get; set; }
        public int Line { get; set; }
    }
}

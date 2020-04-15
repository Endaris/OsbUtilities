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
        object IOsbSpriteCommand.StartValue
        {
            get { return StartValue; }
            set
            {
                if (value is TValue)
                    StartValue = (TValue)value;
            }
        }
        object IOsbSpriteCommand.EndValue 
        {
            get { return EndValue; }
            set
            {
                if (value is TValue)
                    EndValue = (TValue)value;
            }
        }
        public Type ValueType { get { return typeof(TValue); } }
        public int Line { get; set; }
    }
}

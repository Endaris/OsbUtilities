using System;
using System.Collections.Generic;
using System.Text;
using Contracts.Enums;

namespace Contracts
{
    public abstract class OsbCommand<TValue> : IOsbSpriteCommand<TValue>
    {
        public string Identifier { get; set; }
        public OsbEasing Easing { get; set; }
        public double StartTime { get; set; }
        public double EndTime { get; set; }
        public double Duration => EndTime - StartTime;
        public TValue StartValue { get; set; }
        public TValue EndValue { get; set; }
        public abstract TValue DefaultValue { get; }
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
        object IOsbSpriteCommand.DefaultValue => DefaultValue;

        public Type ValueType { get { return typeof(TValue); } }
        public int Line { get; set; }

        //this only exists so I have a slightly easier time generating objects for the test projects and I don't know how to do it better
        public string TestString =>
             $@"new {this.GetType().Name}()
{{
    Identifier = ""{Identifier}"",
    Easing = OsbEasing.{Easing},
    StartTime = {StartTime},
    EndTime = {EndTime},
    StartValue = new {StartValue.GetType().Name}{StartValue},
    EndValue = new {EndValue.GetType().Name}{EndValue},
    Line = {Line},
}};";
       
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;
using OsbAnalyser.Contracts;

namespace OsbAnalyser.Warnings
{
    public class RedundantTransformationWarning : StoryboardWarning
    {
        public int RelatedLine { get; set; }
        public string Identifier { get; set; }
        public override string ToString()
        {
            return $"{Identifier} Transformation at line {OffendingLine} is redundant with the previous transformation at line {RelatedLine}.";
        }
    }
}

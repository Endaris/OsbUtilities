using System;
using System.Collections.Generic;
using System.Text;
using OsbAnalyser.Contracts;

namespace OsbAnalyser.Contracts.Warnings
{
    public class ObsoleteSpriteWarning : StoryboardWarning
    {
        public override string ToString()
        {
            return "Sprite has no commands whatsoever.";
        }
    }
}

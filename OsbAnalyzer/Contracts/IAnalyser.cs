using System;
using System.Collections.Generic;
using System.Text;
using Contracts;

namespace OsbAnalyzer.Contracts
{
    interface IAnalyser
    {
        List<StoryboardWarning> Analyse(VisualElement visualElement);
    }
}

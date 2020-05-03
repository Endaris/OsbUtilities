using System;
using System.Collections.Generic;
using System.Text;
using Contracts;

namespace OsbAnalyser.Contracts
{
    public interface IAnalyser
    {
        List<StoryboardWarning> Analyse(VisualElement visualElement);
    }
}

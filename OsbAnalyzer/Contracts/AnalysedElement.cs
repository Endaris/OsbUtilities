using System;
using System.Collections.Generic;
using System.Text;
using Contracts;

namespace OsbAnalyser.Contracts
{
    public class AnalysedElement
    {
        public IEnumerable<IStoryboardOptimisation> StoryboardOptimisations { get; set; }
        public IEnumerable<StoryboardWarning> StoryboardWarnings { get; set; }
        public VisualElement VisualElement { get; set; }
    }
}

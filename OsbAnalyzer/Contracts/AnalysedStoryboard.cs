using System;
using System.Collections.Generic;
using System.Text;

namespace OsbAnalyzer.Contracts
{
    public class AnalysedStoryboard
    {
        public IEnumerable<AnalysedElement> AnalysedElements { get; set; }
        public StoryboardInfo StoryboardInfo { get; set; }
    }
}

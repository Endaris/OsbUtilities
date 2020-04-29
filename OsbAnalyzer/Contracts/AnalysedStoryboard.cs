using System;
using System.Collections.Generic;
using System.Text;

namespace OsbAnalyser.Contracts
{
    public class AnalysedStoryboard
    {
        public IEnumerable<AnalysedElement> AnalysedElements { get; set; }
    }
}

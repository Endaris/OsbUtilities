using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;
using OsbAnalyzer.Analysing.Elements;
using OsbAnalyzer.Contracts;

namespace OsbAnalyzer
{
    public class OsbAnalyzer
    {
        public AnalysedStoryboard Analyse(Storyboard storyboard)
        {
            return new AnalysedStoryboard()
            {
                AnalysedElements = storyboard.OsbElements.Select(e => Analyse(e)),
            };
        }

        public AnalysedElement Analyse(VisualElement visualElement)
        {
            return new AnalysedElement()
            {
                VisualElement = visualElement,
                StoryboardWarnings = GenerateWarnings(visualElement),
            };
        }

        private List<StoryboardWarning> GenerateWarnings(VisualElement visualElement)
        {
            List<StoryboardWarning> storyboardWarnings = new List<StoryboardWarning>();
            ConflictAnalyser conflictAnalyser = new ConflictAnalyser();
            storyboardWarnings.AddRange(conflictAnalyser.FindConflicts(visualElement));
            return storyboardWarnings;
        }
    }
}

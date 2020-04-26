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
        private List<IAnalyser> Analysers = new List<IAnalyser>()
        {
            new ConflictAnalyser(),
            new ProlongedActivityAnalyser(),
            new FadeOutAnalyser(),
            new IllogicalAnalyser(),
            new RedundancyAnalyser(),
        };

        public AnalysedStoryboard Analyse(Storyboard storyboard, bool createInfo = false)
        {
            return new AnalysedStoryboard()
            {
                AnalysedElements = storyboard.OsbElements.Select(e => Analyse(e)),
                StoryboardInfo = (createInfo) ? new StoryboardInfo(storyboard) : null,
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
            Analysers.ForEach(a => storyboardWarnings.AddRange(a.Analyse(visualElement)));
            return storyboardWarnings;
        }
    }
}

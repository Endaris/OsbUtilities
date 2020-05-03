using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;
using OsbAnalyser.Analysing.Elements;
using OsbAnalyser.Contracts;
using OsbAnalyser.Contracts.Warnings;

namespace OsbAnalyser
{
    public class StoryboardAnalyser
    {
        public AnalysedStoryboard Analyse(Storyboard storyboard)
        {
            List<IAnalyser> Analysers = new List<IAnalyser>()
            {
                new ConflictAnalyser(),
                new ProlongedActivityAnalyser(),
                new FadeOutAnalyser(),
                new IllogicalAnalyser(),
                new RedundancyAnalyser(),
                //new OffscreenAnalyser(storyboard.Resources),
            };

            return new AnalysedStoryboard()
            {
                AnalysedElements = storyboard.OsbElements.Select(e => Analyse(e, Analysers))
            };
        }

        public AnalysedElement Analyse(VisualElement visualElement, List<IAnalyser> analysers)
        {
            return new AnalysedElement()
            {
                VisualElement = visualElement,
                StoryboardWarnings = GenerateWarnings(visualElement, analysers),
            };
        }

        private List<StoryboardWarning> GenerateWarnings(VisualElement visualElement, List<IAnalyser> analysers)
        {
            List<StoryboardWarning> storyboardWarnings = new List<StoryboardWarning>();
            if (visualElement.Commands?.Count() > 0)
            {
                analysers.ForEach(a => storyboardWarnings.AddRange(a.Analyse(visualElement)));
            }    
            else
            {
                storyboardWarnings.Add(new ObsoleteSpriteWarning()
                {
                    OffendingLine = visualElement.Line,
                    WarningLevel = Contracts.Warnings.WarningLevel.Critical
                });
            }
                
            return storyboardWarnings;
        }
    }
}

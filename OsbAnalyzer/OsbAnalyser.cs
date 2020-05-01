using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;
using OsbAnalyser.Analysing.Elements;
using OsbAnalyser.Contracts;
using OsbAnalyzer.Contracts.Warnings;

namespace OsbAnalyser
{
    public class OsbAnalyser
    {
        private List<IAnalyser> Analysers = new List<IAnalyser>()
        {
            new ConflictAnalyser(),
            new ProlongedActivityAnalyser(),
            new FadeOutAnalyser(),
            new IllogicalAnalyser(),
            new RedundancyAnalyser(),
        };

        public AnalysedStoryboard Analyse(Storyboard storyboard)
        {
            return new AnalysedStoryboard()
            {
                AnalysedElements = storyboard.OsbElements.Select(e => Analyse(e))
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
            if (visualElement.Commands?.Count() > 0)
            {
                Analysers.ForEach(a => storyboardWarnings.AddRange(a.Analyse(visualElement)));
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

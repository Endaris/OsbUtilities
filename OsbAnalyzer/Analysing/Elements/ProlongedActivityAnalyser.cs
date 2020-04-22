using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;
using OsbAnalyzer.Contracts;
using OsbAnalyzer.Analysing.Helper;
using OsbAnalyzer.Warnings;
using OsbAnalyzer.Contracts.Warnings;
using Contracts.Commands;

namespace OsbAnalyzer.Analysing.Elements
{
    public class ProlongedActivityAnalyser : IAnalyser
    {
        private VisibilityAnalyser _visibilityAnalyser;
        private VisibilityAnalyser VisibilityAnalyser
        {
            get
            {
                if (_visibilityAnalyser == null)
                    _visibilityAnalyser = new VisibilityAnalyser();
                return _visibilityAnalyser;
            }
        }

        public List<StoryboardWarning> Analyse(VisualElement visualElement)
        {
            StoryboardWarning warning = FindProlongedActivity(visualElement);
            if (warning == null)
                return new List<StoryboardWarning>();
            else
                return new List<StoryboardWarning>() { warning };
        }

        public StoryboardWarning FindProlongedActivity(VisualElement visualElement)
        {
            var visibleTimes = VisibilityAnalyser.GetVisibleTimes(AnalysingHelper.ResolveTriggers(AnalysingHelper.ResolveLoops(visualElement.Commands)));

            double timeProlonged;

            if (visibleTimes.Count() > 0)
                timeProlonged = (visibleTimes.First().Item1 - visualElement.StartTime) + (visualElement.EndTime - visibleTimes.Last().Item2);             
            else
                timeProlonged = visualElement.Duration;

            if (timeProlonged == 0 )
            {
                return null;
            }
            else
            {
                return new ProlongedActivityWarning()
                {
                    OffendingLine = visualElement.Line,
                    timeProlonged = timeProlonged,
                    percentageProlonged = timeProlonged / visualElement.Duration,
                    WarningLevel = GetWarningLevel(visualElement, timeProlonged),
                };
            }
        }

        private WarningLevel GetWarningLevel(VisualElement visualElement, double timeProlonged)
        {
            WarningLevel warningLevel;
            if (timeProlonged == 0)
                warningLevel = WarningLevel.MostLikelyRankable;
            else if (timeProlonged < 5000)
                warningLevel = WarningLevel.LikelyRankable;
            else if (timeProlonged < 10000)
                warningLevel = WarningLevel.MaybeRankable;
            else if (timeProlonged < 15000)
                warningLevel = WarningLevel.LikelyNotRankable;
            else if (timeProlonged < 20000)
                warningLevel = WarningLevel.MostLikelyNotRankable;
            else
                warningLevel = WarningLevel.CompletelyBroken;

            double percentage = timeProlonged / visualElement.Duration;

            while (warningLevel != WarningLevel.CompletelyBroken && percentage > 0.2)
            {
                warningLevel = warningLevel + 1;
                percentage -= 0.2;
            }

            return warningLevel;
        }
    }
}

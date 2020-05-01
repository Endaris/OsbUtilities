﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;
using OsbAnalyser.Analysing.Helper;
using OsbAnalyser.Contracts;
using OsbAnalyser.Contracts.Warnings;

namespace OsbAnalyser.Analysing.Elements
{
    public class FadeOutAnalyser : IAnalyser
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
            StoryboardWarning warning = FindExcessiveFadeOutTimes(visualElement);
            if (warning == null)
                return new List<StoryboardWarning>();
            else
                return new List<StoryboardWarning>() { warning };
        }

        public StoryboardWarning FindExcessiveFadeOutTimes(VisualElement visualElement)
        {
            var visibleTimes = VisibilityAnalyser.GetVisibleTimes(AnalysingHelper.ResolveTriggers(AnalysingHelper.ResolveLoops(visualElement.Commands)));

            double timeInvisible;
            if (visibleTimes.Count() > 0)
                timeInvisible = visualElement.Duration - visibleTimes.Sum(t => t.Item2 - t.Item1);
            else
                timeInvisible = visualElement.Duration;

            if (timeInvisible < visualElement.Duration * 0.35)
                return null;
            else
            {
                return new FadeOutWarning()
                {
                    OffendingLine = visualElement.Line,
                    timeInvisible = timeInvisible,
                    percentageInvisible = timeInvisible / visualElement.Duration,
                    WarningLevel = GetWarningLevel(visualElement.Duration, timeInvisible),
                };
            }
        }

        private WarningLevel GetWarningLevel(double timeActive, double timeInvisible)
        {
            double percentageInvisible = timeInvisible / timeActive;

            if (percentageInvisible < 0.5)
                return WarningLevel.Low;
            else if (percentageInvisible < 0.6)
                return WarningLevel.Medium;
            else if (percentageInvisible < 0.7)
                return WarningLevel.MediumPlus;
            else if (percentageInvisible < 0.8)
                return WarningLevel.High;
            else
                return WarningLevel.Critical;
        }
    }
}

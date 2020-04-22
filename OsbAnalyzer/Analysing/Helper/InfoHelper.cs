using System;
using System.Collections.Generic;
using System.Text;
using Contracts;

namespace OsbAnalyzer.Analysing.Helper
{
    public static class InfoHelper
    {
        public static bool IsVisibleAt(this VisualElement visualElement, double time)
        {
            return new VisibilityAnalyser().IsVisibleAt(visualElement, time);
        }

        public static bool IsActiveAt(this VisualElement visualElement, double time)
        {
            return time >= visualElement.StartTime && time <= visualElement.EndTime;
        }
    }
}

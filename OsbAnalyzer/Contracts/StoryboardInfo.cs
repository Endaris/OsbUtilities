using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;
using Contracts.Commands;
using OsbAnalyzer.Analysing.Helper;

namespace OsbAnalyzer.Contracts
{
    public class StoryboardInfo
    {
        public Dictionary<double, int> ActiveSpriteData { get; private set; }
        public Dictionary<double, int> VisibleSpriteData { get; private set; }
        public Dictionary<double, int> ActiveCommandData { get; private set; }
        public Dictionary<double, int> VisibleCommandData { get; private set; }

        /// <summary>
        /// Set the interval in ms for generating datapoints
        /// If it's too low it can take extremely long to generate data and the default is usually enough to get an idea so be warned about lowering it
        /// </summary>
        private int dx;

        public StoryboardInfo(Storyboard storyboard, int msResolution = 2000)
        {
            dx = msResolution;
            PopulateData(storyboard.OsbElements);
        }

        private void PopulateData(IEnumerable<VisualElement> visualElements)
        {
            if (visualElements.Count() == 0)
                return;

            ActiveSpriteData = new Dictionary<double, int>();
            VisibleSpriteData = new Dictionary<double, int>();
            ActiveCommandData = new Dictionary<double, int>();
            VisibleCommandData = new Dictionary<double, int>();

            double startTime = visualElements.OrderBy(e => e.StartTime).First().StartTime;
            double endTime = visualElements.OrderBy(e => e.EndTime).Last().EndTime;

            IEnumerable<VisualElementInfo> list = visualElements.Select(e => new VisualElementInfo(e));

            for (int time = (int)startTime; time < endTime; time += dx)
            {
                int activeSprites = 0;
                int visibleSprites = 0;
                int activeCommands = 0;
                int visibleCommands = 0;

                foreach(var element in list)
                {
                    if (element.IsActiveAt(time))
                    {
                        activeSprites++;
                        activeCommands += element.CommandCount;

                        if (element.IsVisibleAt(time))
                        {
                            visibleSprites++;
                            visibleCommands += element.CommandCount;
                        }
                    }
                }

                ActiveSpriteData.Add(time, activeSprites);
                VisibleSpriteData.Add(time, visibleSprites);
                ActiveCommandData.Add(time, activeCommands);
                VisibleCommandData.Add(time, visibleCommands);
            }
        }

        class VisualElementInfo
        {
            private VisualElement VisualElement;
            private IEnumerable<Tuple<double, double>> VisibleTimes;
            private bool HasTrigger;
            public int CommandCount { get; private set; }

            public VisualElementInfo(VisualElement visualElement)
            {
                VisualElement = visualElement;
                VisibleTimes = new VisibilityAnalyser().GetVisibleTimes(visualElement.Commands);
                HasTrigger = visualElement.Commands.Any(c => c is TriggerCommand);
                CommandCount = VisualElement.Commands.Count();
            }

            public bool IsVisibleAt(double time)
            {
                return VisibleTimes.Any(t => t.Item1 <= time && t.Item2 >= time);
            }

            public bool IsActiveAt(double time)
            {
                return HasTrigger || time >= VisualElement.StartTime && time <= VisualElement.EndTime;
            }
        }
    }
}

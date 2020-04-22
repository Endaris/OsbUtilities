using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;
using OsbAnalyzer.Analysing.Helper;

namespace OsbAnalyzer.Contracts
{
    public class StoryboardInfo
    {
        public Dictionary<double, int> ActiveSpriteData { get; private set; }
        public Dictionary<double, int> VisibleSpriteData { get; private set; }
        public Dictionary<double, int> ActiveCommandData { get; private set; }
        public Dictionary<double, int> VisibleCommandData { get; private set; }

        public StoryboardInfo(Storyboard storyboard)
        {
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

            for(int time = (int)startTime; time < endTime; time += 16)
            {
                int activeSprites = 0;
                int visibleSprites = 0;
                int activeCommands = 0;
                int visibleCommands = 0;

                foreach(var element in visualElements)
                {
                    if (element.IsActiveAt(time))
                    {
                        activeSprites++;
                        activeCommands += element.Commands.Count();

                        if (element.IsVisibleAt(time))
                        {
                            visibleSprites++;
                            visibleCommands += element.Commands.Count();
                        }
                    }
                }

                ActiveSpriteData.Add(time, activeSprites);
                VisibleSpriteData.Add(time, visibleSprites);
                ActiveCommandData.Add(time, activeCommands);
                VisibleCommandData.Add(time, visibleCommands);
            }
        }
    }
}

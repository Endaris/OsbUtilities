using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Contracts.Commands;
using OsbAnalyser.Analysing.Helper;

namespace OsbAnalyser.Contracts
{
    public class StoryboardInfo
    {
        public Dictionary<int, int> ActiveSpriteData { get; private set; }
        public Dictionary<int, int> VisibleSpriteData { get; private set; }
        public Dictionary<int, int> ActiveCommandData { get; private set; }
        public Dictionary<int, int> VisibleCommandData { get; private set; }

        private readonly Storyboard Storyboard;

        /// <summary>
        /// Set the interval in ms for generating datapoints
        /// If it's too low it can take extremely long to generate data and the default is usually enough to get an idea so be warned about lowering it
        /// </summary>
        private int dx;

        public StoryboardInfo(Storyboard storyboard)
        {
            Storyboard = storyboard;
        }

        public Task GenerateSpriteData(int msResolution = 2000)
        {
            dx = msResolution;
            return DoStuff(Storyboard.OsbElements);
        }

        private async Task DoStuff(IEnumerable<VisualElement> visualElements)
        {
            await Task.Run(() =>
            {
                if (visualElements.Count() == 0)
                    return;

                double startTime = visualElements.OrderBy(e => e.StartTime).First().StartTime;
                double endTime = visualElements.OrderBy(e => e.EndTime).Last().EndTime;

                int dataPointCount = (int)Math.Ceiling((endTime - startTime) / dx);

                ActiveSpriteData = new Dictionary<int, int>(dataPointCount);
                VisibleSpriteData = new Dictionary<int, int>(dataPointCount);
                ActiveCommandData = new Dictionary<int, int>(dataPointCount);
                VisibleCommandData = new Dictionary<int, int>(dataPointCount);

                //if we don't put this into a fresh and new IEnumerable the multithreading part makes us crash
                //that's (probably) because the select only gets evaluated when the list is first used which is within the multithreading part
                //and then we lose - readonly just to make clear that nothing happens to the list
                var list = new ReadOnlyCollection<VisualElementInfo>(visualElements.Select(e => new VisualElementInfo(e)).ToList());
                HashSet<int> times = new HashSet<int>(dataPointCount);

                for (int time = (int)startTime; time < endTime; time += dx)
                    times.Add(time);

                Parallel.ForEach(times, time =>
                {
                    var datapoint = GetDataPoint(list, time);

                    ActiveSpriteData.Add(time, datapoint.ActiveSprites);
                    VisibleSpriteData.Add(time, datapoint.VisibleSprites);
                    ActiveCommandData.Add(time, datapoint.ActiveCommands);
                    VisibleCommandData.Add(time, datapoint.VisibleCommands);
                });
                // order needs to be corrected after running the data accumulation in parallel
                ActiveSpriteData = ActiveSpriteData.OrderBy(d => d.Key).ToDictionary(d => d.Key, d => d.Value);
                VisibleSpriteData = VisibleSpriteData.OrderBy(d => d.Key).ToDictionary(d => d.Key, d => d.Value);
                ActiveCommandData = ActiveCommandData.OrderBy(d => d.Key).ToDictionary(d => d.Key, d => d.Value);
                VisibleCommandData = VisibleCommandData.OrderBy(d => d.Key).ToDictionary(d => d.Key, d => d.Value);
            });           
        }

        private DataPoint GetDataPoint(IList<VisualElementInfo> list, int time)
        {
            DataPoint totalDataPoint = new DataPoint();
            object o = new object();
            Parallel.ForEach(list,
                    () => new DataPoint(),
                    (element, state, datapoint) =>
                    {
                        if (element.IsActiveAt(time))
                        {
                            datapoint.ActiveSprites++;
                            datapoint.ActiveCommands += element.CommandCount;

                            if (element.IsVisibleAt(time))
                            {
                                datapoint.VisibleSprites++;
                                datapoint.VisibleCommands += element.CommandCount;
                            }
                        }
                        return datapoint;
                    },
                    (datapoint) =>
                    {
                        lock (o)
                        {
                            totalDataPoint.ActiveSprites += datapoint.ActiveSprites;
                            totalDataPoint.VisibleSprites += datapoint.VisibleSprites;
                            totalDataPoint.ActiveCommands += datapoint.ActiveCommands;
                            totalDataPoint.VisibleCommands += datapoint.VisibleCommands;
                        }
                    });
            return totalDataPoint;
        }

        class DataPoint
        {
            public int ActiveSprites { get; set; }
            public int VisibleSprites { get; set; }
            public int ActiveCommands { get; set; }
            public int VisibleCommands { get; set; }
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
                CommandCount = VisualElement.Commands.Where(c => !(c is IOsbCompoundCommand)).Count()
                                + VisualElement.Commands.Where(c => c is IOsbCompoundCommand)
                                                        .Select(c => (IOsbCompoundCommand)c)
                                                        .Sum(c => c.OsbCommands.Count());

            }

            public bool IsVisibleAt(int time)
            {
                return VisibleTimes.Any(t => t.Item1 <= time && t.Item2 >= time);
            }

            public bool IsActiveAt(int time)
            {
                return HasTrigger || time >= VisualElement.StartTime && time <= VisualElement.EndTime;
            }
        }
    }
}

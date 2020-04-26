using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;
using Contracts.Commands;

namespace OsbAnalyzer.Analysing.Helper
{
    public class VisibilityAnalyser
    {
        public IEnumerable<Tuple<double, double>> GetVisibleTimes(IEnumerable<IOsbCommand> commands)
        {
            SortedDictionary<double, bool> sortedFadeTimes = GetSortedFadeTimes(commands);

            List<Tuple<double, double>> list = new List<Tuple<double, double>>();
            bool visible = false;
            double startOfCurrentState = sortedFadeTimes.First().Key;

            for (int i = 0; i < sortedFadeTimes.Count; i++)
            {
                var element = sortedFadeTimes.ElementAt(i);
                if (element.Value != visible)
                {
                    if (visible)
                    {
                        list.Add(new Tuple<double, double>(startOfCurrentState, element.Key));
                    }
                    startOfCurrentState = element.Key;
                    visible = element.Value;
                }
            }
            return list;
        }


        private SortedDictionary<double, bool> GetSortedFadeTimes(IEnumerable<IOsbCommand> commands)
        {
            List<KeyValuePair<double, bool>> fadeTimes = new List<KeyValuePair<double, bool>>();
            if (!commands.Any(c => c is FadeCommand))
            {
                if (commands.Any(c => c.EndTime > c.StartTime))
                {
                    fadeTimes.Add(KeyValuePair.Create<double, bool>(commands.OrderBy(c => c.StartTime).FirstOrDefault().StartTime, true));
                    fadeTimes.Add(KeyValuePair.Create<double, bool>(commands.OrderBy(c => c.EndTime).LastOrDefault().EndTime, false));
                }
                else
                {
                    fadeTimes.Add(KeyValuePair.Create<double, bool>(commands.OrderBy(c => c.StartTime).FirstOrDefault().StartTime, false));
                }
            }
            else
            {
                var fadeCommands = Unconflictify(commands.Where(c => c.Identifier == "F")
                                                         .Select(c => (FadeCommand)c)
                                                         ).OrderBy(c => c.StartTime);

                //always assume the start-state of the first fadecommand
                fadeTimes.Add(KeyValuePair.Create<double, bool>(commands.OrderBy(c => c.StartTime).FirstOrDefault().StartTime,
                                                                fadeCommands.First().StartValue > 0));

                foreach (var cmd in fadeCommands)
                {
                    fadeTimes.Add(KeyValuePair.Create<double, bool>(cmd.StartTime, cmd.StartValue > 0 || cmd.EndValue > 0));
                    fadeTimes.Add(KeyValuePair.Create<double, bool>(cmd.EndTime, cmd.EndValue > 0));
                }

                //always fading out as the last transformation finishes
                fadeTimes.Add(KeyValuePair.Create<double, bool>(commands.OrderBy(c => c.EndTime).LastOrDefault().EndTime,
                                                                false));
            }

            fadeTimes = PurgeDuplicates<bool>(fadeTimes);

            return new SortedDictionary<double, bool>(fadeTimes.ToDictionary(l => l.Key, l => l.Value));
        }

        /// <summary>
        /// Creates an unrealistic representation for the purpose of making fade commands evaluatable
        /// </summary>
        /// <param name="fadeCommands"></param>
        /// <returns></returns>
        private IEnumerable<FadeCommand> Unconflictify(IEnumerable<FadeCommand> fadeCommands)
        {
            List<FadeCommand> list = fadeCommands.ToList();

            foreach (var fade in list)
            {
                var conflicting = list.Where(f => f.EndTime > fade.StartTime && list.IndexOf(f) < list.IndexOf(fade));
                if (conflicting.Count() > 0)
                {
                    /*the fade command always assumes the value of the last concluded command
                     * e.g. if you have 
                     *  F,0,0,1500,0.8,0.3
                     *  F,0,1000,,0
                     * then the sprite will immediately change to an opacity of 0 at 1501
                     * this is why commands that look obsolete like this need to be treated this way
                     */
                    fade.StartTime = conflicting.OrderBy(f => f.EndTime).Last().EndTime;
                    if (fade.EndTime < fade.StartTime)
                        fade.EndTime = fade.StartTime;
                }
            }

            return list;
        }


        //TODO: Check if it actually makes sense to keep this generic and whether this could actually have realistic use cases elsewhere
        /// <summary>
        /// Used to attain a single source of truth for value-states across time that does not contain conflicting commands that crash functions trying to analyse the transformation
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="keyValuePairs"></param>
        /// <returns></returns>
        public List<KeyValuePair<double, T>> PurgeDuplicates<T>(IEnumerable<KeyValuePair<double, T>> keyValuePairs)
        {
            var list = keyValuePairs.ToList();

            foreach (var kv in keyValuePairs)
            {
                //only the last command in line at the same time should stay as that is the effective value remaining
                while (list.Count(k => k.Key == kv.Key) > 1)
                {
                    list.Remove(list.First(k => k.Key == kv.Key));
                }
            }

            return list;
        }
    }
}

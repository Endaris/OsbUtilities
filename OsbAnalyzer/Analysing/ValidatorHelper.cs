using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;
using Contracts.Commands;

namespace OsbValidator.Obsolete
{
    public static class ValidatorHelper
    {
        public static bool ConflictingOrObsolete<T>(this OsbCommand<T> cmd1, OsbCommand<T> cmd2)
        {
            if (cmd1 == null || cmd2 == null)
                return false; //could be equivalent if both are null but if they're null we don't care, so false is correct

            if (cmd1.Identifier == cmd2.Identifier &&
                (cmd1.StartTime == cmd2.StartTime || cmd1.EndTime == cmd1.EndTime))
                return true;
            else
                return false;
        }


        public static Dictionary<double, bool> GetFadeTimes(VisualElement element)
        {
            List<KeyValuePair<double, bool>> fadeTimes = new List<KeyValuePair<double, bool>>();
            if (element.Commands.Select(c => c.Identifier == "F").Count() == 0)
            {
                fadeTimes.Add(KeyValuePair.Create<double, bool>(element.Commands.OrderBy(c => c.StartTime).FirstOrDefault().StartTime, true));
                fadeTimes.Add(KeyValuePair.Create<double, bool>(element.Commands.OrderByDescending(c => c.EndTime).FirstOrDefault().EndTime, false));
            }
            else
            {
                var fadeCommands = element.Commands.Where(c => c.Identifier == "F").Select(c => (FadeCommand)c);

                foreach(var cmd in fadeCommands)
                {
                    fadeTimes.Add(KeyValuePair.Create<double, bool>(cmd.StartTime, cmd.StartValue > 0));
                    fadeTimes.Add(KeyValuePair.Create<double, bool>(cmd.EndTime, cmd.EndValue > 0));
                }
            }

            return fadeTimes.Distinct().ToDictionary(l => l.Key, l => l.Value);
        }

        public static bool IsActiveAt(VisualElement element, double time)
        {
            var fadeTimes = GetFadeTimes(element);
            return fadeTimes.Where(t => t.Key < time).Last().Value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using MapReader.Parsing;

namespace MapReader
{
    internal class VariableResolver
    {
        private Dictionary<string, string> variables = new Dictionary<string, string>();

        public List<string> Resolve(List<string> content)
        {
            ContentReader contentReader = new ContentReader();

            var variableSection = SectionParser.GetSection(content, "[Variables]");
            var eventSection = SectionParser.GetSection(content, "[Events]");

            variableSection.ForEach(line => AddToDictionary(line));

            return ReplaceWithValues(eventSection);
        }

        private void AddToDictionary(string variableAssignment)
        {
            var values = variableAssignment.Split('=');
            if (values.Length == 2)
                variables.Add(values[0], values[1]);
        }

        private List<string> ReplaceWithValues(List<string> eventSection)
        {
            //TODO
            List<string> resolvedSection = new List<string>();
            foreach(var line in eventSection)
            {
                var newLine = line;
                //just a useless runtime optimisation in case there is very heavy variable usage
                if (!line.Contains("$"))
                {
                    resolvedSection.Add(newLine);
                    continue;
                }                  

                foreach (var entry in variables)
                    newLine = newLine.Replace(entry.Key, entry.Value);

                resolvedSection.Add(newLine);
            }

            return resolvedSection;
        }
    }
}

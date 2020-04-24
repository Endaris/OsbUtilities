using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contracts
{
    public class Storyboard
    {
        public string FilePath { get; set; }
        public string OsbVersion { get; set; } = "0";
        public IEnumerable<VisualElement> OsbElements { get; set; } = new List<VisualElement>();

        public string TestString => $@"new {this.GetType().Name}()
{{
    
    OsbElements = new List<VisualElement>()
    {{
        {string.Join(Environment.NewLine + "    ", OsbElements.Select(c => c.TestString.Replace(';', ',')))}
    }},
}};";

        //TODO Storyboarded Sounds
    }
}

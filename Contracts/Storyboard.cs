using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public class Storyboard
    {
        public string FilePath { get; set; }
        public string OsbVersion { get; set; } = "0";
        public IEnumerable<VisualElement> OsbElements { get; set; } = new List<VisualElement>();

        //TODO Storyboarded Sounds
    }
}

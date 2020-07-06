using System;
using System.Collections.Generic;
using System.Text;
using Contracts.Resources;
using Contracts.Gameplay;

namespace Contracts
{
    public class MapSet
    {
        public Storyboard Storyboard { get; set; }
        public IDictionary<string, IResource> Resources { get; set; }
        public IDictionary<string, Beatmap> Difficulties { get; set; }
        public string Path { get; set; }
    }
}

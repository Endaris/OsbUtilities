using System;
using System.Collections.Generic;
using System.Text;
using Contracts;
using Contracts.Resources;
using OsbAnalyser.Contracts;
using OsbAnalyser.Warnings;

namespace OsbAnalyser.Analysing.Elements
{
    public class OffscreenAnalyser : IAnalyser
    {
        private IDictionary<string, IResource> Resources { get; set; }

        public OffscreenAnalyser(IDictionary<string, IResource> Resources)
        {
            this.Resources = Resources;
        }

        public List<StoryboardWarning> Analyse(VisualElement visualElement)
        {
            throw new NotImplementedException();
        }

        public OffscreenWarning GetOffscreenWarning(VisualElement visualElement)
        {
            if (Resources.ContainsKey(visualElement.RelativePath))
            {
                ImageResource imageResource = (ImageResource)Resources[visualElement.RelativePath];
                //TODO
            }
            else
                return null;

            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Contracts;
using Contracts.Resources;

namespace MapReader
{
    public class ResourceReader
    {
        private string MapPath { get; set; }
        public ResourceReader(string mapPath)
        {
            MapPath = mapPath;
        }

        public ImageResource GetResource(VisualElement visualElement)
        {
            return new ImageResource(MapPath, visualElement.RelativePath);
        }
    }
}

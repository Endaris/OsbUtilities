using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Contracts;

namespace MapReader
{
    public class MapReader
    {
        private readonly string Path;

        public MapReader(string MapsetPath)
        {
            Path = MapsetPath;
        }

        public Storyboard GetStoryboard()
        {
            OsbReader osbReader = new OsbReader();
            var content = GetOsbContent();
            var storyboard = osbReader.GetMainStoryboard(content);
            storyboard.FilePath = GetFileName();

            ResourceReader resourceReader = new ResourceReader(Path);
            foreach(var visualElement in storyboard.OsbElements)
            {
                if (!storyboard.Resources.ContainsKey(visualElement.RelativePath))
                    storyboard.Resources.Add(visualElement.RelativePath, resourceReader.GetResource(visualElement));
            }

            return storyboard;
        }

        private string GetFileName()
        {
            return Directory.GetFiles(Path, "*.osb").FirstOrDefault();
        }

        private List<string> GetOsbContent()
        {
            return File.ReadAllLines(System.IO.Path.Combine(Path, GetFileName())).ToList();
        }
    }
}

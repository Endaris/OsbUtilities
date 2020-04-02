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
            return osbReader.GetMainStoryboard(content);
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

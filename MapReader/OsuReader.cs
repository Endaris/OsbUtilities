using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Contracts.Gameplay;
using MapReader.Parsing;

namespace MapReader
{
    //TODO: for reading diff specific storyboards
    public class OsuReader
    {
        public Beatmap GetBeatmap(string diffPath)
        {
            var fileContent = File.ReadLines(diffPath).ToList();
            var osbReader = new OsbReader();
            var storyboard = osbReader.GetDiffStoryboard(fileContent);
            storyboard.FilePath = diffPath;

            var beatmap = new Beatmap()
            {
                Storyboard = storyboard,
            };

            return beatmap;
        }
    }
}

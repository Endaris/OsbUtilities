using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Contracts;
using Contracts.Gameplay;
using Contracts.Resources;

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
            string filename = Directory.GetFiles(Path, "*.osb").FirstOrDefault();
            if (!string.IsNullOrEmpty(filename))
            {
                OsbReader osbReader = new OsbReader();
                var content = File.ReadAllLines(System.IO.Path.Combine(Path, filename)).ToList();
                var storyboard = osbReader.GetMainStoryboard(content);
                storyboard.FilePath = filename;

                return storyboard;                
            }
            else
            {
                return null;
            }            
        }

        public Beatmap GetBeatmap(string difficultyName)
        {
            var osuReader = new OsuReader();
            var diffs = Directory.GetFiles(Path).Where(p => p.EndsWith(".osu") && p.Contains($"[{difficultyName}]"));

            if (diffs.Count() == 0)
            {
                Console.WriteLine($"Couldn't find difficulty with name {difficultyName}");
                return null;
            }
            else
            {
                return osuReader.GetBeatmap(diffs.First());
            }
        }

        private List<string> ignoredExtensions = new List<string>() { ".osu", ".osb" };

        public IDictionary<string, IResource> GetResources()
        {
            return GetResources(new Dictionary<string, IResource>(), Path);
        }

        private IDictionary<string, IResource> GetResources(IDictionary<string, IResource> dic, string directory)
        {
            ResourceReader resourceReader = new ResourceReader(directory);
            foreach (var fsEntry in Directory.EnumerateFileSystemEntries(directory))
            {
                FileAttributes fileAttributes = File.GetAttributes(fsEntry);
                if (fileAttributes.HasFlag(FileAttributes.Directory))
                    dic = GetResources(dic, fsEntry);
                else
                    if (!ignoredExtensions.Contains(System.IO.Path.GetExtension(directory).ToLower()))
                        dic.Add(System.IO.Path.GetRelativePath(Path, fsEntry), resourceReader.GetResource(fsEntry));
            }
            return dic;
        }
    }
}

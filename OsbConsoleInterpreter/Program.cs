using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using OsbAnalyzer.Analysing.Storyboard;

namespace OsbConsoleInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                string path = args[0];

                MapReader.MapReader mapReader = new MapReader.MapReader(path);
                var sb = mapReader.GetStoryboard();
                var analysedSb = new OsbAnalyzer.OsbAnalyzer().Analyse(sb);
                List<string> output = new List<string>();
                analysedSb.AnalysedElements.ToList().ForEach(e => 
                {
                    string warnings = String.Join("\r\n", e.StoryboardWarnings.Where(w => w != null)
                                                                              .OrderByDescending(w => w.WarningLevel)
                                                                              .Select(w => $"Warning Level {(int)w.WarningLevel}: {w.GetType().Name}: {w.ToString()}"));
                    if (!string.IsNullOrWhiteSpace(warnings))
                        output.Add(warnings);
                }
                );

                string targetPath = Path.Combine(path, "SBEvaluation.osba");

                if (File.Exists(targetPath))
                {
                    File.Delete(targetPath);
                }

                File.AppendAllLines(targetPath, output);

                if (analysedSb.StoryboardInfo != null)
                {
                    StoryboardInfoDrawer drawer = new StoryboardInfoDrawer(analysedSb.StoryboardInfo);
                    drawer.DrawSpriteGraph().Save(Path.Combine(path, "spritegraph.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg);
                    drawer.DrawCommandGraph().Save(Path.Combine(path, "commandgraph.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
        }
    }
}

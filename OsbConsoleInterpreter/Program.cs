using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using OsbAnalyser.Analysing.Elements;
using OsbAnalyser.Analysing.Storyboard;
using OsbAnalyser.Contracts;

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
                var resources = mapReader.GetResources();
                var sb = mapReader.GetStoryboard();
                var storyboardInfo = new StoryboardInfo(sb);
                var t = storyboardInfo.GenerateSpriteData();

                List<IAnalyser> Analysers = new List<IAnalyser>()
                {
                    new ConflictAnalyser(),
                    new ProlongedActivityAnalyser(),
                    new FadeOutAnalyser(),
                    new IllogicalAnalyser(),
                    new RedundancyAnalyser(),
                    //new OffscreenAnalyser(resources),
                };
                var osbAnalyser = new OsbAnalyser.StoryboardAnalyser(Analysers);
                var analysedSb = osbAnalyser.Analyse(sb);
                List<string> output = new List<string>();
                analysedSb.AnalysedElements.ToList().ForEach(e => 
                {
                    string elementInfo = $"Element {e.VisualElement.RelativePath} at line {e.VisualElement.Line} with {e.StoryboardWarnings.Count()} warnings:";
                    string warnings = String.Join(Environment.NewLine, e.StoryboardWarnings.Where(w => w != null)
                                                                        .OrderByDescending(w => w.WarningLevel)
                                                                        .Select(w => $"    Warning Level {(int)w.WarningLevel}: {w.GetType().Name}: {w.ToString()}"));
                    if (!string.IsNullOrWhiteSpace(warnings))
                    {
                        output.Add(elementInfo);
                        output.Add(warnings);
                        output.Add(Environment.NewLine);
                    }                       
                }
                );

                string targetPath = Path.Combine(path, "StoryboardWarnings.txt");

                if (File.Exists(targetPath))
                {
                    File.Delete(targetPath);
                }

                File.AppendAllLines(targetPath, output);

                t.Wait();
                StoryboardInfoDrawer drawer = new StoryboardInfoDrawer(storyboardInfo);
                drawer.DrawSpriteGraph().Save(Path.Combine(path, "spritegraph.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg);
                drawer.DrawCommandGraph().Save(Path.Combine(path, "commandgraph.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }
    }
}

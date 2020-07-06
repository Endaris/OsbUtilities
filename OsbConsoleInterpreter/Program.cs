using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Contracts;
using OsbAnalyser.Analysing.Elements;
using OsbAnalyser.Analysing.Storyboard;
using OsbAnalyser.Contracts;
using OsbAnalyzer.Analysing.Elements;
using OsbAnalyzer.Contracts.Warnings;

namespace OsbConsoleInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 1 && Directory.Exists(args[0]))
            {
                string path = args[0];

                MapReader.MapReader mapReader = new MapReader.MapReader(path);
                Storyboard storyboard;

                if (args.Length == 2)
                {
                    var beatmap = mapReader.GetBeatmap(args[1]);
                    storyboard = beatmap.Storyboard;
                }
                else
                {
                    storyboard = mapReader.GetStoryboard();
                }
                
                AnalyseSB(storyboard);
            }
            else
            {
                Console.WriteLine("Invalid arguments. Expecting <Path To Mapfolder> <optional: difficultyname>.");
                Console.WriteLine(@"Sample: OsbConsoleInterpreter.exe ""C:\Program Files\osu!\Songs\527869 Toromaru - Enigma"" for .osb SB");
                Console.WriteLine(@"Sample: OsbConsoleInterpreter.exe ""C:\Program Files\osu!\Songs\527869 Toromaru - Enigma"" ""NOVICE"" for .osu SB");
            }
        }

        private static void AnalyseSB(Storyboard storyboard)
        {
            if (storyboard != null)
            {
                var mapDir = Path.GetDirectoryName(storyboard.FilePath);
                var storyboardInfo = new StoryboardInfo(storyboard);
                var t = storyboardInfo.GenerateSpriteData();

                List<IAnalyser> Analysers = new List<IAnalyser>()
                {
                    new ConflictAnalyser(),
                    new ProlongedActivityAnalyser(),
                    new FadeOutAnalyser(),
                    new IllogicalAnalyser(),
                    new RedundancyAnalyser(),
                    new CommandCountAnalyser(),
                };
                var osbAnalyser = new OsbAnalyser.StoryboardAnalyser(Analysers);
                var analysedSb = osbAnalyser.Analyse(storyboard);
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

                string targetPath = Path.Combine(mapDir, "StoryboardWarnings.txt");

                if (File.Exists(targetPath))
                {
                    File.Delete(targetPath);
                }

                File.AppendAllLines(targetPath, output);

                t.Wait();
                StoryboardInfoDrawer drawer = new StoryboardInfoDrawer(storyboardInfo);
                drawer.DrawSpriteGraph().Save(Path.Combine(mapDir, "spritegraph.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg);
                drawer.DrawCommandGraph().Save(Path.Combine(mapDir, "commandgraph.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            else
            {
                Console.WriteLine("No storyboard found.");
            }
        }
    }
}

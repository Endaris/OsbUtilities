using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using Contracts;
using Contracts.Commands;
using Contracts.Enums;
using OsbAnalyzer.Analysing.Storyboard;
using OsbAnalyzer.Contracts;
using Xunit;

namespace OsbAnalyzer.Test
{
    public class StoryboardInfoTest
    {
        VisualElement visualElement = new VisualElement()
        {
            Layer = OsbLayer.Background,
            Anchor = OsbOrigin.Centre,
            Line = 5878,
            InitialPosition = new CommandPosition(0, 0),
            zIndex = 0,
            RelativePath = @"sb\l.png",
            Commands = new List<IOsbCommand>()
                {
                    new FadeCommand()
                    {
                        Identifier = "F",
                        Easing =  OsbEasing.None,
                        StartTime = 244823,
                        EndTime = 250892,
                        StartValue = 1,
                        EndValue = 0,
                        Line = 5879,
                    },
                    new LoopCommand()
                    {
                        Identifier = "L",
                        StartTime = 283852,
                        Line = 5880,
                        LoopCount = 2,
                        OsbCommands = new List<IOsbSpriteCommand>()
                        {
                            new MoveYCommand()
                            {
                                Identifier = "MY",
                                Easing = OsbEasing.None,
                                StartTime = 0,
                                EndTime = 17594,
                                StartValue = 188,
                                EndValue = -100,
                                Line = 5881,
                            },
                                new MoveYCommand()
                            {
                                Identifier = "MY",
                                Easing = OsbEasing.None,
                                StartTime = 17594,
                                EndTime = 36654,
                                StartValue = 500,
                                EndValue = 188,
                                Line = 5882,
                            },
                        },
                    },
                    new LoopCommand()
                    {
                        Identifier = "L",
                        StartTime = 283852,
                        Line = 5880,
                        LoopCount = 2,
                        OsbCommands = new List<IOsbSpriteCommand>()
                        {
                            new MoveXCommand()
                            {
                                Identifier = "MX",
                                Easing = OsbEasing.Out,
                                StartTime = 0,
                                EndTime = 7675,
                                StartValue = 159,
                                EndValue = 109,
                                Line = 5881,
                            },
                                new MoveXCommand()
                            {
                                Identifier = "MX",
                                Easing = OsbEasing.In,
                                StartTime = 7675,
                                EndTime = 15351,
                                StartValue = 109,
                                EndValue = 159,
                                Line = 5882,
                            },
                                new MoveXCommand()
                            {
                                Identifier = "MX",
                                Easing = OsbEasing.Out,
                                StartTime = 15351,
                                EndTime = 23027,
                                StartValue = 159,
                                EndValue = 209,
                                Line = 5883,
                            },
                                new MoveXCommand()
                            {
                                Identifier = "MX",
                                Easing = OsbEasing.In,
                                StartTime = 23027,
                                EndTime = 30702,
                                StartValue = 209,
                                EndValue = 159,
                                Line = 5884,
                            },
                        },
                    },
                    new LoopCommand()
                    {
                        Identifier = "L",
                        StartTime = 283943,
                        Line = 5880,
                        LoopCount = 5,
                        OsbCommands = new List<IOsbSpriteCommand>()
                        {
                            new FadeCommand()
                            {
                                Identifier = "F",
                                Easing = OsbEasing.None,
                                StartTime = 0,
                                EndTime = 4357,
                                StartValue = 0.15,
                                EndValue = 0.5,
                                Line = 5881,
                            },
                                new ScaleCommand()
                            {
                                Identifier = "S",
                                Easing = OsbEasing.None,
                                StartTime = 0,
                                EndTime = 4357,
                                StartValue = 0.02045512,
                                EndValue = 0.02659166,
                                Line = 5882,
                            },
                                new FadeCommand()
                            {
                                Identifier = "F",
                                Easing = OsbEasing.None,
                                StartTime = 4357,
                                EndTime = 8715,
                                StartValue = 0.5,
                                EndValue = 0.15,
                                Line = 5883,
                            },
                                new ScaleCommand()
                            {
                                Identifier = "S",
                                Easing = OsbEasing.None,
                                StartTime = 4357,
                                EndTime = 8715,
                                StartValue = 0.02659166,
                                EndValue = 0.02045512,
                                Line = 5884,
                            },
                        },
                    },
                    new ParameterCommand()
                    {
                        Identifier = "P",
                        Easing = OsbEasing.None,
                        StartTime = 280095,
                        EndTime = 337488,
                        StartValue =  ParameterType.AdditiveBlending,
                        EndValue =  ParameterType.AdditiveBlending,
                        Line = 5894,
                    },
                    new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.In,
                        StartTime = 280277,
                        EndTime = 283943,
                        StartValue = 0,
                        EndValue = 0.15,
                        Line = 5895,
                    },
                    new ColorCommand()
                    {
                        Identifier = "C",
                        Easing = OsbEasing.In,
                        StartTime = 283943,
                        EndTime = 287608,
                        StartValue = new CommandColor(0,0,0),
                        EndValue = new CommandColor(87,87,43),
                        Line = 5896,
                    },
                    new ColorCommand()
                    {
                        Identifier = "C",
                        Easing = OsbEasing.None,
                        StartTime = 287608,
                        EndTime = 312735,
                        StartValue = new CommandColor(87,87,43),
                        EndValue = new CommandColor(108,65,32),
                        Line = 5897,
                    },
                    new ColorCommand()
                    {
                        Identifier = "C",
                        Easing = OsbEasing.Out,
                        StartTime = 312735,
                        EndTime = 327397,
                        StartValue = new CommandColor(108,65,32),
                        EndValue = new CommandColor(0,0,0),
                        Line = 5898,
                    },
                    new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 327488,
                        EndTime = 327488,
                        StartValue = 0,
                        EndValue = 0,
                        Line = 5899,
                    },
                    new ScaleCommand()
                    {
                        Identifier = "S",
                        Easing = OsbEasing.None,
                        StartTime = 327488,
                        EndTime = 327488,
                        StartValue = 0,
                        EndValue = 0,
                        Line = 5900,
                    },
                    new ColorCommand()
                    {
                        Identifier = "C",
                        Easing = OsbEasing.None,
                        StartTime = 327488,
                        EndTime = 327488,
                        StartValue = new CommandColor(0,0,0),
                        EndValue = new CommandColor(0,0,0),
                        Line = 5901,
                    },
                },
        };

        [Fact]
        public void ConstructTest1()
        {
            Storyboard storyboard = new Storyboard() { OsbElements = new List<VisualElement>() { visualElement } };

            StoryboardInfo storyboardInfo = new StoryboardInfo(storyboard);

            Assert.True(storyboardInfo.ActiveSpriteData.Count(d => d.Key < 50000) == 0);
            Assert.True(storyboardInfo.ActiveSpriteData.Count(d => 270000 < d.Key && d.Key <= 270016) == 1);
            Assert.True(storyboardInfo.VisibleSpriteData.First(d => 270000 < d.Key && d.Key <= 270016).Value == 0);
            Assert.True(storyboardInfo.VisibleSpriteData.First(d => 247000 < d.Key && d.Key <= 247016).Value == 1);
            Assert.True(storyboardInfo.ActiveCommandData.Count(d => d.Key < 50000) == 0);
            Assert.True(storyboardInfo.ActiveCommandData.Count(d => 270000 < d.Key && d.Key <= 270016) == 1);
            Assert.True(storyboardInfo.VisibleCommandData.First(d => 270000 < d.Key && d.Key <= 270016).Value == 0);
            Assert.True(storyboardInfo.VisibleCommandData.Count(d => 247000 < d.Key && d.Key <= 247016) == 1);
            Assert.True(storyboardInfo.ActiveCommandData.First(d => 247000 < d.Key && d.Key <= 247016).Value == 12);
            Assert.True(storyboardInfo.VisibleCommandData.First(d => 247000 < d.Key && d.Key <= 247016).Value == 12);
            Assert.True(storyboardInfo.VisibleCommandData.First(d => 270000 < d.Key && d.Key <= 270016).Value == 0);

        }

        [Fact]
        public void ConstructTest2()
        {
            StoryboardInfo storyboardInfo = new StoryboardInfo(SampleStoryboards.SummerWars);

            Assert.True(storyboardInfo.ActiveSpriteData.First(d => 1444 < d.Key && d.Key <= 1460).Value == 6);
        }

        [Fact]
        public void InfoDrawerTest1()
        {
            StoryboardInfo storyboardInfo = new StoryboardInfo(SampleStoryboards.SummerWars);

            StoryboardInfoDrawer drawer = new StoryboardInfoDrawer(storyboardInfo);
            var bitmap = drawer.DrawSpriteGraph();
            bitmap.Save("spritegraph.jpg", ImageFormat.Jpeg);
        }
    }
}

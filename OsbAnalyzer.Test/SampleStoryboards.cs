using System;
using System.Collections.Generic;
using System.Text;
using Contracts;
using Contracts.Enums;
using Contracts.Commands;

namespace OsbAnalyser.Test
{
    public class SampleStoryboards
    {
        public static Storyboard SummerWars { get; } = new Storyboard()
        {

            OsbElements = new List<VisualElement>()
    {
        new VisualElement()
{
    Layer = OsbLayer.Background,
    Anchor = OsbOrigin.Centre,
    Line = 4,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Night.jpg",
    Commands = new List<IOsbCommand>()
    {
        new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 1444,
    EndTime = 12738,
    StartValue = 0,
    EndValue = 1,
    Line = 5,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 1444,
    EndTime = 35326,
    StartValue = new CommandPosition(421,250),
    EndValue = new CommandPosition(190,218),
    Line = 6,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 1444,
    EndTime = 35326,
    StartValue = 0.8454911,
    EndValue = 0.9909111,
    Line = 7,
},
    new RotateCommand()
{
    Identifier = "R",
    Easing = OsbEasing.None,
    StartTime = 1444,
    EndTime = 35679,
    StartValue = 0,
    EndValue = 0.1979119,
    Line = 8,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 12738,
    EndTime = 25973,
    StartValue = 1,
    EndValue = 1,
    Line = 9,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 25973,
    EndTime = 35326,
    StartValue = 1,
    EndValue = 1,
    Line = 10,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 35326,
    EndTime = 35679,
    StartValue = new CommandPosition(190,218),
    EndValue = new CommandPosition(317,262),
    Line = 11,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 35326,
    EndTime = 35679,
    StartValue = 1,
    EndValue = 0,
    Line = 12,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 35326,
    EndTime = 35679,
    StartValue = 0.9909111,
    EndValue = 1.272663,
    Line = 13,
},
    new RotateCommand()
{
    Identifier = "R",
    Easing = OsbEasing.None,
    StartTime = 35679,
    EndTime = 35679,
    StartValue = 0.1979119,
    EndValue = 0.1979119,
    Line = 14,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Background,
    Anchor = OsbOrigin.Centre,
    Line = 15,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Second.png",
    Commands = new List<IOsbCommand>()
    {
        new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 1444,
    EndTime = 12385,
    StartValue = 0,
    EndValue = 0,
    Line = 16,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 1444,
    EndTime = 22439,
    StartValue = new CommandPosition(421,250),
    EndValue = new CommandPosition(277,230),
    Line = 17,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 1444,
    EndTime = 35326,
    StartValue = 0.8454911,
    EndValue = 0.9909111,
    Line = 18,
},
    new RotateCommand()
{
    Identifier = "R",
    Easing = OsbEasing.None,
    StartTime = 1444,
    EndTime = 35679,
    StartValue = 0,
    EndValue = 0.1979119,
    Line = 19,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 12385,
    EndTime = 12738,
    StartValue = 0,
    EndValue = 1,
    Line = 20,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 12738,
    EndTime = 13091,
    StartValue = 1,
    EndValue = 0,
    Line = 21,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 13091,
    EndTime = 22439,
    StartValue = 0,
    EndValue = 0,
    Line = 22,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 22439,
    EndTime = 23679,
    StartValue = 0,
    EndValue = 0,
    Line = 23,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 22439,
    EndTime = 35326,
    StartValue = new CommandPosition(277,230),
    EndValue = new CommandPosition(190,218),
    Line = 24,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 23679,
    EndTime = 24032,
    StartValue = 0,
    EndValue = 1,
    Line = 25,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 24032,
    EndTime = 24738,
    StartValue = 1,
    EndValue = 0,
    Line = 26,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 24738,
    EndTime = 35326,
    StartValue = 0,
    EndValue = 1,
    Line = 27,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 35326,
    EndTime = 35679,
    StartValue = new CommandPosition(190,218),
    EndValue = new CommandPosition(317,262),
    Line = 28,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 35326,
    EndTime = 35679,
    StartValue = 1,
    EndValue = 0,
    Line = 29,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 35326,
    EndTime = 35679,
    StartValue = 0.9909111,
    EndValue = 1.272663,
    Line = 30,
},
    new RotateCommand()
{
    Identifier = "R",
    Easing = OsbEasing.None,
    StartTime = 35679,
    EndTime = 35679,
    StartValue = 0.1979119,
    EndValue = 0.1979119,
    Line = 31,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 35,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Little Light.png",
    Commands = new List<IOsbCommand>()
    {
        new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 12738,
    EndTime = 12826,
    StartValue = 0,
    EndValue = 0.8751773,
    Line = 36,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 12738,
    EndTime = 13443,
    StartValue = new CommandPosition(419,190),
    EndValue = new CommandPosition(200,360),
    Line = 37,
},
    new RotateCommand()
{
    Identifier = "R",
    Easing = OsbEasing.None,
    StartTime = 12738,
    EndTime = 13443,
    StartValue = 0.127243,
    EndValue = 0.127243,
    Line = 38,
},
    new VectorScaleCommand()
{
    Identifier = "V",
    Easing = OsbEasing.None,
    StartTime = 12738,
    EndTime = 13443,
    StartValue = new CommandScale(0.1,0.1),
    EndValue = new CommandScale(1.090674,1.027053),
    Line = 39,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 12826,
    EndTime = 13443,
    StartValue = 0.8751773,
    EndValue = 0,
    Line = 40,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 15561,
    EndTime = 15649,
    StartValue = 0,
    EndValue = 0.8751773,
    Line = 41,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 15561,
    EndTime = 16266,
    StartValue = new CommandPosition(282,89),
    EndValue = new CommandPosition(96,252),
    Line = 42,
},
    new RotateCommand()
{
    Identifier = "R",
    Easing = OsbEasing.None,
    StartTime = 15561,
    EndTime = 16266,
    StartValue = 0.127243,
    EndValue = 0.127243,
    Line = 43,
},
    new VectorScaleCommand()
{
    Identifier = "V",
    Easing = OsbEasing.None,
    StartTime = 15561,
    EndTime = 16267,
    StartValue = new CommandScale(0.1,0.1638342),
    EndValue = new CommandScale(0.8998108,0.8543669),
    Line = 44,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 15649,
    EndTime = 16266,
    StartValue = 0.8751773,
    EndValue = 0,
    Line = 45,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 18385,
    EndTime = 18473,
    StartValue = 0,
    EndValue = 0.8751773,
    Line = 46,
},
    new RotateCommand()
{
    Identifier = "R",
    Easing = OsbEasing.None,
    StartTime = 18385,
    EndTime = 19090,
    StartValue = 0.127243,
    EndValue = 0.127243,
    Line = 47,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 18385,
    EndTime = 19091,
    StartValue = new CommandPosition(553,76),
    EndValue = new CommandPosition(320,215),
    Line = 48,
},
    new VectorScaleCommand()
{
    Identifier = "V",
    Easing = OsbEasing.None,
    StartTime = 18385,
    EndTime = 19091,
    StartValue = new CommandScale(0.1,0.1),
    EndValue = new CommandScale(1,1),
    Line = 49,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 18473,
    EndTime = 19090,
    StartValue = 0.8751773,
    EndValue = 0,
    Line = 50,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 21208,
    EndTime = 21296,
    StartValue = 0,
    EndValue = 0.8751773,
    Line = 51,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 21208,
    EndTime = 21913,
    StartValue = new CommandPosition(227,80),
    EndValue = new CommandPosition(70,211),
    Line = 52,
},
    new RotateCommand()
{
    Identifier = "R",
    Easing = OsbEasing.None,
    StartTime = 21208,
    EndTime = 21913,
    StartValue = 0.127243,
    EndValue = 0.127243,
    Line = 53,
},
    new VectorScaleCommand()
{
    Identifier = "V",
    Easing = OsbEasing.None,
    StartTime = 21208,
    EndTime = 21914,
    StartValue = new CommandScale(0.1,0.1),
    EndValue = new CommandScale(1,1),
    Line = 54,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 21296,
    EndTime = 21913,
    StartValue = 0.8751773,
    EndValue = 0,
    Line = 55,
},
    new ColorCommand()
{
    Identifier = "C",
    Easing = OsbEasing.None,
    StartTime = 24032,
    EndTime = 24032,
    StartValue = new CommandColor(128,255,255),
    EndValue = new CommandColor(128,255,255),
    Line = 56,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 24032,
    EndTime = 24120,
    StartValue = 0,
    EndValue = 0.8751773,
    Line = 57,
},
    new RotateCommand()
{
    Identifier = "R",
    Easing = OsbEasing.None,
    StartTime = 24032,
    EndTime = 24737,
    StartValue = 0.127243,
    EndValue = 0.127243,
    Line = 58,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 24032,
    EndTime = 24738,
    StartValue = new CommandPosition(553,76),
    EndValue = new CommandPosition(320,215),
    Line = 59,
},
    new VectorScaleCommand()
{
    Identifier = "V",
    Easing = OsbEasing.None,
    StartTime = 24032,
    EndTime = 24738,
    StartValue = new CommandScale(0.1,0.1),
    EndValue = new CommandScale(1,1),
    Line = 60,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 24120,
    EndTime = 24737,
    StartValue = 0.8751773,
    EndValue = 0,
    Line = 61,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 26855,
    EndTime = 26943,
    StartValue = 0,
    EndValue = 0.8751773,
    Line = 62,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 26855,
    EndTime = 27560,
    StartValue = new CommandPosition(419,190),
    EndValue = new CommandPosition(200,360),
    Line = 63,
},
    new RotateCommand()
{
    Identifier = "R",
    Easing = OsbEasing.None,
    StartTime = 26855,
    EndTime = 27560,
    StartValue = 0.127243,
    EndValue = 0.127243,
    Line = 64,
},
    new VectorScaleCommand()
{
    Identifier = "V",
    Easing = OsbEasing.None,
    StartTime = 26855,
    EndTime = 27560,
    StartValue = new CommandScale(0.1,0.1),
    EndValue = new CommandScale(1.090674,1.027053),
    Line = 65,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 26943,
    EndTime = 27560,
    StartValue = 0.8751773,
    EndValue = 0,
    Line = 66,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 29679,
    EndTime = 29767,
    StartValue = 0,
    EndValue = 0.8751773,
    Line = 67,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 29679,
    EndTime = 30384,
    StartValue = new CommandPosition(227,80),
    EndValue = new CommandPosition(70,211),
    Line = 68,
},
    new RotateCommand()
{
    Identifier = "R",
    Easing = OsbEasing.None,
    StartTime = 29679,
    EndTime = 30384,
    StartValue = 0.127243,
    EndValue = 0.127243,
    Line = 69,
},
    new VectorScaleCommand()
{
    Identifier = "V",
    Easing = OsbEasing.None,
    StartTime = 29679,
    EndTime = 30385,
    StartValue = new CommandScale(0.1,0.1),
    EndValue = new CommandScale(1,1),
    Line = 70,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 29767,
    EndTime = 30384,
    StartValue = 0.8751773,
    EndValue = 0,
    Line = 71,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 72,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\rhythms.png",
    Commands = new List<IOsbCommand>()
    {
        new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 36032,
    EndTime = 36208,
    StartValue = new CommandPosition(536,309),
    EndValue = new CommandPosition(293,311),
    Line = 73,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 36032,
    EndTime = 36208,
    StartValue = 0,
    EndValue = 1,
    Line = 74,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 36032,
    EndTime = 36208,
    StartValue = 1,
    EndValue = 0.8273135,
    Line = 75,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 36208,
    EndTime = 39914,
    StartValue = new CommandPosition(293,311),
    EndValue = new CommandPosition(393,310),
    Line = 76,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 36208,
    EndTime = 40267,
    StartValue = 1,
    EndValue = 1,
    Line = 77,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 39914,
    EndTime = 40091,
    StartValue = new CommandPosition(393,310),
    EndValue = new CommandPosition(843,307),
    Line = 78,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 79,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\smm.png",
    Commands = new List<IOsbCommand>()
    {
        new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 36208,
    EndTime = 36385,
    StartValue = new CommandPosition(891,361),
    EndValue = new CommandPosition(481,359),
    Line = 80,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 36385,
    EndTime = 36385,
    StartValue = 1,
    EndValue = 1,
    Line = 81,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 36385,
    EndTime = 40091,
    StartValue = new CommandPosition(481,359),
    EndValue = new CommandPosition(609,359),
    Line = 82,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 40091,
    EndTime = 40267,
    StartValue = new CommandPosition(609,359),
    EndValue = new CommandPosition(869,363),
    Line = 83,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 84,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\1.png",
    Commands = new List<IOsbCommand>()
    {
        new RotateCommand()
{
    Identifier = "R",
    Easing = OsbEasing.None,
    StartTime = 43267,
    EndTime = 43267,
    StartValue = 0,
    EndValue = 0,
    Line = 85,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 43267,
    EndTime = 43428,
    StartValue = new CommandPosition(-98,130),
    EndValue = new CommandPosition(289,133),
    Line = 86,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 43428,
    EndTime = 44663,
    StartValue = new CommandPosition(289,133),
    EndValue = new CommandPosition(277,133),
    Line = 87,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 43973,
    EndTime = 44679,
    StartValue = 1,
    EndValue = 0,
    Line = 88,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 89,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\1.png",
    Commands = new List<IOsbCommand>()
    {
        new RotateCommand()
{
    Identifier = "R",
    Easing = OsbEasing.None,
    StartTime = 44502,
    EndTime = 44502,
    StartValue = 0,
    EndValue = 0,
    Line = 90,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 44502,
    EndTime = 44663,
    StartValue = new CommandPosition(-98,130),
    EndValue = new CommandPosition(289,133),
    Line = 91,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 44663,
    EndTime = 45898,
    StartValue = new CommandPosition(289,133),
    EndValue = new CommandPosition(277,133),
    Line = 92,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 45208,
    EndTime = 45914,
    StartValue = 1,
    EndValue = 0,
    Line = 93,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 94,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\1.png",
    Commands = new List<IOsbCommand>()
    {
        new RotateCommand()
{
    Identifier = "R",
    Easing = OsbEasing.None,
    StartTime = 40443,
    EndTime = 40443,
    StartValue = 0,
    EndValue = 0,
    Line = 95,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 40443,
    EndTime = 40604,
    StartValue = new CommandPosition(-98,130),
    EndValue = new CommandPosition(289,133),
    Line = 96,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 40604,
    EndTime = 41839,
    StartValue = new CommandPosition(289,133),
    EndValue = new CommandPosition(277,133),
    Line = 97,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 41149,
    EndTime = 41855,
    StartValue = 1,
    EndValue = 0,
    Line = 98,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 99,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\light.png",
    Commands = new List<IOsbCommand>()
    {
        new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 35679,
    EndTime = 35679,
    StartValue = new CommandPosition(531,157),
    EndValue = new CommandPosition(531,157),
    Line = 100,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 35679,
    EndTime = 35679,
    StartValue = 2.299693,
    EndValue = 2.299693,
    Line = 101,
},
    new ColorCommand()
{
    Identifier = "C",
    Easing = OsbEasing.None,
    StartTime = 35679,
    EndTime = 35679,
    StartValue = new CommandColor(0,0,0),
    EndValue = new CommandColor(0,0,0),
    Line = 102,
},
    new RotateCommand()
{
    Identifier = "R",
    Easing = OsbEasing.None,
    StartTime = 35679,
    EndTime = 45914,
    StartValue = 0,
    EndValue = -17.52312,
    Line = 103,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 104,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Light3.png",
    Commands = new List<IOsbCommand>()
    {
        new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 36738,
    EndTime = 36738,
    StartValue = new CommandPosition(308,319),
    EndValue = new CommandPosition(308,319),
    Line = 105,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 36738,
    EndTime = 36738,
    StartValue = 0.7182486,
    EndValue = 0.7182486,
    Line = 106,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 36738,
    EndTime = 37443,
    StartValue = 1,
    EndValue = 0,
    Line = 107,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 108,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Light3.png",
    Commands = new List<IOsbCommand>()
    {
        new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 37443,
    EndTime = 38148,
    StartValue = 1,
    EndValue = 0,
    Line = 109,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 37443,
    EndTime = 38149,
    StartValue = new CommandPosition(413,372),
    EndValue = new CommandPosition(440,368),
    Line = 110,
},
    new VectorScaleCommand()
{
    Identifier = "V",
    Easing = OsbEasing.In,
    StartTime = 37443,
    EndTime = 38149,
    StartValue = new CommandScale(0.4910294,0.5728289),
    EndValue = new CommandScale(0.4637634,0.4637637),
    Line = 111,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 112,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Flash2.png",
    Commands = new List<IOsbCommand>()
    {
        new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 40973,
    EndTime = 40973,
    StartValue = new CommandPosition(320,240),
    EndValue = new CommandPosition(320,240),
    Line = 113,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 40973,
    EndTime = 41679,
    StartValue = 0.5182958,
    EndValue = 0,
    Line = 114,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 40973,
    EndTime = 41679,
    StartValue = 1,
    EndValue = 1.427172,
    Line = 115,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 116,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Flash2.png",
    Commands = new List<IOsbCommand>()
    {
        new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 42385,
    EndTime = 42385,
    StartValue = new CommandPosition(320,240),
    EndValue = new CommandPosition(320,240),
    Line = 117,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 42385,
    EndTime = 43091,
    StartValue = 0.5182958,
    EndValue = 0,
    Line = 118,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 42385,
    EndTime = 43091,
    StartValue = 1,
    EndValue = 1.427172,
    Line = 119,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 120,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Flash2.png",
    Commands = new List<IOsbCommand>()
    {
        new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 44502,
    EndTime = 44502,
    StartValue = new CommandPosition(320,240),
    EndValue = new CommandPosition(320,240),
    Line = 121,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 44502,
    EndTime = 45208,
    StartValue = 0.5182958,
    EndValue = 0,
    Line = 122,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 44502,
    EndTime = 45208,
    StartValue = 1,
    EndValue = 1.427172,
    Line = 123,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 124,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Guys.png",
    Commands = new List<IOsbCommand>()
    {
        new LoopCommand()
{
    Identifier = "L",
    StartTime = 0,
    Line = 124,
    LoopCount = 1,
    OsbCommands = new List<IOsbSpriteCommand>()
    {
        new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 52620,
    EndTime = 53326,
    StartValue = 0.6,
    EndValue = 0,
    Line = 125,
},
    },
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 52620,
    EndTime = 52620,
    StartValue = 0.8,
    EndValue = 0.8,
    Line = 127,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 128,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Kiss.jpg",
    Commands = new List<IOsbCommand>()
    {
        new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 69208,
    EndTime = 69914,
    StartValue = 0,
    EndValue = 1,
    Line = 129,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 69208,
    EndTime = 80502,
    StartValue = new CommandPosition(476,235),
    EndValue = new CommandPosition(366,234),
    Line = 130,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 69208,
    EndTime = 80502,
    StartValue = 1.115613,
    EndValue = 1.132,
    Line = 131,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 69914,
    EndTime = 90385,
    StartValue = 1,
    EndValue = 1,
    Line = 132,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 80502,
    EndTime = 80591,
    StartValue = new CommandPosition(366,234),
    EndValue = new CommandPosition(291,234),
    Line = 133,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 80502,
    EndTime = 80591,
    StartValue = 1.132,
    EndValue = 1.256,
    Line = 134,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 80591,
    EndTime = 91796,
    StartValue = new CommandPosition(291,234),
    EndValue = new CommandPosition(148,235),
    Line = 135,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 90385,
    EndTime = 91796,
    StartValue = 1,
    EndValue = 0,
    Line = 136,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 137,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\moon.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 69208,
    EndTime = 69208,
    StartValue = 0.4384516,
    EndValue = 0.4384516,
    Line = 138,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 69208,
    EndTime = 69914,
    StartValue = 0,
    EndValue = 0.5003871,
    Line = 139,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 69208,
    EndTime = 80502,
    StartValue = new CommandPosition(114,169),
    EndValue = new CommandPosition(338,125),
    Line = 140,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 69914,
    EndTime = 80502,
    StartValue = 0.5003871,
    EndValue = 0.5003871,
    Line = 141,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 80502,
    EndTime = 80591,
    StartValue = new CommandPosition(338,125),
    EndValue = new CommandPosition(425,91),
    Line = 142,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 80502,
    EndTime = 90385,
    StartValue = 0.5003871,
    EndValue = 0.5003871,
    Line = 143,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 80591,
    EndTime = 91796,
    StartValue = new CommandPosition(425,91),
    EndValue = new CommandPosition(563,80),
    Line = 144,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 90385,
    EndTime = 91796,
    StartValue = 0.5003871,
    EndValue = 0,
    Line = 145,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 146,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Another.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 70620,
    EndTime = 70620,
    StartValue = 0.1,
    EndValue = 0.1,
    Line = 147,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 70620,
    EndTime = 70973,
    StartValue = 0,
    EndValue = 1,
    Line = 148,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 70620,
    EndTime = 72032,
    StartValue = new CommandPosition(147,451),
    EndValue = new CommandPosition(173,365),
    Line = 149,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 70973,
    EndTime = 71502,
    StartValue = 1,
    EndValue = 1,
    Line = 150,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 71502,
    EndTime = 72032,
    StartValue = 1,
    EndValue = 0,
    Line = 151,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 152,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Another.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 70973,
    EndTime = 70973,
    StartValue = 0.1,
    EndValue = 0.1,
    Line = 153,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 70973,
    EndTime = 71326,
    StartValue = 0,
    EndValue = 1,
    Line = 154,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 70973,
    EndTime = 72385,
    StartValue = new CommandPosition(244,455),
    EndValue = new CommandPosition(309,370),
    Line = 155,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 71326,
    EndTime = 71855,
    StartValue = 1,
    EndValue = 1,
    Line = 156,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 71855,
    EndTime = 72385,
    StartValue = 1,
    EndValue = 0,
    Line = 157,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 158,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Another.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 72208,
    EndTime = 72208,
    StartValue = 0.1,
    EndValue = 0.1,
    Line = 159,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 72208,
    EndTime = 72561,
    StartValue = 0,
    EndValue = 1,
    Line = 160,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 72208,
    EndTime = 73620,
    StartValue = new CommandPosition(147,451),
    EndValue = new CommandPosition(173,365),
    Line = 161,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 72561,
    EndTime = 73090,
    StartValue = 1,
    EndValue = 1,
    Line = 162,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 73090,
    EndTime = 73620,
    StartValue = 1,
    EndValue = 0,
    Line = 163,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 164,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Another.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 71502,
    EndTime = 71502,
    StartValue = 0.1,
    EndValue = 0.1,
    Line = 165,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 71502,
    EndTime = 71855,
    StartValue = 0,
    EndValue = 1,
    Line = 166,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 71502,
    EndTime = 72914,
    StartValue = new CommandPosition(32,424),
    EndValue = new CommandPosition(134,323),
    Line = 167,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 71855,
    EndTime = 72384,
    StartValue = 1,
    EndValue = 1,
    Line = 168,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 72384,
    EndTime = 72914,
    StartValue = 1,
    EndValue = 0,
    Line = 169,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 170,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Another.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 75120,
    EndTime = 75120,
    StartValue = 0.1,
    EndValue = 0.1,
    Line = 171,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 75120,
    EndTime = 75473,
    StartValue = 0,
    EndValue = 1,
    Line = 172,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 75120,
    EndTime = 76532,
    StartValue = new CommandPosition(147,451),
    EndValue = new CommandPosition(173,365),
    Line = 173,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 75473,
    EndTime = 76002,
    StartValue = 1,
    EndValue = 1,
    Line = 174,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 76002,
    EndTime = 76532,
    StartValue = 1,
    EndValue = 0,
    Line = 175,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 176,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Another.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 73355,
    EndTime = 73355,
    StartValue = 0.1,
    EndValue = 0.1,
    Line = 177,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 73355,
    EndTime = 73708,
    StartValue = 0,
    EndValue = 1,
    Line = 178,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 73355,
    EndTime = 74767,
    StartValue = new CommandPosition(355,453),
    EndValue = new CommandPosition(273,349),
    Line = 179,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 73708,
    EndTime = 74237,
    StartValue = 1,
    EndValue = 1,
    Line = 180,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 74237,
    EndTime = 74767,
    StartValue = 1,
    EndValue = 0,
    Line = 181,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 182,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Another.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 76179,
    EndTime = 76179,
    StartValue = 0.1,
    EndValue = 0.1,
    Line = 183,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 76179,
    EndTime = 76532,
    StartValue = 0,
    EndValue = 1,
    Line = 184,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 76179,
    EndTime = 77591,
    StartValue = new CommandPosition(407,453),
    EndValue = new CommandPosition(426,376),
    Line = 185,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 76532,
    EndTime = 77061,
    StartValue = 1,
    EndValue = 1,
    Line = 186,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 77061,
    EndTime = 77591,
    StartValue = 1,
    EndValue = 0,
    Line = 187,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 188,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Another.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 76750,
    EndTime = 76750,
    StartValue = 0.1,
    EndValue = 0.1,
    Line = 189,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 76750,
    EndTime = 77103,
    StartValue = 0,
    EndValue = 1,
    Line = 190,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 76750,
    EndTime = 78162,
    StartValue = new CommandPosition(517,456),
    EndValue = new CommandPosition(523,328),
    Line = 191,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 77103,
    EndTime = 77632,
    StartValue = 1,
    EndValue = 1,
    Line = 192,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 77632,
    EndTime = 78162,
    StartValue = 1,
    EndValue = 0,
    Line = 193,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 194,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Another.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 77679,
    EndTime = 77679,
    StartValue = 0.1,
    EndValue = 0.1,
    Line = 195,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 77679,
    EndTime = 78032,
    StartValue = 0,
    EndValue = 1,
    Line = 196,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 77679,
    EndTime = 79091,
    StartValue = new CommandPosition(374,450),
    EndValue = new CommandPosition(334,277),
    Line = 197,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 78032,
    EndTime = 78561,
    StartValue = 1,
    EndValue = 1,
    Line = 198,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 78561,
    EndTime = 79091,
    StartValue = 1,
    EndValue = 0,
    Line = 199,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 200,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Another.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 78738,
    EndTime = 78738,
    StartValue = 0.1,
    EndValue = 0.1,
    Line = 201,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 78738,
    EndTime = 79091,
    StartValue = 0,
    EndValue = 1,
    Line = 202,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 78738,
    EndTime = 80149,
    StartValue = new CommandPosition(597,448),
    EndValue = new CommandPosition(553,262),
    Line = 203,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 79091,
    EndTime = 79620,
    StartValue = 1,
    EndValue = 1,
    Line = 204,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 79620,
    EndTime = 80150,
    StartValue = 1,
    EndValue = 0,
    Line = 205,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 80149,
    EndTime = 80150,
    StartValue = new CommandPosition(553,262),
    EndValue = new CommandPosition(600,327),
    Line = 206,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 207,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Another.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 79796,
    EndTime = 79796,
    StartValue = 0.1,
    EndValue = 0.1,
    Line = 208,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 79796,
    EndTime = 80149,
    StartValue = 0,
    EndValue = 1,
    Line = 209,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 79796,
    EndTime = 81208,
    StartValue = new CommandPosition(82,436),
    EndValue = new CommandPosition(63,286),
    Line = 210,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 80149,
    EndTime = 80678,
    StartValue = 1,
    EndValue = 1,
    Line = 211,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 80678,
    EndTime = 81208,
    StartValue = 1,
    EndValue = 0,
    Line = 212,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 213,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Another.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 80149,
    EndTime = 80149,
    StartValue = 0.1,
    EndValue = 0.1,
    Line = 214,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 80149,
    EndTime = 80502,
    StartValue = 0,
    EndValue = 1,
    Line = 215,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 80149,
    EndTime = 81561,
    StartValue = new CommandPosition(147,451),
    EndValue = new CommandPosition(173,365),
    Line = 216,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 80502,
    EndTime = 81031,
    StartValue = 1,
    EndValue = 1,
    Line = 217,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 81031,
    EndTime = 81561,
    StartValue = 1,
    EndValue = 0,
    Line = 218,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 219,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Another.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 80287,
    EndTime = 80287,
    StartValue = 0.1,
    EndValue = 0.1,
    Line = 220,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 80287,
    EndTime = 80640,
    StartValue = 0,
    EndValue = 1,
    Line = 221,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 80287,
    EndTime = 81699,
    StartValue = new CommandPosition(327,451),
    EndValue = new CommandPosition(319,255),
    Line = 222,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 80640,
    EndTime = 81169,
    StartValue = 1,
    EndValue = 1,
    Line = 223,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 81169,
    EndTime = 81699,
    StartValue = 1,
    EndValue = 0,
    Line = 224,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 225,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Another.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 79973,
    EndTime = 79973,
    StartValue = 0.1,
    EndValue = 0.1,
    Line = 226,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 79973,
    EndTime = 80326,
    StartValue = 0,
    EndValue = 1,
    Line = 227,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 79973,
    EndTime = 81385,
    StartValue = new CommandPosition(435,441),
    EndValue = new CommandPosition(466,241),
    Line = 228,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 80326,
    EndTime = 80855,
    StartValue = 1,
    EndValue = 1,
    Line = 229,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 80855,
    EndTime = 81385,
    StartValue = 1,
    EndValue = 0,
    Line = 230,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 231,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Another.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 80502,
    EndTime = 80502,
    StartValue = 0.1,
    EndValue = 0.1,
    Line = 232,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 80502,
    EndTime = 80855,
    StartValue = 0,
    EndValue = 1,
    Line = 233,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 80502,
    EndTime = 81914,
    StartValue = new CommandPosition(592,447),
    EndValue = new CommandPosition(566,165),
    Line = 234,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 80855,
    EndTime = 81384,
    StartValue = 1,
    EndValue = 1,
    Line = 235,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 81384,
    EndTime = 81914,
    StartValue = 1,
    EndValue = 0,
    Line = 236,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 237,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Another.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 81928,
    EndTime = 81928,
    StartValue = 0.1,
    EndValue = 0.1,
    Line = 238,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 81928,
    EndTime = 82281,
    StartValue = 0,
    EndValue = 1,
    Line = 239,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 81928,
    EndTime = 83340,
    StartValue = new CommandPosition(29,441),
    EndValue = new CommandPosition(91,158),
    Line = 240,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 82281,
    EndTime = 82810,
    StartValue = 1,
    EndValue = 1,
    Line = 241,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 82810,
    EndTime = 83340,
    StartValue = 1,
    EndValue = 0,
    Line = 242,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 243,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Another.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 82565,
    EndTime = 82565,
    StartValue = 0.1,
    EndValue = 0.1,
    Line = 244,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 82565,
    EndTime = 82918,
    StartValue = 0,
    EndValue = 1,
    Line = 245,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 82565,
    EndTime = 83977,
    StartValue = new CommandPosition(226,414),
    EndValue = new CommandPosition(217,184),
    Line = 246,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 82918,
    EndTime = 83447,
    StartValue = 1,
    EndValue = 1,
    Line = 247,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 83447,
    EndTime = 83977,
    StartValue = 1,
    EndValue = 0,
    Line = 248,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 249,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Another.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 83270,
    EndTime = 83270,
    StartValue = 0.1,
    EndValue = 0.1,
    Line = 250,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 83270,
    EndTime = 83623,
    StartValue = 0,
    EndValue = 1,
    Line = 251,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 83270,
    EndTime = 84032,
    StartValue = new CommandPosition(362,443),
    EndValue = new CommandPosition(263,278),
    Line = 252,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 83623,
    EndTime = 84152,
    StartValue = 1,
    EndValue = 1,
    Line = 253,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 84032,
    EndTime = 84682,
    StartValue = new CommandPosition(263,278),
    EndValue = new CommandPosition(321,146),
    Line = 254,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 84152,
    EndTime = 84682,
    StartValue = 1,
    EndValue = 0,
    Line = 255,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 256,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Another.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 83986,
    EndTime = 83986,
    StartValue = 0.1,
    EndValue = 0.1,
    Line = 257,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 83986,
    EndTime = 84339,
    StartValue = 0,
    EndValue = 1,
    Line = 258,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 83986,
    EndTime = 84649,
    StartValue = new CommandPosition(161,397),
    EndValue = new CommandPosition(132,259),
    Line = 259,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 84339,
    EndTime = 84868,
    StartValue = 1,
    EndValue = 1,
    Line = 260,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 84649,
    EndTime = 85398,
    StartValue = new CommandPosition(132,259),
    EndValue = new CommandPosition(200,115),
    Line = 261,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 84868,
    EndTime = 85398,
    StartValue = 1,
    EndValue = 0,
    Line = 262,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 263,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Another.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 84718,
    EndTime = 84718,
    StartValue = 0.1,
    EndValue = 0.1,
    Line = 264,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 84718,
    EndTime = 85071,
    StartValue = 0,
    EndValue = 1,
    Line = 265,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 84718,
    EndTime = 86130,
    StartValue = new CommandPosition(331,439),
    EndValue = new CommandPosition(298,220),
    Line = 266,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 85071,
    EndTime = 85600,
    StartValue = 1,
    EndValue = 1,
    Line = 267,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 85600,
    EndTime = 86130,
    StartValue = 1,
    EndValue = 0,
    Line = 268,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 269,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Another.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 85398,
    EndTime = 85398,
    StartValue = 0.1,
    EndValue = 0.1,
    Line = 270,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 85398,
    EndTime = 85751,
    StartValue = 0,
    EndValue = 1,
    Line = 271,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 85398,
    EndTime = 86810,
    StartValue = new CommandPosition(480,441),
    EndValue = new CommandPosition(448,246),
    Line = 272,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 85751,
    EndTime = 86280,
    StartValue = 1,
    EndValue = 1,
    Line = 273,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 86280,
    EndTime = 86810,
    StartValue = 1,
    EndValue = 0,
    Line = 274,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 275,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Another.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 86120,
    EndTime = 86120,
    StartValue = 0.1,
    EndValue = 0.1,
    Line = 276,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 86120,
    EndTime = 86473,
    StartValue = 0,
    EndValue = 1,
    Line = 277,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 86120,
    EndTime = 87532,
    StartValue = new CommandPosition(147,451),
    EndValue = new CommandPosition(92,266),
    Line = 278,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 86473,
    EndTime = 87002,
    StartValue = 1,
    EndValue = 1,
    Line = 279,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 87002,
    EndTime = 87532,
    StartValue = 1,
    EndValue = 0,
    Line = 280,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 281,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Another.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 86824,
    EndTime = 86824,
    StartValue = 0.1,
    EndValue = 0.1,
    Line = 282,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 86824,
    EndTime = 87177,
    StartValue = 0,
    EndValue = 1,
    Line = 283,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 86824,
    EndTime = 88236,
    StartValue = new CommandPosition(458,431),
    EndValue = new CommandPosition(422,248),
    Line = 284,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 87177,
    EndTime = 87706,
    StartValue = 1,
    EndValue = 1,
    Line = 285,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 87706,
    EndTime = 88236,
    StartValue = 1,
    EndValue = 0,
    Line = 286,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 287,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Another.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 87554,
    EndTime = 87554,
    StartValue = 0.1,
    EndValue = 0.1,
    Line = 288,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 87554,
    EndTime = 87907,
    StartValue = 0,
    EndValue = 1,
    Line = 289,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 87554,
    EndTime = 88966,
    StartValue = new CommandPosition(277,434),
    EndValue = new CommandPosition(245,210),
    Line = 290,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 87907,
    EndTime = 88436,
    StartValue = 1,
    EndValue = 1,
    Line = 291,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 88436,
    EndTime = 88966,
    StartValue = 1,
    EndValue = 0,
    Line = 292,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 293,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Another.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 88312,
    EndTime = 88312,
    StartValue = 0.1,
    EndValue = 0.1,
    Line = 294,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 88312,
    EndTime = 88665,
    StartValue = 0,
    EndValue = 1,
    Line = 295,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 88312,
    EndTime = 89724,
    StartValue = new CommandPosition(607,439),
    EndValue = new CommandPosition(550,248),
    Line = 296,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 88665,
    EndTime = 89194,
    StartValue = 1,
    EndValue = 1,
    Line = 297,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 89194,
    EndTime = 89724,
    StartValue = 1,
    EndValue = 0,
    Line = 298,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 299,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Another.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 89731,
    EndTime = 89731,
    StartValue = 0.1,
    EndValue = 0.1,
    Line = 300,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 89731,
    EndTime = 90084,
    StartValue = 0,
    EndValue = 1,
    Line = 301,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 89731,
    EndTime = 91143,
    StartValue = new CommandPosition(53,424),
    EndValue = new CommandPosition(61,228),
    Line = 302,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 90084,
    EndTime = 90613,
    StartValue = 1,
    EndValue = 1,
    Line = 303,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 90613,
    EndTime = 91143,
    StartValue = 1,
    EndValue = 0,
    Line = 304,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 305,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Another.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 88965,
    EndTime = 88965,
    StartValue = 0.1,
    EndValue = 0.1,
    Line = 306,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 88965,
    EndTime = 89318,
    StartValue = 0,
    EndValue = 1,
    Line = 307,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 88965,
    EndTime = 90377,
    StartValue = new CommandPosition(435,496),
    EndValue = new CommandPosition(364,230),
    Line = 308,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 89318,
    EndTime = 89847,
    StartValue = 1,
    EndValue = 1,
    Line = 309,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 89847,
    EndTime = 90377,
    StartValue = 1,
    EndValue = 0,
    Line = 310,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 311,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Another.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 90339,
    EndTime = 90339,
    StartValue = 0.1,
    EndValue = 0.1,
    Line = 312,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 90339,
    EndTime = 90692,
    StartValue = 0,
    EndValue = 1,
    Line = 313,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 90339,
    EndTime = 91751,
    StartValue = new CommandPosition(40,486),
    EndValue = new CommandPosition(111,270),
    Line = 314,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 90692,
    EndTime = 91221,
    StartValue = 1,
    EndValue = 1,
    Line = 315,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 91221,
    EndTime = 91751,
    StartValue = 1,
    EndValue = 0,
    Line = 316,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 317,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Guys.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 46620,
    EndTime = 46620,
    StartValue = 0.8000473,
    EndValue = 0.8000473,
    Line = 318,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 46620,
    EndTime = 47679,
    StartValue = 0.1693316,
    EndValue = 0.3574473,
    Line = 319,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 47679,
    EndTime = 48032,
    StartValue = 0.3574473,
    EndValue = 0.374733,
    Line = 320,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 48032,
    EndTime = 48385,
    StartValue = 0.374733,
    EndValue = 0.3851315,
    Line = 321,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 48385,
    EndTime = 49091,
    StartValue = 0.3851315,
    EndValue = 0.3150896,
    Line = 322,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 49091,
    EndTime = 49443,
    StartValue = 0.3150896,
    EndValue = 0.3916517,
    Line = 323,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 49443,
    EndTime = 49796,
    StartValue = 0.3916517,
    EndValue = 0.2451468,
    Line = 324,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 49796,
    EndTime = 52267,
    StartValue = 0.2451468,
    EndValue = 0,
    Line = 325,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 68149,
    EndTime = 68855,
    StartValue = 0.7267096,
    EndValue = 0,
    Line = 326,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 68149,
    EndTime = 68855,
    StartValue = 0.8000473,
    EndValue = 0.899144,
    Line = 327,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 328,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\1.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 23502,
    EndTime = 23502,
    StartValue = 0.6366453,
    EndValue = 0.6366453,
    Line = 329,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 23502,
    EndTime = 23679,
    StartValue = new CommandPosition(215,396),
    EndValue = new CommandPosition(265,395),
    Line = 330,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 23502,
    EndTime = 23855,
    StartValue = 0,
    EndValue = 1,
    Line = 331,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 23855,
    EndTime = 25796,
    StartValue = 1,
    EndValue = 0.9880153,
    Line = 332,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 25796,
    EndTime = 26149,
    StartValue = 0.9880153,
    EndValue = 0,
    Line = 333,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 334,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\2.png",
    Commands = new List<IOsbCommand>()
    {
        new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 24385,
    EndTime = 24385,
    StartValue = new CommandPosition(218,424),
    EndValue = new CommandPosition(218,424),
    Line = 335,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 24385,
    EndTime = 24385,
    StartValue = 0.5870966,
    EndValue = 0.5870966,
    Line = 336,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 24385,
    EndTime = 24738,
    StartValue = 0,
    EndValue = 1,
    Line = 337,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 24738,
    EndTime = 25796,
    StartValue = 1,
    EndValue = 0.985131,
    Line = 338,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 25796,
    EndTime = 26149,
    StartValue = 0.985131,
    EndValue = 0,
    Line = 339,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 340,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\3.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 26326,
    EndTime = 26326,
    StartValue = 0.6366453,
    EndValue = 0.6366453,
    Line = 341,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 26326,
    EndTime = 26503,
    StartValue = new CommandPosition(215,396),
    EndValue = new CommandPosition(265,395),
    Line = 342,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 26326,
    EndTime = 26679,
    StartValue = 0,
    EndValue = 1,
    Line = 343,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 26679,
    EndTime = 28620,
    StartValue = 1,
    EndValue = 0.9880153,
    Line = 344,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 28620,
    EndTime = 28973,
    StartValue = 0.9880153,
    EndValue = 0,
    Line = 345,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 346,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\4.png",
    Commands = new List<IOsbCommand>()
    {
        new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 27473,
    EndTime = 27473,
    StartValue = new CommandPosition(254,425),
    EndValue = new CommandPosition(254,425),
    Line = 347,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 27473,
    EndTime = 27473,
    StartValue = 0.5870966,
    EndValue = 0.5870966,
    Line = 348,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 27473,
    EndTime = 27826,
    StartValue = 0,
    EndValue = 1,
    Line = 349,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 27826,
    EndTime = 28884,
    StartValue = 1,
    EndValue = 0.985131,
    Line = 350,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 28884,
    EndTime = 29237,
    StartValue = 0.985131,
    EndValue = 0,
    Line = 351,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 352,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\5.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 28973,
    EndTime = 28973,
    StartValue = 0.6366453,
    EndValue = 0.6366453,
    Line = 353,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 28973,
    EndTime = 29150,
    StartValue = new CommandPosition(215,396),
    EndValue = new CommandPosition(265,395),
    Line = 354,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 28973,
    EndTime = 29326,
    StartValue = 0,
    EndValue = 1,
    Line = 355,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 29326,
    EndTime = 31267,
    StartValue = 1,
    EndValue = 0.9880153,
    Line = 356,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 31267,
    EndTime = 31620,
    StartValue = 0.9880153,
    EndValue = 0,
    Line = 357,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 358,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\6.png",
    Commands = new List<IOsbCommand>()
    {
        new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 30385,
    EndTime = 30385,
    StartValue = new CommandPosition(218,424),
    EndValue = new CommandPosition(218,424),
    Line = 359,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 30385,
    EndTime = 30385,
    StartValue = 0.5870966,
    EndValue = 0.5870966,
    Line = 360,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 30385,
    EndTime = 30738,
    StartValue = 0,
    EndValue = 1,
    Line = 361,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 30738,
    EndTime = 31796,
    StartValue = 1,
    EndValue = 0.985131,
    Line = 362,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 31796,
    EndTime = 32149,
    StartValue = 0.985131,
    EndValue = 0,
    Line = 363,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 364,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\7.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 31796,
    EndTime = 31796,
    StartValue = 0.6366453,
    EndValue = 0.6366453,
    Line = 365,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 31796,
    EndTime = 31973,
    StartValue = new CommandPosition(215,396),
    EndValue = new CommandPosition(265,395),
    Line = 366,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 31796,
    EndTime = 32149,
    StartValue = 0,
    EndValue = 1,
    Line = 367,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 32149,
    EndTime = 34090,
    StartValue = 1,
    EndValue = 0.9880153,
    Line = 368,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 34090,
    EndTime = 34443,
    StartValue = 0.9880153,
    EndValue = 0,
    Line = 369,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 370,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Flash.png",
    Commands = new List<IOsbCommand>()
    {
        new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 35326,
    EndTime = 36032,
    StartValue = 1,
    EndValue = 0,
    Line = 371,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 46620,
    EndTime = 47326,
    StartValue = 1,
    EndValue = 0,
    Line = 372,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 57914,
    EndTime = 58620,
    StartValue = 1,
    EndValue = 0,
    Line = 373,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 69208,
    EndTime = 69914,
    StartValue = 1,
    EndValue = 0,
    Line = 374,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 375,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\8.png",
    Commands = new List<IOsbCommand>()
    {
        new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 33208,
    EndTime = 33208,
    StartValue = new CommandPosition(218,424),
    EndValue = new CommandPosition(218,424),
    Line = 376,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 33208,
    EndTime = 33208,
    StartValue = 0.5870966,
    EndValue = 0.5870966,
    Line = 377,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 33208,
    EndTime = 33561,
    StartValue = 0,
    EndValue = 1,
    Line = 378,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 33561,
    EndTime = 34619,
    StartValue = 1,
    EndValue = 0.985131,
    Line = 379,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 34619,
    EndTime = 34972,
    StartValue = 0.985131,
    EndValue = 0,
    Line = 380,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 381,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Light3.png",
    Commands = new List<IOsbCommand>()
    {
        new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 91796,
    EndTime = 91796,
    StartValue = new CommandPosition(320,263),
    EndValue = new CommandPosition(320,263),
    Line = 382,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 91796,
    EndTime = 92502,
    StartValue = 1,
    EndValue = 0,
    Line = 383,
},
    new VectorScaleCommand()
{
    Identifier = "V",
    Easing = OsbEasing.None,
    StartTime = 91796,
    EndTime = 92502,
    StartValue = new CommandScale(0.1,0.1),
    EndValue = new CommandScale(2.197548,0.2569034),
    Line = 384,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 385,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Another uys.jpg",
    Commands = new List<IOsbCommand>()
    {
        new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 125679,
    EndTime = 127091,
    StartValue = 0,
    EndValue = 1,
    Line = 386,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 125679,
    EndTime = 136973,
    StartValue = new CommandPosition(445,254),
    EndValue = new CommandPosition(363,246),
    Line = 387,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 125679,
    EndTime = 136973,
    StartValue = 0.7091599,
    EndValue = 0.7091599,
    Line = 388,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 127091,
    EndTime = 134892,
    StartValue = 1,
    EndValue = 1,
    Line = 389,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 134892,
    EndTime = 136973,
    StartValue = 1,
    EndValue = 0.5546509,
    Line = 390,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 136973,
    EndTime = 137061,
    StartValue = new CommandPosition(363,246),
    EndValue = new CommandPosition(332,276),
    Line = 391,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 136973,
    EndTime = 137061,
    StartValue = 0.7091599,
    EndValue = 0.8000474,
    Line = 392,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 136973,
    EndTime = 146855,
    StartValue = 0.5546509,
    EndValue = 0.3683314,
    Line = 393,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 137061,
    EndTime = 148267,
    StartValue = new CommandPosition(332,276),
    EndValue = new CommandPosition(185,273),
    Line = 394,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 137061,
    EndTime = 148267,
    StartValue = 0.8000474,
    EndValue = 0.7818699,
    Line = 395,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 146855,
    EndTime = 148267,
    StartValue = 0.3683314,
    EndValue = 0,
    Line = 396,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 397,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Kissss.jpg",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 159561,
    EndTime = 159561,
    StartValue = 0.625,
    EndValue = 0.625,
    Line = 398,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 159561,
    EndTime = 180738,
    StartValue = 1,
    EndValue = 1,
    Line = 399,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 180738,
    EndTime = 182149,
    StartValue = 1,
    EndValue = 0,
    Line = 400,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 401,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Guyss.png",
    Commands = new List<IOsbCommand>()
    {
        new LoopCommand()
{
    Identifier = "L",
    StartTime = 0,
    Line = 401,
    LoopCount = 1,
    OsbCommands = new List<IOsbSpriteCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 165561,
    EndTime = 165914,
    StartValue = 0.6273608,
    EndValue = 0.7,
    Line = 402,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 165561,
    EndTime = 166267,
    StartValue = 0.6,
    EndValue = 0,
    Line = 403,
},
    },
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 405,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Light3.png",
    Commands = new List<IOsbCommand>()
    {
        new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 148267,
    EndTime = 148267,
    StartValue = new CommandPosition(320,263),
    EndValue = new CommandPosition(320,263),
    Line = 406,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 148267,
    EndTime = 148973,
    StartValue = 1,
    EndValue = 0,
    Line = 407,
},
    new VectorScaleCommand()
{
    Identifier = "V",
    Easing = OsbEasing.None,
    StartTime = 148267,
    EndTime = 148973,
    StartValue = new CommandScale(0.1,0.1),
    EndValue = new CommandScale(2.197548,0.2569034),
    Line = 408,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 409,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\1.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 136267,
    EndTime = 136267,
    StartValue = 0.6366453,
    EndValue = 0.6366453,
    Line = 410,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 136267,
    EndTime = 136444,
    StartValue = new CommandPosition(215,396),
    EndValue = new CommandPosition(265,395),
    Line = 411,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 136267,
    EndTime = 136620,
    StartValue = 0,
    EndValue = 1,
    Line = 412,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 136620,
    EndTime = 138561,
    StartValue = 1,
    EndValue = 0.9880153,
    Line = 413,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 138561,
    EndTime = 138914,
    StartValue = 0.9880153,
    EndValue = 0,
    Line = 414,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 415,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\2.png",
    Commands = new List<IOsbCommand>()
    {
        new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 137502,
    EndTime = 137502,
    StartValue = new CommandPosition(218,424),
    EndValue = new CommandPosition(218,424),
    Line = 416,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 137502,
    EndTime = 137502,
    StartValue = 0.5870966,
    EndValue = 0.5870966,
    Line = 417,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 137502,
    EndTime = 137855,
    StartValue = 0,
    EndValue = 1,
    Line = 418,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 137855,
    EndTime = 138913,
    StartValue = 1,
    EndValue = 0.985131,
    Line = 419,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 138913,
    EndTime = 139266,
    StartValue = 0.985131,
    EndValue = 0,
    Line = 420,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 421,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\3.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 139091,
    EndTime = 139091,
    StartValue = 0.6366453,
    EndValue = 0.6366453,
    Line = 422,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 139091,
    EndTime = 139268,
    StartValue = new CommandPosition(215,396),
    EndValue = new CommandPosition(265,395),
    Line = 423,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 139091,
    EndTime = 139444,
    StartValue = 0,
    EndValue = 1,
    Line = 424,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 139444,
    EndTime = 141385,
    StartValue = 1,
    EndValue = 0.9880153,
    Line = 425,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 141385,
    EndTime = 141738,
    StartValue = 0.9880153,
    EndValue = 0,
    Line = 426,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 427,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\4.png",
    Commands = new List<IOsbCommand>()
    {
        new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 140326,
    EndTime = 140326,
    StartValue = new CommandPosition(254,425),
    EndValue = new CommandPosition(254,425),
    Line = 428,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 140326,
    EndTime = 140326,
    StartValue = 0.5870966,
    EndValue = 0.5870966,
    Line = 429,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 140326,
    EndTime = 140679,
    StartValue = 0,
    EndValue = 1,
    Line = 430,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 140679,
    EndTime = 141737,
    StartValue = 1,
    EndValue = 0.985131,
    Line = 431,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 141737,
    EndTime = 142090,
    StartValue = 0.985131,
    EndValue = 0,
    Line = 432,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 433,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\5.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 141914,
    EndTime = 141914,
    StartValue = 0.6366453,
    EndValue = 0.6366453,
    Line = 434,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 141914,
    EndTime = 142091,
    StartValue = new CommandPosition(215,396),
    EndValue = new CommandPosition(265,395),
    Line = 435,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 141914,
    EndTime = 142267,
    StartValue = 0,
    EndValue = 1,
    Line = 436,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 142267,
    EndTime = 144208,
    StartValue = 1,
    EndValue = 0.9880153,
    Line = 437,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 144208,
    EndTime = 144561,
    StartValue = 0.9880153,
    EndValue = 0,
    Line = 438,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 439,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\6.png",
    Commands = new List<IOsbCommand>()
    {
        new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 143149,
    EndTime = 143149,
    StartValue = new CommandPosition(218,424),
    EndValue = new CommandPosition(218,424),
    Line = 440,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 143149,
    EndTime = 143149,
    StartValue = 0.5870966,
    EndValue = 0.5870966,
    Line = 441,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 143149,
    EndTime = 143502,
    StartValue = 0,
    EndValue = 1,
    Line = 442,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 143502,
    EndTime = 144560,
    StartValue = 1,
    EndValue = 0.985131,
    Line = 443,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 144560,
    EndTime = 144913,
    StartValue = 0.985131,
    EndValue = 0,
    Line = 444,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 445,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\7.png",
    Commands = new List<IOsbCommand>()
    {
        new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 144649,
    EndTime = 144649,
    StartValue = 0.6366453,
    EndValue = 0.6366453,
    Line = 446,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 144649,
    EndTime = 144826,
    StartValue = new CommandPosition(215,396),
    EndValue = new CommandPosition(265,395),
    Line = 447,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 144649,
    EndTime = 145002,
    StartValue = 0,
    EndValue = 1,
    Line = 448,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 145002,
    EndTime = 146943,
    StartValue = 1,
    EndValue = 0.9880153,
    Line = 449,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 146943,
    EndTime = 147296,
    StartValue = 0.9880153,
    EndValue = 0,
    Line = 450,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 451,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\8.png",
    Commands = new List<IOsbCommand>()
    {
        new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 146061,
    EndTime = 146061,
    StartValue = new CommandPosition(218,424),
    EndValue = new CommandPosition(218,424),
    Line = 452,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 146061,
    EndTime = 146061,
    StartValue = 0.5870966,
    EndValue = 0.5870966,
    Line = 453,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 146061,
    EndTime = 146414,
    StartValue = 0,
    EndValue = 1,
    Line = 454,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 146414,
    EndTime = 147472,
    StartValue = 1,
    EndValue = 0.985131,
    Line = 455,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 147472,
    EndTime = 147825,
    StartValue = 0.985131,
    EndValue = 0,
    Line = 456,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 457,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Light3.png",
    Commands = new List<IOsbCommand>()
    {
        new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 153914,
    EndTime = 153914,
    StartValue = new CommandPosition(320,263),
    EndValue = new CommandPosition(320,263),
    Line = 458,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 153914,
    EndTime = 154620,
    StartValue = 1,
    EndValue = 0,
    Line = 459,
},
    new VectorScaleCommand()
{
    Identifier = "V",
    Easing = OsbEasing.None,
    StartTime = 153914,
    EndTime = 154620,
    StartValue = new CommandScale(0.1,0.1),
    EndValue = new CommandScale(2.197548,0.2569034),
    Line = 460,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 461,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Flash2.png",
    Commands = new List<IOsbCommand>()
    {
        new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 43796,
    EndTime = 43796,
    StartValue = new CommandPosition(320,240),
    EndValue = new CommandPosition(320,240),
    Line = 462,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 43796,
    EndTime = 44502,
    StartValue = 0.5182958,
    EndValue = 0,
    Line = 463,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 43796,
    EndTime = 44502,
    StartValue = 1,
    EndValue = 1.427172,
    Line = 464,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 80502,
    EndTime = 80502,
    StartValue = 1.022527,
    EndValue = 1.022527,
    Line = 465,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 80502,
    EndTime = 81561,
    StartValue = 0.496258,
    EndValue = 0,
    Line = 466,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 91796,
    EndTime = 92855,
    StartValue = 0.4335484,
    EndValue = 0,
    Line = 467,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 93208,
    EndTime = 94267,
    StartValue = 0.3138064,
    EndValue = 0,
    Line = 468,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 94620,
    EndTime = 95679,
    StartValue = 0.5173144,
    EndValue = 0,
    Line = 469,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 96032,
    EndTime = 97091,
    StartValue = 0.8877419,
    EndValue = 0,
    Line = 470,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 471,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Another.png",
    Commands = new List<IOsbCommand>()
    {
        new LoopCommand()
{
    Identifier = "L",
    StartTime = 0,
    Line = 471,
    LoopCount = 2,
    OsbCommands = new List<IOsbSpriteCommand>()
    {
        new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 97443,
    EndTime = 97443,
    StartValue = new CommandPosition(642,7),
    EndValue = new CommandPosition(642,7),
    Line = 472,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 97443,
    EndTime = 97796,
    StartValue = 1,
    EndValue = 0,
    Line = 473,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 97443,
    EndTime = 97796,
    StartValue = 0.1,
    EndValue = 3.122452,
    Line = 474,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 97796,
    EndTime = 97796,
    StartValue = new CommandPosition(640,476),
    EndValue = new CommandPosition(640,476),
    Line = 475,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 97796,
    EndTime = 98149,
    StartValue = 1,
    EndValue = 0,
    Line = 476,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 97796,
    EndTime = 98149,
    StartValue = 0.1,
    EndValue = 3.122452,
    Line = 477,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 98149,
    EndTime = 98149,
    StartValue = new CommandPosition(0,475),
    EndValue = new CommandPosition(0,475),
    Line = 478,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 98149,
    EndTime = 98502,
    StartValue = 1,
    EndValue = 0,
    Line = 479,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 98149,
    EndTime = 98502,
    StartValue = 0.1,
    EndValue = 3.122452,
    Line = 480,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 98502,
    EndTime = 98502,
    StartValue = new CommandPosition(4,2),
    EndValue = new CommandPosition(4,2),
    Line = 481,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 98502,
    EndTime = 98855,
    StartValue = 1,
    EndValue = 0,
    Line = 482,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 98502,
    EndTime = 98855,
    StartValue = 0.1,
    EndValue = 3.122452,
    Line = 483,
},
    },
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 485,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\moon.png",
    Commands = new List<IOsbCommand>()
    {
        new LoopCommand()
{
    Identifier = "L",
    StartTime = 0,
    Line = 485,
    LoopCount = 2,
    OsbCommands = new List<IOsbSpriteCommand>()
    {
        new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 156738,
    EndTime = 156738,
    StartValue = new CommandPosition(505,144),
    EndValue = new CommandPosition(505,144),
    Line = 486,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 156738,
    EndTime = 156826,
    StartValue = 1,
    EndValue = 0,
    Line = 487,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 156738,
    EndTime = 156826,
    StartValue = 0.1,
    EndValue = 0.4550968,
    Line = 488,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 156826,
    EndTime = 156826,
    StartValue = new CommandPosition(189,366),
    EndValue = new CommandPosition(189,366),
    Line = 489,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 156826,
    EndTime = 156914,
    StartValue = 1,
    EndValue = 0,
    Line = 490,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 156826,
    EndTime = 156914,
    StartValue = 0.1,
    EndValue = 0.4550968,
    Line = 491,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 156914,
    EndTime = 156914,
    StartValue = new CommandPosition(121,74),
    EndValue = new CommandPosition(121,74),
    Line = 492,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 156914,
    EndTime = 157002,
    StartValue = 1,
    EndValue = 0,
    Line = 493,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 156914,
    EndTime = 157002,
    StartValue = 0.1,
    EndValue = 0.4550968,
    Line = 494,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 157002,
    EndTime = 157002,
    StartValue = new CommandPosition(590,402),
    EndValue = new CommandPosition(590,402),
    Line = 495,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 157002,
    EndTime = 157090,
    StartValue = 1,
    EndValue = 0,
    Line = 496,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 157002,
    EndTime = 157090,
    StartValue = 0.1,
    EndValue = 0.4550968,
    Line = 497,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 157091,
    EndTime = 157091,
    StartValue = new CommandPosition(284,449),
    EndValue = new CommandPosition(284,449),
    Line = 498,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 157091,
    EndTime = 157179,
    StartValue = 1,
    EndValue = 0,
    Line = 499,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 157091,
    EndTime = 157179,
    StartValue = 0.1,
    EndValue = 0.4550968,
    Line = 500,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 157179,
    EndTime = 157179,
    StartValue = new CommandPosition(43,326),
    EndValue = new CommandPosition(43,326),
    Line = 501,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 157179,
    EndTime = 157267,
    StartValue = 1,
    EndValue = 0,
    Line = 502,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 157179,
    EndTime = 157267,
    StartValue = 0.1,
    EndValue = 0.4550968,
    Line = 503,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 157267,
    EndTime = 157267,
    StartValue = new CommandPosition(45,66),
    EndValue = new CommandPosition(45,66),
    Line = 504,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 157267,
    EndTime = 157355,
    StartValue = 1,
    EndValue = 0,
    Line = 505,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 157267,
    EndTime = 157355,
    StartValue = 0.1,
    EndValue = 0.4550968,
    Line = 506,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 157355,
    EndTime = 157355,
    StartValue = new CommandPosition(207,444),
    EndValue = new CommandPosition(207,444),
    Line = 507,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 157355,
    EndTime = 157443,
    StartValue = 1,
    EndValue = 0,
    Line = 508,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 157355,
    EndTime = 157443,
    StartValue = 0.1,
    EndValue = 0.4550968,
    Line = 509,
},
    new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 157443,
    EndTime = 157443,
    StartValue = new CommandPosition(314,53),
    EndValue = new CommandPosition(314,53),
    Line = 510,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 157443,
    EndTime = 157531,
    StartValue = 1,
    EndValue = 0,
    Line = 511,
},
    new ScaleCommand()
{
    Identifier = "S",
    Easing = OsbEasing.None,
    StartTime = 157443,
    EndTime = 157531,
    StartValue = 0.1,
    EndValue = 0.4550968,
    Line = 512,
},
    },
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 514,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Flash.png",
    Commands = new List<IOsbCommand>()
    {
        new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 100267,
    EndTime = 100355,
    StartValue = 0.4756129,
    EndValue = 0,
    Line = 515,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 100355,
    EndTime = 100443,
    StartValue = 0.4756129,
    EndValue = 0,
    Line = 516,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 100443,
    EndTime = 100531,
    StartValue = 0.4756129,
    EndValue = 0,
    Line = 517,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 100532,
    EndTime = 100620,
    StartValue = 0.4756129,
    EndValue = 0,
    Line = 518,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 100620,
    EndTime = 100708,
    StartValue = 0.4756129,
    EndValue = 0,
    Line = 519,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 100708,
    EndTime = 100796,
    StartValue = 0.4756129,
    EndValue = 0,
    Line = 520,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 100796,
    EndTime = 100884,
    StartValue = 0.4756129,
    EndValue = 0,
    Line = 521,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 100885,
    EndTime = 100973,
    StartValue = 0.4756129,
    EndValue = 0,
    Line = 522,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 100973,
    EndTime = 101061,
    StartValue = 0.4756129,
    EndValue = 0,
    Line = 523,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 101061,
    EndTime = 101149,
    StartValue = 0.4756129,
    EndValue = 0,
    Line = 524,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 101149,
    EndTime = 101237,
    StartValue = 0.4756129,
    EndValue = 0,
    Line = 525,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 101238,
    EndTime = 101326,
    StartValue = 0.4756129,
    EndValue = 0,
    Line = 526,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 101326,
    EndTime = 101414,
    StartValue = 0.4756129,
    EndValue = 0,
    Line = 527,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 101414,
    EndTime = 101502,
    StartValue = 0.4756129,
    EndValue = 0,
    Line = 528,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 101502,
    EndTime = 101590,
    StartValue = 0.4756129,
    EndValue = 0,
    Line = 529,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 101591,
    EndTime = 101679,
    StartValue = 0.4756129,
    EndValue = 0,
    Line = 530,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 103091,
    EndTime = 103796,
    StartValue = 1,
    EndValue = 0,
    Line = 531,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 124267,
    EndTime = 125326,
    StartValue = 1,
    EndValue = 0,
    Line = 532,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 148267,
    EndTime = 148973,
    StartValue = 0.2518709,
    EndValue = 0,
    Line = 533,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 149679,
    EndTime = 150738,
    StartValue = 0.6771613,
    EndValue = 0,
    Line = 534,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 151091,
    EndTime = 152149,
    StartValue = 0.7308386,
    EndValue = 0,
    Line = 535,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 152502,
    EndTime = 153208,
    StartValue = 0.635871,
    EndValue = 0,
    Line = 536,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 158149,
    EndTime = 158502,
    StartValue = 1,
    EndValue = 1,
    Line = 537,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 158502,
    EndTime = 159208,
    StartValue = 1,
    EndValue = 0,
    Line = 538,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 159561,
    EndTime = 160267,
    StartValue = 1,
    EndValue = 0,
    Line = 539,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 170855,
    EndTime = 171561,
    StartValue = 1,
    EndValue = 0,
    Line = 540,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 541,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\mapped.png",
    Commands = new List<IOsbCommand>()
    {
        new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 104502,
    EndTime = 104502,
    StartValue = new CommandPosition(494,355),
    EndValue = new CommandPosition(494,355),
    Line = 542,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 104502,
    EndTime = 105032,
    StartValue = 0,
    EndValue = 1,
    Line = 543,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 105032,
    EndTime = 112973,
    StartValue = 1,
    EndValue = 1,
    Line = 544,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 112973,
    EndTime = 113679,
    StartValue = 1,
    EndValue = 0,
    Line = 545,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 546,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\xin.png",
    Commands = new List<IOsbCommand>()
    {
        new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 105032,
    EndTime = 105032,
    StartValue = new CommandPosition(604,383),
    EndValue = new CommandPosition(604,383),
    Line = 547,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 105032,
    EndTime = 105561,
    StartValue = 0,
    EndValue = 1,
    Line = 548,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 105561,
    EndTime = 119326,
    StartValue = 1,
    EndValue = 1,
    Line = 549,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 119326,
    EndTime = 120032,
    StartValue = 1,
    EndValue = 0,
    Line = 550,
},
    },
},
    new VisualElement()
{
    Layer = OsbLayer.Foreground,
    Anchor = OsbOrigin.Centre,
    Line = 551,
    InitialPosition = new CommandPosition(320,240),
    zIndex = 0,
    RelativePath = @"SB\Storyboard.png",
    Commands = new List<IOsbCommand>()
    {
        new MoveCommand()
{
    Identifier = "M",
    Easing = OsbEasing.None,
    StartTime = 114385,
    EndTime = 114385,
    StartValue = new CommandPosition(494,355),
    EndValue = new CommandPosition(494,355),
    Line = 552,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 114385,
    EndTime = 114915,
    StartValue = 0,
    EndValue = 1,
    Line = 553,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 114915,
    EndTime = 119326,
    StartValue = 1,
    EndValue = 1,
    Line = 554,
},
    new FadeCommand()
{
    Identifier = "F",
    Easing = OsbEasing.None,
    StartTime = 119326,
    EndTime = 120032,
    StartValue = 1,
    EndValue = 0,
    Line = 555,
},
    },
},
    },
        };
    }
}

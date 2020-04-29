using System;
using System.Collections.Generic;
using System.Text;
using Contracts;
using Contracts.Commands;
using Contracts.Enums;
using OsbAnalyser.Analysing.Elements;
using Xunit;

namespace OsbAnalyser.Test
{
    public class RedundancyAnalyserTest
    {
        private RedundancyAnalyser RedundancyAnalyser = new RedundancyAnalyser();

        [Fact]
        public void FindRedundantCommandsTest1()
        {
            var visualElement = new VisualElement()
            {
                Layer = OsbLayer.Background,
                Anchor = OsbOrigin.Centre,
                Line = 70474,
                InitialPosition = new CommandPosition(0, 0),
                zIndex = 0,
                RelativePath = @"sb\p.png",
                Commands = new List<IOsbCommand>()
                {
                    new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 63015,
                        EndTime = 63015,
                        StartValue = 0.2337775,
                        EndValue = 0.2337775,
                        Line = 70475,
                    },
                    new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 63015,
                        EndTime = 63115,
                        StartValue = 0,
                        EndValue = 0.2337775,
                        Line = 70476,
                    },
                        new MoveCommand()
                    {
                        Identifier = "M",
                        Easing = OsbEasing.None,
                        StartTime = 63015,
                        EndTime = 63215,
                        StartValue = new CommandPosition(744.1379,0),
                        EndValue = new CommandPosition(844.1379,480),
                        Line = 70477,
                    },
                        new RotateCommand()
                    {
                        Identifier = "R",
                        Easing = OsbEasing.None,
                        StartTime = 63015,
                        EndTime = 63215,
                        StartValue = -0.22,
                        EndValue = -0.22,
                        Line = 70478,
                    },
                        new VectorScaleCommand()
                    {
                        Identifier = "V",
                        Easing = OsbEasing.None,
                        StartTime = 63015,
                        EndTime = 63215,
                        StartValue = new CommandScale(1,10),
                        EndValue = new CommandScale(1,11),
                        Line = 70479,
                    },
                        new ParameterCommand()
                    {
                        Identifier = "P",
                        Easing = OsbEasing.None,
                        StartTime = 63015,
                        EndTime = 86879,
                        StartValue = ParameterType.AdditiveBlending,
                        EndValue = ParameterType.AdditiveBlending,
                        Line = 70480,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 63115,
                        EndTime = 63215,
                        StartValue = 0.2337775,
                        EndValue = 0,
                        Line = 70481,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 63219,
                        EndTime = 63319,
                        StartValue = 0,
                        EndValue = 0.2337775,
                        Line = 70482,
                    },
                        new MoveCommand()
                    {
                        Identifier = "M",
                        Easing = OsbEasing.None,
                        StartTime = 63219,
                        EndTime = 63419,
                        StartValue = new CommandPosition(248.006,0),
                        EndValue = new CommandPosition(348.006,480),
                        Line = 70483,
                    },
                        new RotateCommand()
                    {
                        Identifier = "R",
                        Easing = OsbEasing.None,
                        StartTime = 63219,
                        EndTime = 63419,
                        StartValue = -0.22,
                        EndValue = -0.22,
                        Line = 70484,
                    },
                        new VectorScaleCommand()
                    {
                        Identifier = "V",
                        Easing = OsbEasing.None,
                        StartTime = 63219,
                        EndTime = 63419,
                        StartValue = new CommandScale(1,16),
                        EndValue = new CommandScale(1,17),
                        Line = 70485,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 63319,
                        EndTime = 63419,
                        StartValue = 0.2337775,
                        EndValue = 0,
                        Line = 70486,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 63423,
                        EndTime = 63523,
                        StartValue = 0,
                        EndValue = 0.2337775,
                        Line = 70487,
                    },
                        new MoveCommand()
                    {
                        Identifier = "M",
                        Easing = OsbEasing.None,
                        StartTime = 63423,
                        EndTime = 63623,
                        StartValue = new CommandPosition(656.7433,0),
                        EndValue = new CommandPosition(756.7433,480),
                        Line = 70488,
                    },
                        new RotateCommand()
                    {
                        Identifier = "R",
                        Easing = OsbEasing.None,
                        StartTime = 63423,
                        EndTime = 63623,
                        StartValue = -0.22,
                        EndValue = -0.22,
                        Line = 70489,
                    },
                        new VectorScaleCommand()
                    {
                        Identifier = "V",
                        Easing = OsbEasing.None,
                        StartTime = 63423,
                        EndTime = 63623,
                        StartValue = new CommandScale(1,15),
                        EndValue = new CommandScale(1,18),
                        Line = 70490,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 63523,
                        EndTime = 63623,
                        StartValue = 0.2337775,
                        EndValue = 0,
                        Line = 70491,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 63627,
                        EndTime = 63727,
                        StartValue = 0,
                        EndValue = 0.2337775,
                        Line = 70492,
                    },
                        new MoveCommand()
                    {
                        Identifier = "M",
                        Easing = OsbEasing.None,
                        StartTime = 63627,
                        EndTime = 63827,
                        StartValue = new CommandPosition(-11.92069,0),
                        EndValue = new CommandPosition(88.07932,480),
                        Line = 70493,
                    },
                        new RotateCommand()
                    {
                        Identifier = "R",
                        Easing = OsbEasing.None,
                        StartTime = 63627,
                        EndTime = 63827,
                        StartValue = -0.22,
                        EndValue = -0.22,
                        Line = 70494,
                    },
                        new VectorScaleCommand()
                    {
                        Identifier = "V",
                        Easing = OsbEasing.None,
                        StartTime = 63627,
                        EndTime = 63827,
                        StartValue = new CommandScale(1,43),
                        EndValue = new CommandScale(1,45),
                        Line = 70495,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 63727,
                        EndTime = 63827,
                        StartValue = 0.2337775,
                        EndValue = 0,
                        Line = 70496,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 63831,
                        EndTime = 63931,
                        StartValue = 0,
                        EndValue = 0.2337775,
                        Line = 70497,
                    },
                        new MoveCommand()
                    {
                        Identifier = "M",
                        Easing = OsbEasing.None,
                        StartTime = 63831,
                        EndTime = 64031,
                        StartValue = new CommandPosition(93.69507,0),
                        EndValue = new CommandPosition(193.6951,480),
                        Line = 70498,
                    },
                        new RotateCommand()
                    {
                        Identifier = "R",
                        Easing = OsbEasing.None,
                        StartTime = 63831,
                        EndTime = 64031,
                        StartValue = -0.22,
                        EndValue = -0.22,
                        Line = 70499,
                    },
                        new VectorScaleCommand()
                    {
                        Identifier = "V",
                        Easing = OsbEasing.None,
                        StartTime = 63831,
                        EndTime = 64031,
                        StartValue = new CommandScale(1,21),
                        EndValue = new CommandScale(1,23),
                        Line = 70500,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 63931,
                        EndTime = 64031,
                        StartValue = 0.2337775,
                        EndValue = 0,
                        Line = 70501,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 64035,
                        EndTime = 64135,
                        StartValue = 0,
                        EndValue = 0.2337775,
                        Line = 70502,
                    },
                        new MoveCommand()
                    {
                        Identifier = "M",
                        Easing = OsbEasing.None,
                        StartTime = 64035,
                        EndTime = 64235,
                        StartValue = new CommandPosition(276.883,0),
                        EndValue = new CommandPosition(376.883,480),
                        Line = 70503,
                    },
                        new RotateCommand()
                    {
                        Identifier = "R",
                        Easing = OsbEasing.None,
                        StartTime = 64035,
                        EndTime = 64235,
                        StartValue = -0.22,
                        EndValue = -0.22,
                        Line = 70504,
                    },
                        new VectorScaleCommand()
                    {
                        Identifier = "V",
                        Easing = OsbEasing.None,
                        StartTime = 64035,
                        EndTime = 64235,
                        StartValue = new CommandScale(1,19),
                        EndValue = new CommandScale(1,19),
                        Line = 70505,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 64135,
                        EndTime = 64235,
                        StartValue = 0.2337775,
                        EndValue = 0,
                        Line = 70506,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 64239,
                        EndTime = 64339,
                        StartValue = 0,
                        EndValue = 0.2337775,
                        Line = 70507,
                    },
                        new MoveCommand()
                    {
                        Identifier = "M",
                        Easing = OsbEasing.None,
                        StartTime = 64239,
                        EndTime = 64439,
                        StartValue = new CommandPosition(-199.0052,0),
                        EndValue = new CommandPosition(-99.00517,480),
                        Line = 70508,
                    },
                        new RotateCommand()
                    {
                        Identifier = "R",
                        Easing = OsbEasing.None,
                        StartTime = 64239,
                        EndTime = 64439,
                        StartValue = -0.22,
                        EndValue = -0.22,
                        Line = 70509,
                    },
                        new VectorScaleCommand()
                    {
                        Identifier = "V",
                        Easing = OsbEasing.None,
                        StartTime = 64239,
                        EndTime = 64439,
                        StartValue = new CommandScale(1,37),
                        EndValue = new CommandScale(1,41),
                        Line = 70510,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 64339,
                        EndTime = 64439,
                        StartValue = 0.2337775,
                        EndValue = 0,
                        Line = 70511,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 64443,
                        EndTime = 64543,
                        StartValue = 0,
                        EndValue = 0.2337775,
                        Line = 70512,
                    },
                        new MoveCommand()
                    {
                        Identifier = "M",
                        Easing = OsbEasing.None,
                        StartTime = 64443,
                        EndTime = 64643,
                        StartValue = new CommandPosition(282.9922,0),
                        EndValue = new CommandPosition(382.9922,480),
                        Line = 70513,
                    },
                        new RotateCommand()
                    {
                        Identifier = "R",
                        Easing = OsbEasing.None,
                        StartTime = 64443,
                        EndTime = 64643,
                        StartValue = -0.22,
                        EndValue = -0.22,
                        Line = 70514,
                    },
                        new VectorScaleCommand()
                    {
                        Identifier = "V",
                        Easing = OsbEasing.None,
                        StartTime = 64443,
                        EndTime = 64643,
                        StartValue = new CommandScale(1,51),
                        EndValue = new CommandScale(1,51),
                        Line = 70515,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 64543,
                        EndTime = 64643,
                        StartValue = 0.2337775,
                        EndValue = 0,
                        Line = 70516,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 64647,
                        EndTime = 64747,
                        StartValue = 0,
                        EndValue = 0.2337775,
                        Line = 70517,
                    },
                        new MoveCommand()
                    {
                        Identifier = "M",
                        Easing = OsbEasing.None,
                        StartTime = 64647,
                        EndTime = 64847,
                        StartValue = new CommandPosition(438.1948,0),
                        EndValue = new CommandPosition(538.1948,480),
                        Line = 70518,
                    },
                        new RotateCommand()
                    {
                        Identifier = "R",
                        Easing = OsbEasing.None,
                        StartTime = 64647,
                        EndTime = 64847,
                        StartValue = -0.22,
                        EndValue = -0.22,
                        Line = 70519,
                    },
                        new VectorScaleCommand()
                    {
                        Identifier = "V",
                        Easing = OsbEasing.None,
                        StartTime = 64647,
                        EndTime = 64847,
                        StartValue = new CommandScale(1,42),
                        EndValue = new CommandScale(1,45),
                        Line = 70520,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 64747,
                        EndTime = 64847,
                        StartValue = 0.2337775,
                        EndValue = 0,
                        Line = 70521,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 64851,
                        EndTime = 64951,
                        StartValue = 0,
                        EndValue = 0.2337775,
                        Line = 70522,
                    },
                        new MoveCommand()
                    {
                        Identifier = "M",
                        Easing = OsbEasing.None,
                        StartTime = 64851,
                        EndTime = 65051,
                        StartValue = new CommandPosition(-8.781677,0),
                        EndValue = new CommandPosition(91.21832,480),
                        Line = 70523,
                    },
                        new RotateCommand()
                    {
                        Identifier = "R",
                        Easing = OsbEasing.None,
                        StartTime = 64851,
                        EndTime = 65051,
                        StartValue = -0.22,
                        EndValue = -0.22,
                        Line = 70524,
                    },
                        new VectorScaleCommand()
                    {
                        Identifier = "V",
                        Easing = OsbEasing.None,
                        StartTime = 64851,
                        EndTime = 65051,
                        StartValue = new CommandScale(1,48),
                        EndValue = new CommandScale(1,48),
                        Line = 70525,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 64951,
                        EndTime = 65051,
                        StartValue = 0.2337775,
                        EndValue = 0,
                        Line = 70526,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 65055,
                        EndTime = 65155,
                        StartValue = 0,
                        EndValue = 0.2337775,
                        Line = 70527,
                    },
                        new MoveCommand()
                    {
                        Identifier = "M",
                        Easing = OsbEasing.None,
                        StartTime = 65055,
                        EndTime = 65255,
                        StartValue = new CommandPosition(323.8686,0),
                        EndValue = new CommandPosition(423.8686,480),
                        Line = 70528,
                    },
                        new RotateCommand()
                    {
                        Identifier = "R",
                        Easing = OsbEasing.None,
                        StartTime = 65055,
                        EndTime = 65255,
                        StartValue = -0.22,
                        EndValue = -0.22,
                        Line = 70529,
                    },
                        new VectorScaleCommand()
                    {
                        Identifier = "V",
                        Easing = OsbEasing.None,
                        StartTime = 65055,
                        EndTime = 65255,
                        StartValue = new CommandScale(1,42),
                        EndValue = new CommandScale(1,46),
                        Line = 70530,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 65155,
                        EndTime = 65255,
                        StartValue = 0.2337775,
                        EndValue = 0,
                        Line = 70531,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 65259,
                        EndTime = 65359,
                        StartValue = 0,
                        EndValue = 0.2337775,
                        Line = 70532,
                    },
                        new MoveCommand()
                    {
                        Identifier = "M",
                        Easing = OsbEasing.None,
                        StartTime = 65259,
                        EndTime = 65459,
                        StartValue = new CommandPosition(468.9879,0),
                        EndValue = new CommandPosition(568.9879,480),
                        Line = 70533,
                    },
                        new RotateCommand()
                    {
                        Identifier = "R",
                        Easing = OsbEasing.None,
                        StartTime = 65259,
                        EndTime = 65459,
                        StartValue = -0.22,
                        EndValue = -0.22,
                        Line = 70534,
                    },
                        new VectorScaleCommand()
                    {
                        Identifier = "V",
                        Easing = OsbEasing.None,
                        StartTime = 65259,
                        EndTime = 65459,
                        StartValue = new CommandScale(1,13),
                        EndValue = new CommandScale(1,17),
                        Line = 70535,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 65359,
                        EndTime = 65459,
                        StartValue = 0.2337775,
                        EndValue = 0,
                        Line = 70536,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 65463,
                        EndTime = 65563,
                        StartValue = 0,
                        EndValue = 0.2337775,
                        Line = 70537,
                    },
                        new MoveCommand()
                    {
                        Identifier = "M",
                        Easing = OsbEasing.None,
                        StartTime = 65463,
                        EndTime = 65663,
                        StartValue = new CommandPosition(408.0869,0),
                        EndValue = new CommandPosition(508.0869,480),
                        Line = 70538,
                    },
                        new RotateCommand()
                    {
                        Identifier = "R",
                        Easing = OsbEasing.None,
                        StartTime = 65463,
                        EndTime = 65663,
                        StartValue = -0.22,
                        EndValue = -0.22,
                        Line = 70539,
                    },
                        new VectorScaleCommand()
                    {
                        Identifier = "V",
                        Easing = OsbEasing.None,
                        StartTime = 65463,
                        EndTime = 65663,
                        StartValue = new CommandScale(1,46),
                        EndValue = new CommandScale(1,46),
                        Line = 70540,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 65563,
                        EndTime = 65663,
                        StartValue = 0.2337775,
                        EndValue = 0,
                        Line = 70541,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 65667,
                        EndTime = 65767,
                        StartValue = 0,
                        EndValue = 0.2337775,
                        Line = 70542,
                    },
                        new MoveCommand()
                    {
                        Identifier = "M",
                        Easing = OsbEasing.None,
                        StartTime = 65667,
                        EndTime = 65867,
                        StartValue = new CommandPosition(174.0874,0),
                        EndValue = new CommandPosition(274.0874,480),
                        Line = 70543,
                    },
                        new RotateCommand()
                    {
                        Identifier = "R",
                        Easing = OsbEasing.None,
                        StartTime = 65667,
                        EndTime = 65867,
                        StartValue = -0.22,
                        EndValue = -0.22,
                        Line = 70544,
                    },
                        new VectorScaleCommand()
                    {
                        Identifier = "V",
                        Easing = OsbEasing.None,
                        StartTime = 65667,
                        EndTime = 65867,
                        StartValue = new CommandScale(1,15),
                        EndValue = new CommandScale(1,17),
                        Line = 70545,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 65767,
                        EndTime = 65867,
                        StartValue = 0.2337775,
                        EndValue = 0,
                        Line = 70546,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 65871,
                        EndTime = 65971,
                        StartValue = 0,
                        EndValue = 0.2337775,
                        Line = 70547,
                    },
                        new MoveCommand()
                    {
                        Identifier = "M",
                        Easing = OsbEasing.None,
                        StartTime = 65871,
                        EndTime = 66071,
                        StartValue = new CommandPosition(-244.1528,0),
                        EndValue = new CommandPosition(-144.1528,480),
                        Line = 70548,
                    },
                        new RotateCommand()
                    {
                        Identifier = "R",
                        Easing = OsbEasing.None,
                        StartTime = 65871,
                        EndTime = 66071,
                        StartValue = -0.22,
                        EndValue = -0.22,
                        Line = 70549,
                    },
                        new VectorScaleCommand()
                    {
                        Identifier = "V",
                        Easing = OsbEasing.None,
                        StartTime = 65871,
                        EndTime = 66071,
                        StartValue = new CommandScale(1,14),
                        EndValue = new CommandScale(1,14),
                        Line = 70550,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 65971,
                        EndTime = 66071,
                        StartValue = 0.2337775,
                        EndValue = 0,
                        Line = 70551,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 66075,
                        EndTime = 66175,
                        StartValue = 0,
                        EndValue = 0.2337775,
                        Line = 70552,
                    },
                        new MoveCommand()
                    {
                        Identifier = "M",
                        Easing = OsbEasing.None,
                        StartTime = 66075,
                        EndTime = 66275,
                        StartValue = new CommandPosition(411.7728,0),
                        EndValue = new CommandPosition(511.7728,480),
                        Line = 70553,
                    },
                        new RotateCommand()
                    {
                        Identifier = "R",
                        Easing = OsbEasing.None,
                        StartTime = 66075,
                        EndTime = 66275,
                        StartValue = -0.22,
                        EndValue = -0.22,
                        Line = 70554,
                    },
                        new VectorScaleCommand()
                    {
                        Identifier = "V",
                        Easing = OsbEasing.None,
                        StartTime = 66075,
                        EndTime = 66275,
                        StartValue = new CommandScale(1,17),
                        EndValue = new CommandScale(1,21),
                        Line = 70555,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 66175,
                        EndTime = 66275,
                        StartValue = 0.2337775,
                        EndValue = 0,
                        Line = 70556,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 66279,
                        EndTime = 66379,
                        StartValue = 0,
                        EndValue = 0.2337775,
                        Line = 70557,
                    },
                        new MoveCommand()
                    {
                        Identifier = "M",
                        Easing = OsbEasing.None,
                        StartTime = 66279,
                        EndTime = 66479,
                        StartValue = new CommandPosition(291.7983,0),
                        EndValue = new CommandPosition(391.7983,480),
                        Line = 70558,
                    },
                        new RotateCommand()
                    {
                        Identifier = "R",
                        Easing = OsbEasing.None,
                        StartTime = 66279,
                        EndTime = 66479,
                        StartValue = -0.22,
                        EndValue = -0.22,
                        Line = 70559,
                    },
                        new VectorScaleCommand()
                    {
                        Identifier = "V",
                        Easing = OsbEasing.None,
                        StartTime = 66279,
                        EndTime = 66479,
                        StartValue = new CommandScale(1,52),
                        EndValue = new CommandScale(1,53),
                        Line = 70560,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 66379,
                        EndTime = 66479,
                        StartValue = 0.2337775,
                        EndValue = 0,
                        Line = 70561,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 66483,
                        EndTime = 66583,
                        StartValue = 0,
                        EndValue = 0.2337775,
                        Line = 70562,
                    },
                        new MoveCommand()
                    {
                        Identifier = "M",
                        Easing = OsbEasing.None,
                        StartTime = 66483,
                        EndTime = 66683,
                        StartValue = new CommandPosition(212.5144,0),
                        EndValue = new CommandPosition(312.5144,480),
                        Line = 70563,
                    },
                        new RotateCommand()
                    {
                        Identifier = "R",
                        Easing = OsbEasing.None,
                        StartTime = 66483,
                        EndTime = 66683,
                        StartValue = -0.22,
                        EndValue = -0.22,
                        Line = 70564,
                    },
                        new VectorScaleCommand()
                    {
                        Identifier = "V",
                        Easing = OsbEasing.None,
                        StartTime = 66483,
                        EndTime = 66683,
                        StartValue = new CommandScale(1,26),
                        EndValue = new CommandScale(1,29),
                        Line = 70565,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 66583,
                        EndTime = 66683,
                        StartValue = 0.2337775,
                        EndValue = 0,
                        Line = 70566,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 66687,
                        EndTime = 66787,
                        StartValue = 0,
                        EndValue = 0.2337775,
                        Line = 70567,
                    },
                        new MoveCommand()
                    {
                        Identifier = "M",
                        Easing = OsbEasing.None,
                        StartTime = 66687,
                        EndTime = 66887,
                        StartValue = new CommandPosition(363.5788,0),
                        EndValue = new CommandPosition(463.5788,480),
                        Line = 70568,
                    },
                        new RotateCommand()
                    {
                        Identifier = "R",
                        Easing = OsbEasing.None,
                        StartTime = 66687,
                        EndTime = 66887,
                        StartValue = -0.22,
                        EndValue = -0.22,
                        Line = 70569,
                    },
                        new VectorScaleCommand()
                    {
                        Identifier = "V",
                        Easing = OsbEasing.None,
                        StartTime = 66687,
                        EndTime = 66887,
                        StartValue = new CommandScale(1,17),
                        EndValue = new CommandScale(1,21),
                        Line = 70570,
                    },
                        new FadeCommand()
                    {
                        Identifier = "F",
                        Easing = OsbEasing.None,
                        StartTime = 66787,
                        EndTime = 66887,
                        StartValue = 0.2337775,
                        EndValue = 0,
                        Line = 70571,
                    },
                },
            };
            var result = RedundancyAnalyser.Analyse(visualElement);

            Assert.True(result.Count > 0);

        }
    }
}

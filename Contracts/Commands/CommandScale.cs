﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Commands
{
    public class CommandScale
    {
        public CommandScale() { }
        public CommandScale(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double X { get; set; }
        public double Y { get; set; }

        public override string ToString()
        {
            return $"{X.ToString(System.Globalization.CultureInfo.InvariantCulture)},{Y.ToString(System.Globalization.CultureInfo.InvariantCulture)}";
        }
    }
}

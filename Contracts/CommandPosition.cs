using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public class CommandPosition
    {
        public CommandPosition() { }

        public CommandPosition(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; set; }
        public double Y { get; set; }
    }
}

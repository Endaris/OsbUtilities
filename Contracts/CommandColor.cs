using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public class CommandColor
    {
        public CommandColor() { }
        public CommandColor(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }

        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }

        public override string ToString()
        {
            return $"{R},{G},{B}";
        }
    }
}

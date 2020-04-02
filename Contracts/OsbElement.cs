using System;
using System.Collections.Generic;
using System.Drawing;
using Contracts.Enums;

namespace Contracts
{
    public class OsbElement
    {
        public OsbLayer Layer { get; set; }
        public OsbOrigin Anchor { get; set; }
        public int LineNumber { get; set; }
        public string LineInitialisation { get; set; }
        public string Path { get; set; }
        public Rectangle Sprite { get; set; }
        public IEnumerable<IOsbCommand> Commands { get; set; }
        public int zIndex { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
    }
}

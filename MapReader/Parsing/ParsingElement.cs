using System;
using System.Collections.Generic;
using System.Text;

namespace MapReader.Parsing
{
    public class ParsingElement
    {
        public List<string> Lines { get; set; } = new List<string>();
        public int LineStart { get; set; }
    }
}

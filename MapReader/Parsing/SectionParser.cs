using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MapReader.Parsing
{
    public static class SectionParser
    {
        public static List<string> GetSection(List<string> content, string sectionStart)
        {
            int index = content.IndexOf(sectionStart);

            if (index >= 0)
            {
                content = content.GetRange(index, content.Count - index);
                int endIndex = content.IndexOf(content.Find(l => l == Environment.NewLine));
                if (endIndex >= 0)
                    return content.GetRange(0, endIndex);
                else
                    return content;
            }
            else
                return new List<string>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MapReader.Parsing;

namespace MapReader.Test
{
    public static class ParsingElementResources
    {
        private static Random random = new Random();

        public static ParsingElement Parsify(string testString)
        {
            return new ParsingElement()
            {
                Lines = testString.Split(Environment.NewLine).ToList(),
                LineStart = random.Next(0, 10000)
            };
        }


        public static string doubleLoopTestString = @"Sprite,Background,Centre,""SB\circle.png"",0,0
 L,11599,24
  S,10,0,624,0.24,0.2
  S,9,624,724,0.2,0.24
 L,11599,24
  C,0,0,724,186,153,255,255,180,50
 M,0,10599,10801,440,240";

        public static string endTriggerTestString = @"Sprite,Background,CentreRight,""SB\pix.png"",0,0
 M,5,290749,295762,-83,34,-98,42.66026
 M,5,295762,300775,-98,42.66026,-98,25.33975
 T,HitSoundSoftClap,24665,36177
  V,10,0,500,24,6,24,2";
    }
}

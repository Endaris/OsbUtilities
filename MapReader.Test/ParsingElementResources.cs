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

        public static string moveDefaultValueTestString = @"Sprite,Background,Centre,""SB\circle.png"",27,304
 M,0,10599,10801,440,240
 MX,0,10801,12432,440,590
 MY,0,10801,12432,240,480";

        public static string brokenWarningLevel1 = @"Sprite,Background,Centre,""sb\l.png"",0,0
 L,283852,2
  MY,0,0,17594,188,-100
  MY,0,17594,36654,500,188
 L,283852,2
  MX,1,0,7675,159,109
  MX,2,7675,15351,109,159
  MX,1,15351,23027,159,209
  MX,2,23027,30702,209,159
 L,283943,5
  F,0,0,4357,0.15,0.5
  S,0,0,4357,0.02045512,0.02659166
  F,0,4357,8715,0.5,0.15
  S,0,4357,8715,0.02659166,0.02045512
 P,0,280095,337488,A
 F,2,280277,283943,0,0.15
 C,2,283943,287608,0,0,0,87,87,43
 C,0,287608,312735,87,87,43,108,65,32
 C,1,312735,327397,108,65,32,0,0,0
 F,0,327488,,0
 S,0,327488,,0
 C,0,327488,,0,0,0";
    }
}

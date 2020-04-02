using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public class Storyboard
    {
        public IEnumerable<OsbElement> OsbElements { get; set; } = new List<OsbElement>();

        //Storyboarded Sounds
    }
}

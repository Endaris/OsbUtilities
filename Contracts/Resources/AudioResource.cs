using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Resources
{
    public class AudioResource : IResource
    {
        public string RelativePath { get; private set; }
        public string FullPath { get; private set; }
        public long FileSize { get; private set; }
    }
}

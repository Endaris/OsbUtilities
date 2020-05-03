using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Resources
{
    public interface IResource
    {
        string RelativePath { get; }
        long FileSize { get; }
    }
}

using Microsoft.Extensions.CommandLineUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.VisualStudio.Services.Contrib.Tools
{
    public interface IOption
    {
        string Name { get; }
    }
}

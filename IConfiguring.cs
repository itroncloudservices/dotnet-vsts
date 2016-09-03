using Microsoft.Extensions.CommandLineUtils;
using System;

namespace Microsoft.VisualStudio.Services.Contrib.Tools
{
    public interface IConfiguring<T>
    {
        void Configure(T target);
    }
}
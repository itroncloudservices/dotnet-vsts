using Microsoft.Extensions.CommandLineUtils;
using System;

namespace Microsoft.VisualStudio.Services.Contrib.Tools
{
    public interface ICommandOption : IOption
    {
        string Description { get; }
        string Template { get; }
        CommandOption Option { get; set; }
    }
}
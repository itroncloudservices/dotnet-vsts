using Microsoft.Extensions.CommandLineUtils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.VisualStudio.Services.Contrib.Tools
{
    public static class Options
    {
        public static void AddOptions(this CommandLineApplication app, IEnumerable<IOption> options)
        {
            foreach (var commandOption in options.OfType<ICommandOption>())
            {
                var configuring = commandOption as IConfiguring<CommandOption>;
                if (configuring != null)
                {
                    commandOption.Option = app.Option(commandOption.Template, commandOption.Description, CommandOptionType.SingleValue, configuring.Configure);
                }
                else
                { 
                    commandOption.Option = app.Option(commandOption.Template, commandOption.Description, CommandOptionType.SingleValue);
                }
            }
        }

        public class ApiVersion : ICommandOption
        {
            public string Description => "Version of the API to use.";
            public string Name => nameof(ApiVersion);
            public CommandOption Option { get; set; }
            public string Template => "-v|--api-version";
        }

        public class BaseRequestUri : IOption
        {
            public string Name => nameof(BaseRequestUri);
        }

        public class Instance : ICommandOption
        {
            public string Description => "VS Team Services account ({account}.visualstudio.com) or TFS server ({server:port}).";
            public string Name => nameof(Instance);
            public CommandOption Option { get; set; }
            public string Template => "-i|--instance";
        }

        public class RequestUri : IOption
        {
            public string Name => nameof(RequestUri);
        }

        public class Skip : ICommandOption
        {
            public string Description => "Number of team projects to skip. Defaults to 0.";
            public string Name => nameof(Skip);
            public CommandOption Option { get; set; }
            public string Template => "-s|--skip";
        }

        public class StateFilter : ICommandOption
        {
            public string Description => "Return team projects in a specific team project state ('WellFormed','CreatePending','Deleting','New','All'). Defaults to 'WellFormed'.";
            public string Name => nameof(StateFilter);
            public CommandOption Option { get; set; }
            public string Template => "-f|--state-filter";
        }

        public class Top : ICommandOption
        {
            public string Description => "Number of team projects to return. Defaults to 100.";
            public string Name => nameof(Top);
            public CommandOption Option { get; set; }
            public string Template => "-t|--top";
        }
    }
}
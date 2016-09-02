using System;
using Microsoft.Extensions.CommandLineUtils;

namespace ConsoleApplication
{
    public class Program
    {
        public static int Main(string[] args)
        {
            var app = new CommandLineApplication
            {
                Name = "vsts",
                Description = "Interacts with a visual studio service via commands",
                FullName = "vsts - Visual Studio Team Services CLI"
            };

            app.Command("projects", c =>
            {
                c.Description = "Get a list of team projects";

                var instanceOption = c.Option("-i|--instance", "VS Team Services account ({account}.visualstudio.com) or TFS server ({server:port}).", CommandOptionType.SingleValue);
                var apiVersionOption = c.Option("-v|--api-version", "Version of the API to use.", CommandOptionType.SingleValue);
                var stateFilterOption = c.Option("-f|--state-filter", "Return team projects in a specific team project state ('WellFormed','CreatePending','Deleting','New','All'). Defaults to 'WellFormed'.", CommandOptionType.SingleValue);
                var topOption = c.Option("-t|--top", "Number of team projects to return. Defaults to 100.", CommandOptionType.SingleValue);
                var skipOption = c.Option("-s|--skip", "Number of team projects to skip. Defaults to 0.", CommandOptionType.SingleValue);

                c.HelpOption("-?|-h|--help");

                c.OnExecute(() =>
                {
                    return 0;
                });
            });

            // show the help for the application
            app.OnExecute(() =>
            {
                app.ShowHelp();
                return 2;
            });

            return app.Execute(args);
        }
    }
}

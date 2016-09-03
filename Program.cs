using System;
using Microsoft.Extensions.CommandLineUtils;

namespace Microsoft.VisualStudio.Services.Contrib.Tools
{
    public class Program
    {
        public static int Main(string[] args)
        {
            var app = new CommandLineApplication
            {
                Name = "dotnet-vsts",
                Description = "Command line tool to manage Visual Studio Team Services.",
                FullName = "dotnet-vsts - Visual Studio Team Services CLI"
            };

            app.Command("projects", Commands.Projects);

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

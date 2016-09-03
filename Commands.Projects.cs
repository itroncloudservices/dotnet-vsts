using Microsoft.Extensions.CommandLineUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.VisualStudio.Services.Contrib.Tools
{
    public static partial class Commands
    {
        public static void Projects(CommandLineApplication c)
        {
            c.Description = $"Commands to manage projects";
            c.Command("list", ProjectsList);
            c.HelpOption("-?|-h|--help");
            c.OnExecute(() =>
            {
                c.ShowHelp();
                return 2;
            });
        }

        public static void ProjectsList(CommandLineApplication c)
        {
            c.Description = "Get a list of team projects";
            var options = ProjectsListOptions();
            c.AddOptions(options);
            c.HelpOption("-?|-h|--help");

            c.OnExecute(() =>
            {
                return 0;
            });
        }

        static IEnumerable<IOption> ProjectsListOptions()
        {
            yield return new Options.RequestUri();
            yield return new Options.Instance();
            yield return new Options.ApiVersion();
            yield return new Options.StateFilter();
            yield return new Options.Top();
            yield return new Options.Skip();
        }
    }
}

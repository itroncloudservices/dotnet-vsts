# dotnet-vsts
`dotnet-vsts` makes use of the new [.Net Core tool extensibility](https://docs.microsoft.com/en-us/dotnet/articles/core/tools/extensibility) to provide remote interaction with a VSTS/VSO/TFS instance.

# Quick Start

.NET Core Tools are installed into a user's NuGet cache and are globally available thereafter. To install initially for a user, you will need a host project that requests the use of the `Microsoft.VisualStudio.Services.Contrib.Tools` package.

## Ensure you have .NET Core 1.0 installed

Browse to [the .Net Core Site](https://www.microsoft.com/net/core) and follow the instructions for installing the latest version.

You should be able to execute `dotnet` at the command line:

```
dotnet --version
```

## Create a host project

In a new directory (perhaps named for your VSTS instance) [create a new dotnet project](https://docs.microsoft.com/en-us/dotnet/articles/core/tools/dotnet-new):

```
dotnet new --type console --lang C#
```

## Update the host `project.json` to include the `dotnet-vsts` tool

Add a `tools` section like:
```json
{
	...
	"tools": {
		"Microsoft.VisualStudio.Services.Contrib.Tools": "0.1.0-*"
	},
	...
}
```

## restore

Execute a restore:

```
dotnet restore
```

## ensure the tool builds/runs

```
dotnet vsts -h
```

You should be able to see the help output, which looks like this:

```
YADA
```
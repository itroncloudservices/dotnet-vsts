# vsts-cli
.NET Core CLI for interacting with VSTS/VSO

# Quick Start

This tool is intended to be a way to interact with VSTS via a .NET Core environment. Rather than maintaining a binary release, you obtain this tool by pulling the source and building it yourself. Don't worry, it's easy!

## Before you start

There are two pre-requisites to running this application:

### Ensure you have .NET Core 1.0 installed

Browse to [the .Net Core Site](https://www.microsoft.com/net/core) and follow the instructions for installing the latest version.

You should be able to execute `dotnet` at the command line:

```
dotnet --version
```

### Ensure you have `git` installed

Follow the [GitHub documentation for cloning a repository](https://help.github.com/articles/cloning-a-repository/) to install and configure a git client of your choice.

You should be able to execute `git` in some way:

```
git --version
```

## clone this repository

Navigate to a desired parent directory (such as `~/src/` or `c:\src`):

```
cd ~/src
```

Do a git clone of this repository. On the command line it would look like:

```
git clone https://github.com/itroncloudservices/vsts-cli.git vsts-cli
```

Note that no authentication is needed as this is a public repository.

## restore

Navigate to the newly cloned directory:

```
cd vsts-cli
```

And execute a restore:

```
dotnet restore
```

## ensure the tool builds/runs

```
dotnet run
```

You should be able to see the help output, which looks like this:

```
YADA
```

## set secrets

To securely remember what VSTS instance you wish to connect to (and your credentials) this tool uses [the secret manager](https://docs.asp.net/en/latest/security/app-secrets.html).

From the cloned directory run the secret tool to set the VSTS instance name, your username, and your credentials (a PAT is recommended).

## run the `vsts` command to interact with your VSTS instance
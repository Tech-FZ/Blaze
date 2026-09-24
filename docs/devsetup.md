# Setting up the development environment

Generally, there are three different ways to set up a development environment for .NET. One is using Visual Studio on Windows, another is using the .NET CLI. However, we're gonna use the Visual Studio Code method. Hosts are recommended to go the [easy route](serversetup.md) instead.

## Prerequisites

- A Windows, macOS or Linux system.
- A working MySQL server. The setup guide is [here](mysqlsetup.md).
- An existing [.NET 10](https://dotnet.microsoft.com/en-us/download/dotnet/10.0) SDK install. Microsoft provides documentation on the installation of .NET for [Windows](https://learn.microsoft.com/en-us/dotnet/core/install/windows), [macOS](https://learn.microsoft.com/en-us/dotnet/core/install/macos) and [Linux](https://learn.microsoft.com/en-us/dotnet/core/install/linux).

## Installation of the programs

1. Download and install [Visual Studio Code](https://code.visualstudio.com/download?_exp_download=fb315fc982) for your system.
2. Download and install Git. While most Linux distributions should have that installable via their package manager (see [this guide](https://git-scm.com/install/linux)), Windows users can download it [here](https://git-scm.com/install/windows). macOS users will have to rely on [this guide](https://git-scm.com/install/mac).
3. Download and install the [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) extension for Visual Studio Code.
4. Open a terminal in Visual Studio Code by going to Terminal > New Terminal.
5. On that terminal, type in `dotnet --version` to verify .NET is installed.
6. Close Visual Studio Code.

## Preparing the code

1. Go to directory and open a terminal there.
2. Type in `git clone https://github.com/Tech-FZ/Blaze.git`.
3. Open Visual Studio Code in the code directory.
4. If you trust this code, trust the instance.
5. Open a C# or Razor file.
6. Open a terminal on Visual Studio Code.
7. Type in `dotnet user-secrets init`
8. Type in `dotnet user-secrets "ConnectionStrings:BlazeDbContext" "server=(insert-server-here);database=blazedb;user=(insert-user-here);password=(insert-password-here)"`. Replace the (insert-x-here) variables with your actual server connection information. Leave the password parameter out if there is no password.
9. Press <kbd>F5</kbd> to run the program. You may need to set it up with C# > Launch Startup Project.
10. If your MySQL server is reachable, you should be greeted by your web browser opening the homepage of this Web App.
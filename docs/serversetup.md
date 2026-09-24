# Setting up a Blaze server

While developers can [set up a development environment](devsetup.md), for those who just want to host Blaze on their machines, it isn't too nice.

## Prerequisites

- A Windows, macOS or Linux system.
- A working MySQL server. The setup guide is [here](mysqlsetup.md).
- An existing [.NET 10](https://dotnet.microsoft.com/en-us/download/dotnet/10.0) ASP.NET Core Runtime install. Microsoft provides documentation on the installation of .NET for [Windows](https://learn.microsoft.com/en-us/dotnet/core/install/windows), [macOS](https://learn.microsoft.com/en-us/dotnet/core/install/macos) and [Linux](https://learn.microsoft.com/en-us/dotnet/core/install/linux).
- A text editor

## Installation of the program

1. Go to the [Blaze Releases](https://github.com/Tech-FZ/Blaze/releases) and download the latest version.
2. Unzip the ZIP file.
3. Open the `appsettings.json` file.
4. Type in `"ConnectionStrings:BlazeDbContext": "server=(insert-server-here);database=blazedb;user=(insert-user-here);password=(insert-password-here)"` within the first layer of `{}`. Replace the (insert-x-here) variables with your actual server connection information. Leave the password parameter out if there is no password.
5. Run `Test-Demo1`. If everything works correctly, you can open a web browser and access `localhost:5000` (or whatever the terminal puts out as an address).
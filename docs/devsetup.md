# Entwicklungsumgebung aufsetzen

Allgemein gibt es drei verschiedene Wege, eine Entwicklungsumgebung für .NET einzurichten. Eines verläuft über Visual Studio unter Windows, ein anderes über die .NET CLI. Allerdings werden wir die Methode mit Visual Studio Code benutzen. Hosts wird empfohlen, die [einfache Route](serversetup.md) zu nehmen. Die externen Links sind alle auf Englisch.

## Anforderungen

- Ein System mit Windows, macOS oder Linux
- Ein funktionierender MySQL-Server. Die Setup-Anleitung ist [hier](mysqlsetup.md).
- Eine existierende Installation der [.NET 10](https://dotnet.microsoft.com/en-us/download/dotnet/10.0)-SDK. Microsoft stellt Dokumentationen über die Installation von .NET unter [Windows](https://learn.microsoft.com/en-us/dotnet/core/install/windows), [macOS](https://learn.microsoft.com/en-us/dotnet/core/install/macos) und [Linux](https://learn.microsoft.com/en-us/dotnet/core/install/linux) bereit.

## Installation der Programme

1. Laden Sie [Visual Studio Code](https://code.visualstudio.com/download?_exp_download=fb315fc982) für Ihr System herunter und installieren Sie es.
2. Laden Sie Git herunter und installieren Sie es. Die meisten Linux-Distributionen sollten das über ihren Paketmanager installiert haben (siehe [hier](https://git-scm.com/install/linux)), währenddessen können Windows-Nutzer Git [hier](https://git-scm.com/install/windows) installieren. macOS-Benutzer müssen sich auf [diese Anleitung](https://git-scm.com/install/mac) verlassen.
3. Installieren Sie die [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)-Erweiterung für Visual Studio Code.
4. Öffnen Sie in Visual Studio Code mit Terminal > New Terminal ein neues Terminal.
5. Geben Sie in diesem Terminal `dotnet --version` ein, um sicherzustellen, dass .NET installiert ist.
6. Schließen Sie Visual Studio Code.

## Codevorbereitung

1. Bereiten Sie ein Verzeichnis vor und öffnen Sie dort ein Terminal.
2. Geben Sie `git clone https://github.com/Tech-FZ/Blaze.git` ein. Der main-Branch ist auf Englisch.
3. Öffnen Sie Visual Studio Code im Code-Ordner.
4. Wenn Sie dem Code vertrauen (!), vertrauen Sie bitte dieser Instanz.
5. Öffnen Sie eine C#- oder Razor-Datei.
6. Öffnen Sie einen Terminal in Visual Studio Code.
7. Bitte geben Sie `dotnet user-secrets init` ein.
8. Geben Sie `dotnet user-secrets "ConnectionStrings:BlazeDbContext" "server=(insert-server-here);database=blazedb;user=(insert-user-here);password=(insert-password-here)"` ein. Ersetzen Sie die (insert-x-here)-Variablen durch Ihre eigentlichen Serververbindungsinformationen. Wenn kein Passwort vergeben ist, lassen Sie den password-Parameter weg.
9. Drücken Sie <kbd>F5</kbd>, um das Programm auszuführen. Sie müssen es ggf. mit C# > Launch Startup Project auswählen.
10. Ist Ihr MySQL-Server erreichbar, werden Sie von Ihrem Webbrowser mit der Startseite dieser Web-App begrüßt.
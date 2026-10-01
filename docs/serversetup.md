# Blaze-Server aufsetzen

Während Entwickler [eine Entwicklungsumgebung aufsetzen](devsetup.md) können, ist es nicht so gut, dies zu tun, wenn man nur auf seinem System Blaze hosten möchte. Die externen Links sind alle auf Englisch.

## Anforderungen

- Ein System mit Windows, macOS oder Linux.
- Ein funktionierender MySQL-Server. Die Setup-Anleitung ist [hier](mysqlsetup.md).
- Eine existierende Installation der [.NET 10](https://dotnet.microsoft.com/en-us/download/dotnet/10.0) ASP.NET Core Runtime. Microsoft stellt Dokumentationen über die Installation von .NET unter [Windows](https://learn.microsoft.com/en-us/dotnet/core/install/windows), [macOS](https://learn.microsoft.com/en-us/dotnet/core/install/macos) und [Linux](https://learn.microsoft.com/en-us/dotnet/core/install/linux) bereit.
- Ein Text-Editor

## Installation des Programms

1. Besuchen Sie die [Blaze Releases](https://github.com/Tech-FZ/Blaze/releases) und laden Sie die neueste Version herunter.
2. Entpacken Sie die ZIP-Datei.
3. Öffnen Sie die `appsettings.json`-Datei.
4. Tippen Sie `"ConnectionStrings:BlazeDbContext": "server=(insert-server-here);database=blazedb;user=(insert-user-here);password=(insert-password-here)"` innerhalb der ersten `{}`-Ebene ein. Ersetzen Sie die (insert-x-here)-Variablen durch Ihre eigentlichen Serververbindungsinformationen. Wenn kein Passwort vergeben ist, lassen Sie den password-Parameter weg.
5. Führen Sie `Test-Demo1` aus. Wenn alles korrekt funktioniert, können Sie über einen Webbrowser `localhost:5000` (oder was auch immer der Terminal ausgibt) aufrufen.
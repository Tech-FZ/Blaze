# MySQL aufsetzen

Die externen Links sind auf Englisch.

## Anforderungen

- Eine Windows-, macOS- or Linux-Installation

## Installation

1. Besuchen Sie die [MySQL Community](https://dev.mysql.com/downloads/)-Downloadseite.
2. Suchen Sie sich den Download für Ihr System aus.
    - Die Yum-Repository ist für RHEL/Fedora/Oracle-basierte Linux-Distributionen
    - Die APT-Repository ist für Debian/Ubuntu-basierte Systeme
    - Die SUSE-Repository ist für (open)SUSE
    - Windows-Nutzer können den MySQL Installer herunterladen.
    - macOS-Benutzer müssen die Komponenten einzeln herunterladen und installieren. Sorry. :(
3. Befolgen Sie die Setup-Schritte (mehr Dokumentation folgt)

## Datenbank aufsetzen

1. Öffnen Sie die MySQL Workbench
2. Verbinden Sie sich mit dem zu benutzenden Server.
3. Gehen Sie zu `sqlScripts/SetupDatabase.sql` im Code und kopieren Sie dessen Inhalt in den Query.
    - Ich empfehle Ihnen, die Query zu lesen und zu verstehen, bevor Sie diesen ausführen.
4. Führen Sie diese Query aus.
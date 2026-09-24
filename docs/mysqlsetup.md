# Setup MySQL

## Prerequisites

- A Windows, macOS or Linux installation

## Installation

1. Go to the [MySQL Community](https://dev.mysql.com/downloads/) download page.
2. Choose the respective download for your system.
    - The Yum Repository is for RHEL/Fedora/Oracle-based Linux distros
    - The APT Repository is for Debian/Ubuntu-based systems
    - The SUSE Repository is for (open)SUSE
    - Windows users may download the MySQL Installer.
    - macOS users will need to download and install the components one by one. Sorry. :(
3. Follow the instructions of the setup (further documentation coming soon)

## Setting up the database

1. Open the MySQL Workbench
2. Connect to the server you want to use.
3. Go to `sqlScripts/SetupDatabase.sql` and copy its contents to the query.
    - I encourage you to read and understand the query before executing it.
4. Run the query.
CREATE DATABASE BlazeDb;
USE BlazeDb;

CREATE TABLE Genders (
    Id INT NOT NULL PRIMARY KEY,
    LongName VARCHAR(50) NOT NULL,
    ShortName VARCHAR(50) NOT NULL
);

CREATE TABLE Companies (
    Id INT NOT NULL PRIMARY KEY,
    Name VARCHAR(50) NOT NULL
);

CREATE TABLE Characters (
    Id INT NOT NULL PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    BirthDate DATE NOT NULL,
    SelectedGenderId INT NOT NULL,
    IsStudent BIT NOT NULL DEFAULT 0,
    SelectedCompanyId INT NOT NULL
);

CREATE TABLE SocialMedias (
    Id INT NOT NULL PRIMARY KEY,
    Platform VARCHAR(50) NOT NULL,
    Link VARCHAR(255) NOT NULL,
    SelectedCompanyId INT NULL,
    SelectedCharacterId INT NULL
);
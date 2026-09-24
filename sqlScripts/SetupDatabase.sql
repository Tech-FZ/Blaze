CREATE DATABASE BlazeDb;
USE BlazeDb;

CREATE TABLE Genders (
    Id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    LongName VARCHAR(50) NOT NULL,
    ShortName VARCHAR(50) NOT NULL
);

CREATE TABLE Companies (
    Id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(50) NOT NULL,
    NetWorth BIGINT NOT NULL DEFAULT 0
);

CREATE TABLE Characters (
    Id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(50) NOT NULL,
    BirthDate DATE NOT NULL,
    SelectedGenderId INT NOT NULL,
    IsStudent BIT NOT NULL DEFAULT 0,
    SelectedCompanyId INT NOT NULL,
    CONSTRAINT fk_Company_ch FOREIGN KEY (SelectedCompanyId) REFERENCES Companies(Id),
    CONSTRAINT fk_Gender_ch FOREIGN KEY (SelectedGenderId) REFERENCES Genders(Id)
);

CREATE TABLE SocialMedias (
    Id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Platform VARCHAR(50) NOT NULL,
    Link VARCHAR(255) NOT NULL,
    SelectedCompanyId INT NULL,
    SelectedCharacterId INT NULL,
    CONSTRAINT fk_Company_sm FOREIGN KEY (SelectedCompanyId) REFERENCES Companies(Id),
    CONSTRAINT fk_Character_sm FOREIGN KEY (SelectedCharacterId) REFERENCES Characters(Id)
);
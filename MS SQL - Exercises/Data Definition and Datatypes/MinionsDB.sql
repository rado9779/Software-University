--Problem 1. Create Database

CREATE DATABASE Minions

--Problem 2. Create Tables

CREATE TABLE Minions
(
  Id INT NOT NULL PRIMARY KEY,
  [Name] NVARCHAR (100),
  Age INT
)

CREATE TABLE Towns
(
  Id INT NOT NULL PRIMARY KEY,
  [Name] NVARCHAR (100)
)

--Problem 3. Alter Minions Table

ALTER TABLE Minions
ADD TownId INT NOT NULL FOREIGN KEY REFERENCES Towns(Id)

--Problem 4 Insert Records in Both Tables

INSERT INTO Minions (Id,[Name],Age,TownId) VALUES
(1, 'Kevin', 22, 1),
(2, 'Bob', 15, 3),
(3, 'Steward', NULL, 2)

INSERT INTO Towns (Id,[Name]) VALUES
(1,'Sofia'),
(2,'Plovdiv'),
(3, 'Varna')

--Problem 5. Truncate Table Minions

TRUNCATE TABLE Minions

--Problem 6. Drop All Tables

DROP TABLE Towns
DROP TABLE Minions

--Problem 8. Create Table Users

CREATE TABLE Users
(
  Id INT PRIMARY KEY IDENTITY,
  Username VARCHAR(30) UNIQUE NOT NULL,
  [Password] VARCHAR(26) NOT NULL,
  ProfilePicture IMAGE,
  LastLoginTime DATETIME,
  IsDeleted VARCHAR(5) NOT NULL CHECK(IsDeleted = 'true' OR IsDeleted = 'false')
)

INSERT INTO Users (Username, [Password], ProfilePicture,LastLoginTime,IsDeleted) VALUES
('USER1',1,NULL,NULL,'true'),
('USER2',12,NULL,NULL,'true'),
('USER3',123,NULL,NULL,'true'),
('USER4',1234,NULL,NULL,'true'),
('USER5',12345,NULL,NULL,'true')

--Problem 9. Change Primary Key

ALTER TABLE Users
DROP PRIMARY KEY

ALTER TABLE Users
ADD CONSTRAINT PK_UserId PRIMARY KEY (Id,Username)

--Problem 10. Add Check Constraint

ALTER TABLE Users
ADD CONSTRAINT MinLength CHECK (Len(Password) >= 5)

--Problem 11. Set Default Value of a Field

ALTER TABLE Users
ADD DEFAULT GETDATE() FOR LastLoginTime

--Problem 12. Set Unique Field
ALTER TABLE Users
DROP CONSTRAINT PK_UserId

ALTER TABLE Users
ADD CONSTRAINT PK_Id
PRIMARY KEY (Id)

ALTER TABLE Users
ADD CONSTRAINT UniqueUsername
UNIQUE(Username)

ALTER TABLE Users
ADD CONSTRAINT MinLength CHECK (LEN(Username) >= 3)








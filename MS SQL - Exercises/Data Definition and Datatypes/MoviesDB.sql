--Problem 13. Movies Database

CREATE DATABASE Movies
USE Movies

CREATE TABLE Directors 
(
  Id INT PRIMARY KEY IDENTITY,
  DirectorName NVARCHAR(50) NOT NULL,
  Notes NVARCHAR(MAX)
)

CREATE TABLE Genres  
(
  Id INT PRIMARY KEY IDENTITY,
  GenreName NVARCHAR(50) NOT NULL,
  Notes NVARCHAR(MAX)
)

CREATE TABLE Categories   
(
  Id INT PRIMARY KEY IDENTITY,
  CategoryName NVARCHAR(50) NOT NULL,
  Notes NVARCHAR(MAX)
)

CREATE TABLE Movies 
(
  Id INT PRIMARY KEY IDENTITY,
  Title NVARCHAR(50) NOT NULL,
  DirectorId INT FOREIGN KEY REFERENCES Directors(Id),
  CopyrightYear INT NOT NULL,
  [Length] INT NOT NULL,
  GenreId INT FOREIGN KEY REFERENCES Genres(Id),
  CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
  Rating INT NOT NULL,
  Notes NVARCHAR(MAX)
)

INSERT INTO Directors(DirectorName, Notes) VALUES
('Director1','note1'),
('Director2','note1'),
('Director3','note1'),
('Director4','note1'),
('Director5','note1')

INSERT INTO Genres (GenreName,Notes) VALUES
('Genre1','note1'),
('Genre2','note1'),
('Genre3','note1'),
('Genre4','note1'),
('Genre5','note1')

INSERT INTO Categories (CategoryName,Notes) VALUES
('Category1','Note1'),
('Category2','Note1'),
('Category3','Note1'),
('Category4','Note1'),
('Category5','Note1')

INSERT INTO Movies (Title, DirectorId, CopyrightYear, [Length], GenreId, CategoryId, Rating, Notes) VALUES
('Movie1',1,1111,1,1,1,1,'note1'),
('Movie2',2,2222,2,2,2,2,'note2'),
('Movie3',3,3333,3,3,3,3,'note3'),
('Movie4',4,4444,4,4,4,4,'note4'),
('Movie5',5,5555,5,5,5,5,'note5')

SELECT * FROM Movies



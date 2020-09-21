--Problem 1. One-To-One Relationship

CREATE TABLE Persons
(
  PersonID INT IDENTITY NOT NULL,
  FirstName NVARCHAR(50) NOT NULL,
  Salary DECIMAL(7,2) NOT NULL,
  PassportID INT NOT NULL
)

CREATE TABLE Passports
(
  PassportID INT NOT NULL,
  PassportNumber NVARCHAR(50) NOT NULL
)

INSERT INTO Persons (FirstName,Salary,PassportID) VALUES
('Roberto',43300.00,102),
('Tom',56100.00,103),
('Yana',60200.00,101)

INSERT INTO Passports (PassportID,PassportNumber) VALUES
(101,'N34FG21B'),
(102,'K65LO4R7'),
(103,'ZE657QP2')

ALTER TABLE Persons
ADD PRIMARY KEY (PersonID)

ALTER TABLE Passports
ADD PRIMARY KEY (PassportID)

ALTER TABLE Persons
ADD FOREIGN KEY (PassportID) REFERENCES Passports(PassportID)

--Problem 2. One-To-Many Relationship

CREATE TABLE Manufacturers
(
   ManufacturerID INT PRIMARY KEY IDENTITY NOT NULL,
   [Name] NVARCHAR(50) NOT NULL,
   EstablishedOn DATE NOT NULL
)

CREATE TABLE Models
(
  ModelID INT PRIMARY KEY NOT NULL IDENTITY (101, 1),
  [Name] NVARCHAR(50) NOT NULL,
  ManufacturerID INT FOREIGN KEY REFERENCES Manufacturers(ManufacturerID)
)

INSERT INTO Manufacturers ([Name],EstablishedOn) VALUES
('BMW','07/03/1916'),
('Tesla','01/01/2003'),
('Lada','01/05/1966')

INSERT INTO Models ([Name],ManufacturerID) VALUES
('X1',1),
('i6',1),
('Model S',2),
('Model X',2),
('Model 3',3),
('Nova',3)

--Problem 3. Many-To-Many Relationship

CREATE TABLE Students
(
   StudentID INT PRIMARY KEY IDENTITY NOT NULL,
   [Name] NVARCHAR(50) NOT NULL
)

CREATE TABLE Exams
(
  ExamID INT PRIMARY KEY IDENTITY(101,1) NOT NULL,
  [Name] NVARCHAR(50) NOT NULL
)

CREATE TABLE StudentsExams
(
  StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
  ExamID INT FOREIGN KEY REFERENCES Exams(ExamID),
  CONSTRAINT PK_Students_Exams PRIMARY KEY(StudentID,ExamID)
)

INSERT INTO Students ([Name]) VALUES
('Mila'),
('Toni'),
('Ron')

INSERT INTO Exams ([Name]) VALUES
('SpringMVC'),
('Neo4j'),
('Oracle 11g')

INSERT INTO StudentsExams (StudentID,ExamID) VALUES
(1, 101),
(1, 102),
(2, 101),
(3, 103),
(2, 102),
(2, 103)

--Problem 4. Self-Referencing 

CREATE TABLE Teachers
(
  TeacherID INT PRIMARY KEY IDENTITY (101,1) NOT NULL,
  [Name] NVARCHAR(50) NOT NULL,
  ManagerID INT FOREIGN KEY REFERENCES Teachers(TeacherID)
)

INSERT INTO Teachers ([Name],ManagerID) VALUES
('John',NULL),
('Maya',106),
('Silvia',106),
('Ted',105),
('Mark',101),
('Greta',101)

--Problem 5. Online Store Database

CREATE DATABASE Store 
USE Store

CREATE TABLE Cities
(
  CityId INT PRIMARY KEY NOT NULL,
  [Name] VARCHAR(50) NOT NULL
)

CREATE TABLE Customers
(
  CustomerId INT PRIMARY KEY NOT NULL,
  [Name] VARCHAR(50) NOT NULL,
  Birthday DATE NOT NULL,
  CityId INT FOREIGN KEY REFERENCES Cities(CityId)
)

CREATE TABLE Orders
(
  OrderId INT PRIMARY KEY NOT NULL,
  CustomerId INT FOREIGN KEY REFERENCES Customers (CustomerId)
)

CREATE TABLE ItemTypes
(
  ItemTypeID INT PRIMARY KEY NOT NULL,
  [Name] VARCHAR(50) NOT NULL
)

CREATE TABLE Items
(
  ItemID INT PRIMARY KEY NOT NULL,
  [Name] VARCHAR(50) NOT NULL,
  ItemTypeID INT FOREIGN KEY REFERENCES ItemTypes(ItemTypeID)
)

CREATE TABLE OrderItems
(
  OrderId INT FOREIGN KEY REFERENCES Orders(OrderId),
  ItemID INT FOREIGN KEY REFERENCES Items(ItemID),
  CONSTRAINT PK_Order_Items PRIMARY KEY (OrderId,ItemID)
)

--Problem 6. University 
CREATE DATABASE University 
USE University

CREATE TABLE Subjects
(
  SubjectID INT PRIMARY KEY NOT NULL,
  SubjectName VARCHAR(50) NOT NULL
)

CREATE TABLE Majors
(
  MajorID INT PRIMARY KEY NOT NULL,
  [Name] VARCHAR(50) NOT NULL
)

CREATE TABLE Students
(
  StudentID INT PRIMARY KEY NOT NULL,
  StudentNumber VARCHAR(50) NOT NULL,
  StudentName VARCHAR(50) NOT NULL,
  MajorID INT FOREIGN KEY REFERENCES Majors(MajorID)
)

CREATE TABLE Agenda
(
  StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
  SubjectID INT FOREIGN KEY REFERENCES Subjects(SubjectID),
  CONSTRAINT PK_Agenda  PRIMARY KEY (StudentID,SubjectID)
)

CREATE TABLE Payments
(
  PaymentID INT PRIMARY KEY NOT NULL,
  PaymentDate DATE NOT NULL,
  PaymentAmount DECIMAL(10,2) NOT NULL,
  StudentID INT FOREIGN KEY REFERENCES Students(StudentID)
)

--Problem 9. Peaks in Rila

USE Geography

SELECT m.MountainRange,p.PeakName, p.Elevation FROM Mountains AS m
JOIN Peaks AS p ON p.MountainId = m.Id
WHERE m.MountainRange = 'Rila'
ORDER BY p.Elevation DESC

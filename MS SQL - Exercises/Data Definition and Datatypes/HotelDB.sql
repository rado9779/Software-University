--Problem 15. Hotel Database

CREATE DATABASE Hotel
USE Hotel

CREATE TABLE Employees 
(
  Id INT PRIMARY KEY NOT NULL IDENTITY,
  FirstName NVARCHAR(50) NOT NULL,
  LastName NVARCHAR(50) NOT NULL,
  Title NVARCHAR(50),
  Notes NVARCHAR(MAX)
)

CREATE TABLE Customers 
(
  AccountNumber INT PRIMARY KEY NOT NULL IDENTITY,
  FirstName NVARCHAR(50) NOT NULL,
  LastName NVARCHAR(50) NOT NULL,
  PhoneNumber INT NOT NULL,
  EmergencyName NVARCHAR(100),
  EmergencyNumber INT,
  Notes NVARCHAR(MAX)
)

CREATE TABLE RoomStatus 
(
  RoomStatus NVARCHAR(50) NOT NULL PRIMARY KEY,
  Notes NVARCHAR(MAX)
)

CREATE TABLE RoomTypes  
(
  RoomType NVARCHAR(50) NOT NULL PRIMARY KEY,
  Notes NVARCHAR(MAX)
)

CREATE TABLE BedTypes  
(
  BedType NVARCHAR(50) NOT NULL PRIMARY KEY,
  Notes NVARCHAR(MAX)
)

CREATE TABLE Rooms 
(
    RoomNumber INT PRIMARY KEY NOT NULL IDENTITY,
    RoomType NVARCHAR(50) FOREIGN KEY REFERENCES RoomTypes(RoomType),
	BedType NVARCHAR(50) FOREIGN KEY REFERENCES BedTypes(BedType),
	Rate INT,
    RoomStatus NVARCHAR(50) FOREIGN KEY REFERENCES RoomStatus(RoomStatus),
	Notes NVARCHAR(1000)
)

CREATE TABLE Payments (
	Id INT PRIMARY KEY NOT NULL IDENTITY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id) NOT NULL,
	PaymentDate DATETIME NOT NULL,
	AccountNumber INT FOREIGN KEY REFERENCES Customers(AccountNumber) NOT NULL,
	FirstDateOccupied DATE NOT NULL,
	LastDateOccupied DATE NOT NULL,
	TotalDays INT NOT NULL,
	AmountCharged INT NOT NULL,
	TaxRate INT NOT NULL,
	TaxAmount AS AmountCharged * TaxRate,
	PaymentTotal AS AmountCharged + AmountCharged * TaxRate,
	Notes NVARCHAR(MAX)
)

CREATE TABLE Occupancies (
	Id INT PRIMARY KEY NOT NULL IDENTITY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id) NOT NULL,
	DateOccupied DATE NOT NULL,
	AccountNumber INT FOREIGN KEY REFERENCES Customers(AccountNumber) NOT NULL,
	RoomNumber INT FOREIGN KEY REFERENCES Rooms(RoomNumber) NOT NULL,
	RateApplied INT NOT NULL,
	PhoneCharge INT NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO Employees(FirstName, LastName) VALUES
('1', '1'),
('2', '2'),
('3', '3')

INSERT INTO Customers(FirstName, LastName, PhoneNumber) VALUES
('1', '1', '1'),
('2', '2', '2'),
('3', '3', '3')

INSERT INTO RoomStatus(RoomStatus) VALUES
('1'),
('2'),
('3')

INSERT INTO RoomTypes(RoomType) VALUES
('1'),
('2'),
('3')

INSERT INTO BedTypes(BedType) VALUES
('1'),
('2'),
('3')

INSERT INTO Rooms(RoomNumber, RoomType, BedType, Rate, RoomStatus) VALUES
(1, '1', '1', 1, 1),
(2, '2', '2', 2, 2),
(3, '3', '3', 3, 3)

INSERT INTO Payments(EmployeeId, PaymentDate, AccountNumber, FirstDateOccupied, LastDateOccupied, AmountCharged, TaxRate) VALUES
(1, '1', 1, '1', '1', 1, 1),
(2, '2', 2, '2', '2', 2, 2),
(3, '3', 3, '3', '3', 3, 3)

INSERT INTO Occupancies(EmployeeId, DateOccupied, AccountNumber, RoomNumber, RateApplied, PhoneCharge) VALUES
(1, '1', 1, 1, 1, 1),
(2, '2', 2, 2, 2, 2),
(3, '2', 3, 3, 3, 3)

--Problem 23. Decrease Tax Rate

UPDATE Payments
SET TaxRate = TaxRate - (TaxRate * 0.03)
SELECT TaxRate FROM Payments

--Problem 24. Delete All Records

TRUNCATE TABLE Occupancies 
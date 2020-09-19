--Problem 14. Car Rental Database

CREATE DATABASE CarRental 
USE CarRental

CREATE TABLE Categories 
(
  Id INT PRIMARY KEY IDENTITY,
  CategoryName NVARCHAR(50) NOT NULL,
  DailyRate INT NOT NULL,
  WeeklyRate INT NOT NULL,
  MonthlyRate INT NOT NULL,
  WeekendRate INT NOT NULL
)

CREATE TABLE Cars
(
  Id INT PRIMARY KEY IDENTITY,
  PlateNumber NVARCHAR(10) UNIQUE NOT NULL,
  Manufacturer NVARCHAR(50) NOT NULL,
  Model  NVARCHAR(50) NOT NULL,
  CarYear INT NOT NULL,
  CategoryId INT NOT NULL,
  Doors INT,
  Picture IMAGE,
  Condition NVARCHAR(MAX),
  Available NVARCHAR (10)
)

CREATE TABLE Employees 
(
  Id INT PRIMARY KEY IDENTITY,
  FirstName NVARCHAR(50) NOT NULL,
  LastName NVARCHAR(50) NOT NULL,
  Title NVARCHAR(50),
  Notes NVARCHAR(MAX)
)

CREATE TABLE Customers 
(
  Id INT PRIMARY KEY IDENTITY,
  DriverLicenceNumber INT NOT NULL UNIQUE,
  FullName NVARCHAR(100) NOT NULL,
  [Address] NVARCHAR(500) NOT NULL,
  City NVARCHAR(50) NOT NULL,
  ZIPCode NVARCHAR(500),
  Notes NVARCHAR(MAX)
)

CREATE TABLE RentalOrders 
(
  Id INT PRIMARY KEY IDENTITY,
  EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
  CustomerId INT FOREIGN KEY REFERENCES Customers(Id),
  CarId INT FOREIGN KEY REFERENCES Cars(Id),
  TankLevel INT NOT NULL,
  KilometrageStart INT ,
  KilometrageEnd INT,
  TotalKilometrage INT,
  StartDate DATETIME NOT NULL,
  EndDate DATETIME NOT NULL,
  TotalDays INT NOT NULL,
  RateApplied INT NOT NULL,
  TaxRate INT NOT NULL,
  OrderStatus NVARCHAR(100),
  Notes NVARCHAR (MAX)
)

INSERT INTO Categories (CategoryName, DailyRate, WeeklyRate, MonthlyRate, WeekendRate) VALUES
('1', 11, 111, 1111, 11111),
('2', 22, 222, 2222, 22222),
('3', 33, 333, 3333, 33333)

INSERT INTO Cars (PlateNumber, Manufacturer, Model, CarYear, CategoryId, Doors, Picture, Condition, Available) VALUES
('1111', '1', '1', 1111, 1, 1, NULL, '1', 1),
('2222', '2', '2', 2222, 2, 2, NULL, '2', 2),
('3333', '3', '3', 3333, 3, 3, NULL, '3', 3)

INSERT INTO Employees (FirstName, LastName, Title, Notes) VALUES
('1', '1', '1', '1'),
('2', '2', NULL, '2'),
('3', '3', '3', '3')

INSERT INTO Customers(DriverLicenceNumber, FullName, [Address], City) VALUES
('1', '1111', '1 1', '1'),
('2', '2222', '2 2', '1'),
('3', '3333', '3 3', '1')

INSERT INTO RentalOrders(EmployeeId, CustomerId, CarId, TankLevel, KilometrageStart, KilometrageEnd, StartDate, EndDate, RateApplied, OrderStatus) VALUES
(1, 1, 1, 1, 11, 3333, '1111-11-11', '2222-22-22', 11, 1),
(2, 2, 2, 2, 22, 2222, '1111-11-11', '2222-22-22', 222, 2),
(3, 3, 3, 33, 33333, 3333, '1111-11-11', '2222-22-22', 333, 3)


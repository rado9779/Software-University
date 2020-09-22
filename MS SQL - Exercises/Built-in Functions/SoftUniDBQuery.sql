USE SoftUni

--Problem 1. Find Names of All Employees by First Name

SELECT FirstName,LastName FROM Employees WHERE FirstName LIKE 'SA%';

--Problem 2. Find Names of All employees by Last Name 

SELECT FirstName,LastName FROM Employees
WHERE LastName LIKE '%ei%'

--Problem 3. Find First Names of All Employees

SELECT FirstName FROM Employees 
WHERE DepartmentID IN (3,10)
AND DATEPART(YEAR, HireDate) BETWEEN 1995 AND 2005

--Problem 4 Find All Employees Except Engineers

SELECT FirstName,LastName FROM Employees
WHERE JobTitle NOT LIKE '%engineer%'

--Problem 5. Find Towns with Name Length

SELECT [Name] FROM Towns
WHERE LEN([Name]) IN (5,6)
ORDER BY [Name] 

--Problem 6. Find Towns Starting With

SELECT * FROM Towns
WHERE [Name] LIKE '[MKBE]%'
ORDER BY [Name]

--Problem 7. Find Towns Not Starting With

SELECT * FROM Towns
WHERE [Name] NOT LIKE '[RBD]%'
ORDER BY [Name]

--Problem 8. Create View Employees Hired After 2000 Year

CREATE VIEW V_EmployeesHiredAfter2000 AS
SELECT FirstName,LastName FROM Employees
WHERE DATEPART(YEAR,HireDate) > 2000

--Problem 9. Length of Last Name

SELECT FirstName,LastName FROM Employees
WHERE LEN(LastName) = 5

--Problem 10 Rank Employees by Salary

SELECT EmployeeID,FirstName,LastName,Salary,DENSE_RANK() OVER (PARTITION BY SALARY ORDER BY EmployeeID ) AS [RANK]
FROM Employees
WHERE Salary BETWEEN 10000  AND 50000 
ORDER BY Salary DESC

--Problem 11. Find All Employees with Rank 2

SELECT * FROM
(
   SELECT EmployeeID, FirstName, LastName, Salary, DENSE_RANK() OVER (PARTITION by Salary order by EmployeeID) AS [Rank]
   FROM Employees
   WHERE Salary BETWEEN 10000 AND 50000
)     
AS CustomRank
WHERE CustomRank.[Rank] = 2
ORDER BY CustomRank.Salary DESC;
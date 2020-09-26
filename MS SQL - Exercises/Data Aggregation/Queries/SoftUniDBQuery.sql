USE SoftUni

--Problem 13. Departments Total Salaries

SELECT DepartmentID, SUM(Salary) AS [TotalSalary]
FROM Employees AS d
GROUP BY DepartmentID
ORDER BY DepartmentID

--Problem 14. Employees Minimum Salaries

SELECT DepartmentID, MIN(Salary) AS [MinimumSalary]
FROM Employees
WHERE DepartmentID IN (2, 5, 7) AND HireDate > '01/01/2000'
GROUP BY DepartmentID

--Problem 15. Employees Average Salaries

SELECT *
INTO NewTable
FROM Employees
WHERE Salary > 30000 

DELETE FROM NewTable
WHERE ManagerID = 42

UPDATE NewTable
SET Salary += 5000
WHERE DepartmentID = 1

SELECT DepartmentID, AVG(Salary) AS [AverageSalary]
FROM NewTable
GROUP BY DepartmentID 

--Problem 16. Employees Maximum Salaries

SELECT DepartmentID, MAX(Salary) AS [MaxSalary]
FROM Employees
GROUP BY DepartmentID
HAVING MAX(Salary) NOT BETWEEN 30000 AND 70000

--Problem 17. Employees Count Salaries

SELECT COUNT(Salary) AS [Count]
FROM Employees
WHERE ManagerID IS NULL

--Problem 18. 3rd Highest Salary

SELECT [RankedTable].DepartmentID, [RankedTable].Salary
FROM
(
 SELECT 
 DepartmentID, 
 Salary, 
 DENSE_RANK() OVER (PARTITION BY DepartmentID ORDER BY Salary DESC
) AS [Rank]
FROM Employees
GROUP BY DepartmentID, Salary) AS [RankedTable]
WHERE [Rank] = 3

--Problem 19. Salary Challenge

SELECT TOP(10) e.FirstName, e.LastName, e.DepartmentID 
FROM Employees AS e
WHERE e.Salary > (SELECT AVG(d.Salary) FROM Employees AS d WHERE e.DepartmentID = d.DepartmentID)
ORDER BY e.DepartmentID



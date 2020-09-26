USE Gringotts

--Problem 1. Records’ Count

SELECT COUNT(*) AS Count
FROM WizzardDeposits

--Problem 2. Longest Magic Wand

SELECT TOP(1) MagicWandSize AS LongestMagicWand
FROM WizzardDeposits
ORDER BY MagicWandSize DESC

--Problem 3. Longest Magic Wand per Deposit Groups

SELECT DepositGroup, MAX(MagicWandSize) AS LongestMagicWand
FROM WizzardDeposits
GROUP BY DepositGroup

--Problem 4. Smallest Deposit Group per Magic Wand Size

SELECT TOP(2) DepositGroup FROM WizzardDeposits
GROUP BY DepositGroup
ORDER BY AVG(MagicWandSize)

--Problem 5. Deposits Sum

SELECT DepositGroup, SUM(DepositAmount) AS TotalSum
FROM WizzardDeposits
GROUP BY DepositGroup

--Problem 6. Deposits Sum for Ollivander Family

SELECT DepositGroup, SUM(DepositAmount) AS TotalSum
FROM WizzardDeposits
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup

--Problem 7. Deposits Filter

SELECT DepositGroup, SUM(DepositAmount) AS TotalSum
FROM WizzardDeposits
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup
HAVING SUM(DepositAmount) < 150000
ORDER BY TotalSum DESC

--Problem 8. Deposit Charge

SELECT DepositGroup, MagicWandCreator, MIN(DepositCharge) AS [MinDepositCharge]
FROM WizzardDeposits
GROUP BY DepositGroup, MagicWandCreator
ORDER BY MagicWandCreator, DepositGroup

--Problem 9. Age Groups

SELECT *, COUNT(*) AS [WizardCount] FROM
(
SELECT
 CASE
  WHEN Age BETWEEN 0 AND 10 THEN '[0-10]' 
  WHEN Age BETWEEN 11 AND 20 THEN '[11-20]' 
  WHEN Age BETWEEN 21 AND 30 THEN '[21-30]' 
  WHEN Age BETWEEN 31 AND 40 THEN '[31-40]' 
  WHEN Age BETWEEN 41 AND 50 THEN '[41-50]' 
  WHEN Age BETWEEN 51 AND 60 THEN '[51-60]' 
  ELSE '[61+]'
 END AS [AgeGroup]
FROM WizzardDeposits 
) AS Ages
GROUP BY [AgeGroup] 
ORDER BY [AgeGroup] 

--Problem 10. First Letter

SELECT LEFT(FirstName, 1) AS FirstLetter
FROM WizzardDeposits
WHERE DepositGroup = 'Troll Chest'
GROUP BY LEFT(FirstName, 1)
ORDER BY FirstLetter

--Problem 11. Average Interest 

SELECT DepositGroup, IsDepositExpired, AVG(DepositInterest) AS [AverageInterest]
FROM WizzardDeposits
WHERE DepositStartDate > '01/01/1985'
GROUP BY DepositGroup, IsDepositExpired
ORDER BY DepositGroup DESC, IsDepositExpired

--12. Rich Wizard, Poor Wizard 

SELECT SUM(w3.Difference) AS [SumDifference]
FROM
(
    SELECT DepositAmount -
    (
        SELECT DepositAmount
        FROM WizzardDeposits AS w1
        WHERE w1.Id = w2.Id + 1
    ) AS Difference
    FROM WizzardDeposits AS w2
) AS w3

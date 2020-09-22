USE Diablo

--Problem 14. Games from 2011 and 2012 year

SELECT TOP(50) [Name],FORMAT([Start],'yyyy-MM-dd') AS [Start] FROM Games
WHERE DATEPART(YEAR,Start) BETWEEN 2011 AND 2012
ORDER BY [Start],[Name]

--Problem 15. User Email Providers

SELECT Username, SUBSTRING(Email, CHARINDEX('@', Email) + 1,LEN (Email)) AS [Email Provider] 
FROM Users
ORDER BY [Email Provider],Username

--Problem 16. Get Users with IPAdress Like Pattern

SELECT Username,IpAddress
FROM Users
WHERE IpAddress LIKE '___.1_%._%.___'
ORDER BY Username

--Problem 17. Show All Games with Duration and Part of the Day

SELECT Name AS Game, [Part of the Day] = 
		CASE 
			WHEN DATEPART(HOUR, Start) < 12 THEN 'Morning'
			WHEN DATEPART(HOUR, Start) < 18 THEN 'Afternoon'
			ELSE 'Evening'
		END,
	Duration =
		CASE
			WHEN Duration <= 3 THEN 'Extra Short'
			WHEN Duration <= 6 THEN 'Short'
			WHEN Duration > 6 THEN 'Long'
			ELSE 'Extra Long'
		END
FROM Games
ORDER BY Game, Duration, [Part of the Day]


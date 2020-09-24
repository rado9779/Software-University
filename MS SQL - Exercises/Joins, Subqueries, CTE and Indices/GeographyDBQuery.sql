USE Geography

--Problem 12. Highest Peaks in Bulgaria

SELECT c.CountryCode, m.MountainRange, p.PeakName, p.Elevation
FROM Countries AS c
JOIN MountainsCountries AS mc
ON c.CountryCode = mc.CountryCode
JOIN Mountains AS m
ON mc.MountainId = m.Id
JOIN Peaks AS p
ON m.Id = p.MountainId
WHERE c.CountryCode = 'BG' AND p.Elevation > 2835
ORDER BY p.Elevation DESC

--Problem 13. Count Mountain Ranges

SELECT c.CountryCode, COUNT(m.MountainRange) AS [MountainRanges] 
FROM Countries AS c
JOIN MountainsCountries AS mc
ON c.CountryCode = mc.CountryCode
JOIN Mountains AS m
ON mc.MountainId = m.Id
WHERE c.CountryCode IN ('US','RU','BG')
GROUP BY c.CountryCode

--Problem 14. Countries with Rivers

SELECT TOP(5) c.CountryName, r.RiverName
FROM Countries AS c
LEFT JOIN CountriesRivers AS cr
ON c.CountryCode = cr.CountryCode
LEFT JOIN Rivers AS r
ON cr.RiverId = r.Id
WHERE c.ContinentCode = 'AF'
ORDER BY c.CountryName

--Problem 15. Continents and Currencies

SELECT 
continent.ContinentCode,
continent.CurrencyCode,
continent.CurrencyUsage
FROM
(
    SELECT 
    country.ContinentCode,
    country.CurrencyCode,
    country.CurrencyUsage,
    DENSE_RANK() OVER(PARTITION BY country.ContinentCode ORDER BY country.CurrencyUsage DESC) AS ranked
    FROM
    (
        SELECT ContinentCode,
               CurrencyCode,
               COUNT(CurrencyCode) AS CurrencyUsage
        FROM Countries
        GROUP BY ContinentCode, CurrencyCode
        HAVING COUNT(CurrencyCode) > 1
    ) AS country
) AS continent
WHERE continent.ranked = 1
ORDER BY continent.ContinentCode 

--Problem 16. Countries without any Mountains

SELECT COUNT(country.ContinentCode) AS [Count]
FROM Countries AS country
FULL JOIN MountainsCountries AS mountainsCountries
ON country.CountryCode = mountainsCountries.CountryCode
WHERE mountainsCountries.MountainId IS NULL

--Problem 17. Highest Peak and Longest River by Country

SELECT TOP(5)
 c.CountryName, 
 MAX(p.Elevation) AS [HighestPeakElevation], 
 MAX(r.Length) AS [LongestRiverLength]
FROM Countries AS c
JOIN MountainsCountries AS mc
ON c.CountryCode = mc.CountryCode
JOIN Mountains AS m
ON mc.MountainId = m.Id
JOIN Peaks AS p
ON m.Id = p.MountainId
JOIN CountriesRivers AS cr
ON c.CountryCode = cr.CountryCode
JOIN Rivers AS r
ON cr.RiverId = r.Id
GROUP BY c.CountryName
ORDER BY 
 HighestPeakElevation DESC, 
 LongestRiverLength DESC,
 c.CountryName

--Problem 18. Highest Peak Name and Elevation by Country

SELECT TOP(5) 
 result.CountryName,
 ISNULL(result.PeakName, '(no highest peak)') AS [Highest Peak Name],
 ISNULL(result.[Highest Peak Elevation], 0) AS [Highest Peak Elevation],
 ISNULL(result.MountainRange, '(no mountain)') AS [Mountain]
FROM (
   SELECT 
   c.CountryName,
   p.PeakName,
   MAX(p.Elevation) AS [Highest Peak Elevation],
   m.MountainRange,
   DENSE_RANK() OVER(PARTITION BY c.CountryName ORDER BY MAX(p.Elevation) DESC) AS [Rank]
   FROM Countries AS c
LEFT JOIN MountainsCountries AS mc 
ON mc.CountryCode = c.CountryCode
LEFT JOIN Mountains AS m 
ON m.Id = mc.MountainId
LEFT JOIN Peaks AS p 
ON p.MountainId = mc.MountainId
GROUP BY c.CountryName, p.PeakName, m.MountainRange) AS result
WHERE result.[Rank] = 1
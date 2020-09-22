USE Geography

--Problem 12. Countries Holding ‘A’ 3 or More Times

SELECT CountryName,IsoCode FROM Countries
WHERE CountryName LIKE '%a%a%a%'
ORDER BY IsoCode

--Problem 13. Mix of Peak and River Names

SELECT PeakName,RiverName, LOWER(LEFT(PeakName, LEN(PeakName) - 1) + RiverName) AS Mix FROM Rivers,Peaks
WHERE RIGHT(PeakName,1) = LEFT(RiverName,1)
ORDER BY Mix
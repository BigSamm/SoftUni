SELECT FirstName, LastName 
  FROM Employees
 WHERE FirstName
  LIKE 'SA%'

SELECT FirstName, LastName 
  FROM Employees
 WHERE LastName
  LIKE '%ei%'

SELECT FirstName
  FROM Employees
 WHERE DepartmentID IN (3, 10)
   AND HireDate BETWEEN '1995-01-01' AND '2005-12-31'

SELECT FirstName, LastName
  FROM Employees
 WHERE JobTitle
NOT LIKE '%engineer%'

SELECT [Name]
  FROM Towns
 WHERE LEN([Name]) = 5
	OR LEN([Name]) = 6
ORDER BY [Name]

SELECT *
  FROM Towns
 WHERE [Name] LIKE 'M%' OR
	   [Name] LIKE 'K%' OR 
	   [Name] LIKE 'B%' OR
	   [Name] LIKE 'E%'
ORDER BY [Name]

SELECT *
  FROM Towns
 WHERE [Name] NOT LIKE 'R%' AND
	   [Name] NOT LIKE 'B%' AND
	   [Name] NOT LIKE 'D%'
ORDER BY [Name]
GO

CREATE VIEW V_EmployeesHiredAfter2000 AS
SELECT FirstName, LastName
  FROM Employees
 WHERE HireDate > '2000-12-31'
GO

SELECT * FROM V_EmployeesHiredAfter2000

SELECT FirstName, LastName
  FROM Employees
 WHERE LEN(LastName) = 5

SELECT CountryName, IsoCode
  FROM Countries
 WHERE LEN(CountryName) - LEN(REPLACE(CountryName, 'a', '')) >= 3
ORDER BY IsoCode

SELECT PeakName, RiverName,
	   LOWER(PeakName + SUBSTRING(RiverName, 2, LEN(RiverName) - 1)) 
	AS Mix
  FROM Peaks, Rivers
 WHERE SUBSTRING(PeakName, LEN(PeakName), 1) = SUBSTRING(RiverName, 1, 1)
ORDER BY Mix

SELECT TOP(50) [Name], 
	   FORMAT([Start], 'yyyy-MM-dd') AS [Start]
  FROM Games
 WHERE DATEPART(YEAR, [Start]) = 2011
	OR DATEPART(YEAR, [Start]) = 2012
ORDER BY [Start], [Name]

SELECT Username,
	   RIGHT(Email, LEN(Email) - CHARINDEX('@', Email)) AS [Email Provider]
  FROM Users
ORDER BY [Email Provider], Username

SELECT Username, IpAddress
  FROM Users
 WHERE IpAddress LIKE '___.1%.%.___'
ORDER BY Username

SELECT [Name],
  CASE
		WHEN DATEPART(HOUR, [Start]) >= 0 AND DATEPART(HOUR, [Start]) < 12 THEN 'Morning'
		WHEN DATEPART(HOUR, [Start]) >= 12 AND DATEPART(HOUR, [Start]) < 18 THEN 'Afternoon'
		WHEN DATEPART(HOUR, [Start]) >= 18 AND DATEPART(HOUR, [Start]) < 24 THEN 'Evening'		
   END AS [Part of the Day],
  CASE
		WHEN Duration <= 3 THEN 'Extra Short'
		WHEN Duration > 3 AND Duration <= 6 THEN 'Short'
		WHEN Duration > 6  THEN 'Long'
		WHEN Duration IS NULL THEN 'Extra Long'
   END AS Duration
  FROM Games
ORDER BY [Name], Duration, [Part of the Day]

SELECT ProductName,
	   OrderDate,
	   DATEADD(DAY, 3, OrderDate) AS [Pay Due],
	   DATEADD(MONTH, 1, OrderDate) AS [Deliver Due]
  FROM Orders

CREATE TABLE People (
	Id INT IDENTITY NOT NULL,
	[Name] NVARCHAR(50) NOT NULL,
	Birthdate DATETIME NOT NULL

	CONSTRAINT PK_PeopleId
	PRIMARY KEY (Id)
)

INSERT INTO People VALUES
('Victor', '2000-12-07'),
('Steven', '1992-09-10'),
('Stephen', '1910-09-19'),
('John', '2010-01-06')

SELECT *
  FROM People

SELECT [Name],
	   DATEDIFF(YEAR, Birthdate, GETDATE()) AS [Age in Years],
	   DATEDIFF(MONTH, Birthdate, GETDATE()) AS [Age in Months],
	   DATEDIFF(MONTH, Birthdate, GETDATE()) AS [Age in Months],
	   DATEDIFF(MINUTE, Birthdate, GETDATE()) AS [Age in Minutes]
  FROM People
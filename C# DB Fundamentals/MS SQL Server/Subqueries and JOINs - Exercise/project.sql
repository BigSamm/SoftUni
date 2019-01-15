-- SoftUni database
  
  SELECT TOP(5) e.EmployeeID,
		 e.JobTitle,
		 e.AddressID,
		 a.AddressText  
    FROM Employees AS e
    JOIN Addresses AS a
  	  ON a.AddressID = e.AddressID
ORDER BY e.AddressID

  SELECT TOP(50) e.FirstName, 
		 e.LastName,
		 t.[Name] AS Town,
		 a.AddressText
    FROM Employees AS e
	JOIN Addresses AS a
	  ON a.AddressID = e.AddressID
	JOIN Towns AS t
	  ON t.TownID = a.TownID
ORDER BY e.FirstName, e.LastName 

  SELECT e.EmployeeID,
		 e.FirstName,
		 e.LastName,
		 d.[Name] AS [DepartmentName]
    FROM Employees AS e
	JOIN Departments AS d
	  ON e.DepartmentID = d.DepartmentID
   WHERE d.[Name] = 'Sales'
ORDER BY e.EmployeeID

  SELECT TOP(5) e.EmployeeID,
		 e.FirstName,
		 e.Salary,
		 d.[Name] AS [DepartmentName]
 	FROM Employees AS e
	JOIN Departments AS d
	  ON d.DepartmentID = e.DepartmentID
   WHERE e.Salary > 15000
ORDER BY e.DepartmentID

   SELECT TOP(3) e.EmployeeID, e.FirstName
	 FROM Employees AS e
LEFT JOIN EmployeesProjects AS ep
	   ON ep.EmployeeID = e.EmployeeID
    WHERE ep.ProjectID IS NULL
 ORDER BY e.EmployeeID

  SELECT e.FirstName,
   	     e.LastName,
		 e.HireDate,
		 d.[Name] AS [DeptName]
    FROM Employees AS e
    JOIN Departments AS d
      ON d.DepartmentID = e.DepartmentID
   WHERE e.HireDate > '1999-01-01'
	 AND d.[Name] = 'Sales'
	  OR d.[Name] = 'Finance'
ORDER BY e.HireDate

  SELECT TOP(5) e.EmployeeID,
		 e.FirstName,
		 p.[Name] AS [ProjectName]
    FROM Employees AS e
	JOIN EmployeesProjects AS ep
	  ON ep.EmployeeID = e.EmployeeID
	JOIN Projects AS p
	  ON p.ProjectID = ep.ProjectID
   WHERE p.StartDate > '2002-08-13'
     AND p.EndDate IS NULL 
ORDER BY e.EmployeeID

SELECT e.EmployeeID,
	   e.FirstName,
	   CASE
			WHEN p.StartDate >= '2005-01-01' THEN NULL
			WHEN p.StartDate < '2005-01-01' THEN p.[Name]
	   END AS [ProjectName]
  FROM Employees AS e
  JOIN EmployeesProjects AS ep
	ON ep.EmployeeID = e.EmployeeID
  JOIN Projects AS p
	ON p.ProjectID = ep.ProjectID
 WHERE ep.EmployeeID = 24

  SELECT e.EmployeeID,
		 e.FirstName,
		 m.EmployeeID AS [ManagerID],
		 m.FirstName AS [ManagerName]
    FROM Employees AS e
	JOIN Employees AS m
	  ON m.EmployeeID = e.ManagerID
   WHERE e.ManagerID IN (3, 7)
ORDER BY e.EmployeeID

  SELECT TOP(50) e.EmployeeID,
  		 e.FirstName + ' ' + e.LastName AS [EmployeeName],
  		 m.FirstName + ' ' + m.LastName AS [ManagerName],
		 d.[Name] AS [DepartmentName]
    FROM Employees AS e
  	JOIN Employees AS m
	  ON m.EmployeeID = e.ManagerID
	JOIN Departments AS d
	  ON d.DepartmentID = e.DepartmentID
ORDER BY e.EmployeeID

  SELECT TOP(1) AVG(Salary) AS [MinAverageSalary]
    FROM Employees
GROUP BY DepartmentID
ORDER BY AVG(Salary)

-- Geography database

  SELECT c.CountryCode,
		 m.MountainRange,
		 p.PeakName,
		 p.Elevation
    FROM Countries AS c
	JOIN MountainsCountries AS mc
	  ON mc.CountryCode = c.CountryCode
	JOIN Mountains AS m
	  ON m.Id = mc.MountainId
	JOIN Peaks AS p
	  ON p.MountainId = m.Id
   WHERE c.CountryName = 'Bulgaria'
     AND p.Elevation > 2835
ORDER BY p.Elevation DESC

  SELECT c.CountryCode,
  	     COUNT(m.MountainRange) AS [MountainRanges]
    FROM Countries AS c
    JOIN MountainsCountries AS mc
      ON mc.CountryCode = c.CountryCode
    JOIN Mountains AS m
      ON m.Id = mc.MountainId
GROUP BY c.CountryCode
  HAVING c.CountryCode IN ('BG', 'RU', 'US')

   SELECT TOP(5) c.CountryName,
	 	  r.RiverName
     FROM Countries AS c
LEFT JOIN CountriesRivers AS cr
	   ON cr.CountryCode = c.CountryCode
LEFT JOIN Rivers AS r
	   ON r.Id = cr.RiverId
    WHERE c.ContinentCode = 'AF'
 ORDER BY c.CountryName

  SELECT TOP(5) c.CountryName,
  	     MAX(p.Elevation) AS [HighestPeakElevation],
  	     MAX(r.[Length]) AS [LongestRiverLength] 
    FROM Countries AS c
    JOIN MountainsCountries AS mc
      ON mc.CountryCode = c.CountryCode
    JOIN Mountains AS m
      ON m.Id = mc.MountainId
    JOIN Peaks AS p
      ON p.MountainId = m.Id
    JOIN CountriesRivers AS cr
      ON cr.CountryCode = c.CountryCode
    JOIN Rivers AS r
      ON r.Id = cr.RiverId
GROUP BY c.CountryName
ORDER BY MAX(p.Elevation) DESC,
		 MAX(r.[Length]) DESC,
		 c.CountryName

SELECT SUM([Sum].[Count]) AS CountryCode
  FROM (SELECT COUNT(c.CountryCode) AS [Count]
		     FROM Countries AS c
		LEFT JOIN MountainsCountries AS mc
		    ON mc.CountryCode = c.CountryCode
			WHERE mc.MountainId IS NULL
		 GROUP BY c.CountryCode) AS [Sum]


WITH CTE_CountriesInfo (ContinentCode, CurrencyCode, CurrencyUsage) AS (
  SELECT ContinentCode,
	     CurrencyCode,
	     COUNT(CurrencyCode) AS [CurrencyUsage]
	FROM Countries
GROUP BY ContinentCode, CurrencyCode 
  HAVING COUNT(CurrencyCode) > 1 )

SELECT e.ContinentCode,
	   cci.CurrencyCode,
	   e.MaxCurrency
  FROM (
		 SELECT ContinentCode,
			    MAX(CurrencyUsage) AS [MaxCurrency]
		 FROM CTE_CountriesInfo
		 GROUP BY ContinentCode
	   ) AS e
  JOIN CTE_CountriesInfo AS cci
    ON cci.ContinentCode = e.ContinentCode
	   AND cci.CurrencyUsage = e.MaxCurrency


WITH CTE_CountriesInfo(CountryName, PeakName, Elevation, Mountain) AS (
   SELECT c.CountryName,
	      p.PeakName,
	      MAX(p.Elevation),
	      m.MountainRange
     FROM Countries AS [c]
LEFT JOIN MountainsCountries AS [mc]
	   ON mc.CountryCode = c.CountryCode
LEFT JOIN Mountains AS [m]
	   ON m.Id = mc.MountainId
LEFT JOIN Peaks AS [p]
	   ON p.MountainId = m.Id
 GROUP BY c.CountryName, p.PeakName, m.MountainRange )

   SELECT TOP(5) e.CountryName,
		  ISNULL(cci.PeakName, '(no highest peak)') AS [Highest Peak Name],
		  ISNULL(cci.Elevation, 0) AS [Highest Peak Elevation],
		  ISNULL(cci.Mountain, '(no mountain)') AS [Mountain] 
     FROM (
		    SELECT CountryName, MAX(Elevation) AS [MaxElevation]
		    FROM CTE_CountriesInfo
		    GROUP BY CountryName
	      ) AS e
LEFT JOIN CTE_CountriesInfo AS [cci]
       ON cci.CountryName = e.CountryName
		  AND cci.Elevation = e.MaxElevation
 ORDER BY e.CountryName, cci.PeakName
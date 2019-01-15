CREATE TABLE Users (
	Id INT PRIMARY KEY IDENTITY,
	Username NVARCHAR(30) UNIQUE NOT NULL,
	[Password] NVARCHAR(50) NOT NULL,
	[Name] NVARCHAR(50),
	Gender VARCHAR(1) NOT NULL,
	BirthDate DATETIME,
	Age INT,
	Email NVARCHAR(50) NOT NULL
)

CREATE TABLE Departments (
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(50) NOT NULL,
)

CREATE TABLE Employees (
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(25),
	LastName NVARCHAR(25),
	Gender VARCHAR(1) NOT NULL,
	BirthDate DATETIME,
	Age INT,
	DepartmentId INT REFERENCES Departments(Id) NOT NULL
)

CREATE TABLE Categories (
	Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL,
	DepartmentId INT REFERENCES Departments(Id)
)

CREATE TABLE [Status] (
	Id INT PRIMARY KEY IDENTITY,
	Label VARCHAR(30) NOT NULL
)

CREATE TABLE Reports (
	Id INT PRIMARY KEY IDENTITY,
	CategoryId INT REFERENCES Categories(Id) NOT NULL,
	StatusId INT REFERENCES [Status](Id) NOT NULL,
	OpenDate DATETIME NOT NULL,
	CloseDate DATETIME,
	[Description] VARCHAR(200),
	UserId INT REFERENCES Users(Id) NOT NULL,
	EmployeeId INT REFERENCES Employees(Id)
)

------------------------------------------------------------------------------

INSERT INTO Employees (FirstName, LastName, Gender, BirthDate, DepartmentId)
VALUES
('Marlo', 'O’Malley', 'M', '9/21/1958', 1),
('Niki', 'Stanaghan', 'F', '11/26/1969', 4),
('Ayrton', 'Senna', 'M', '03/21/1960', 9),
('Ronnie', 'Peterson', 'M', '02/14/1944', 9),
('Giovanna', 'Amati', 'F', '07/20/1959', 5)

INSERT INTO Reports VALUES
(1, 1, '04/13/2017', NULL, 'Stuck Road on Str.133', 6, 2),
(6, 3, '09/05/2015', '12/06/2015', 'Charity trail running', 3, 5),
(14, 2, '09/07/2015', NULL, 'Falling bricks on Str.58', 5, 2),
(4, 3, '07/03/2017', '07/06/2017', 'Cut off streetlight on Str.11', 1, 1)

------------------------------------------------------------------------------

UPDATE Reports
   SET StatusId = 2
 WHERE StatusId = 1
   AND CategoryId = 4
   
------------------------------------------------------------------------------

DELETE Reports
 WHERE StatusId = 4
 
------------------------------------------------------------------------------

  SELECT u.Username, u.Age
    FROM Users AS u 
ORDER BY u.Age, u.Username DESC

------------------------------------------------------------------------------

  SELECT r.[Description], r.OpenDate
    FROM Reports AS r
   WHERE r.EmployeeId IS NULL
ORDER BY r.OpenDate, r.Description

------------------------------------------------------------------------------

  SELECT e.FirstName,
		 e.LastName,
		 r.[Description],
		 FORMAT(r.OpenDate, 'yyyy-MM-dd') AS [OpenDate]
    FROM Employees AS e
    JOIN Reports AS r
	  ON r.EmployeeId = e.Id
ORDER BY e.Id, r.OpenDate, r.Id

------------------------------------------------------------------------------

  SELECT c.[Name],
		 COUNT(r.CategoryId) AS [ReportsNumber]
    FROM Reports AS r
	JOIN Categories AS c
	  ON c.Id = r.CategoryId
GROUP BY c.[Name]
ORDER BY COUNT(r.CategoryId) DESC, c.[Name]

------------------------------------------------------------------------------

  SELECT c.[Name] AS CategoryName,
		 COUNT(e.FirstName) AS [Employees Number]
    FROM Categories AS c
	JOIN Employees AS e
	  ON e.DepartmentId = c.DepartmentId
GROUP BY c.[Name]
ORDER BY c.[Name]

------------------------------------------------------------------------------

    SELECT e.FirstName + ' ' + e.LastName AS [Name],
		   COUNT(r.UserId) AS [Users Number]
      FROM Reports AS r
RIGHT JOIN Employees AS e
	    ON e.Id = r.EmployeeId
  GROUP BY e.FirstName + ' ' + e.LastName
  ORDER BY COUNT(r.UserId) DESC, e.FirstName + ' ' + e.LastName
  
------------------------------------------------------------------------------

  SELECT r.OpenDate,
		 r.[Description],
		 u.Email AS [Reporter Email]
    FROM Reports AS r
	JOIN Users AS u
	  ON u.Id = r.UserId
	JOIN Categories AS c
	  ON c.Id = r.CategoryId
   WHERE r.CloseDate IS NULL
     AND LEN(r.[Description]) > 20
	 AND r.[Description] LIKE '%str%'
	 AND c.DepartmentId IN (1, 4, 5)
ORDER BY r.OpenDate, u.Email, r.Id

------------------------------------------------------------------------------

  SELECT c.[Name] AS [Category Name]
    FROM Reports AS r
	JOIN Categories AS c
	  ON c.Id = r.CategoryId
	JOIN Users AS u
	  ON u.Id = r.UserId
   WHERE RIGHT(CAST(u.Birthdate AS DATE), 5) = RIGHT(CAST(r.OpenDate AS DATE), 5)
GROUP BY c.[Name]
ORDER BY c.[Name]

------------------------------------------------------------------------------

  SELECT DISTINCT u.Username
    FROM Reports AS r
	JOIN Users AS u
	  ON u.Id = r.UserId
	JOIN Categories AS c
	  ON c.Id = r.CategoryId
   WHERE LEFT(u.Username, 1) = CAST(c.Id AS NVARCHAR(5))
	  OR RIGHT(u.Username, 1) = CAST(c.Id AS NVARCHAR(5))
ORDER BY U.Username

------------------------------------------------------------------------------
 
WITH cte_ProjectsCount (EmployeeId, ClosedCount, OpenedCount)
AS
(
	  SELECT e.Id,
			 CASE
			     WHEN DATEPART(YEAR, r.CloseDate) = 2016 THEN 1
				 ELSE 0
			 END,
			 CASE
			     WHEN DATEPART(YEAR, r.OpenDate) = 2016 THEN 1
				 ELSE 0
			 END
		FROM Reports AS r
		JOIN Employees AS e
		  ON e.Id = r.EmployeeId
)

  SELECT e.FirstName + ' ' + e.LastName AS [Name],
		 CAST(SUM(pc.ClosedCount) AS VARCHAR) + '/' + CAST(SUM(pc.OpenedCount) AS VARCHAR) AS [Closed Open Reports]
    FROM cte_ProjectsCount AS pc
	JOIN Employees AS e
	  ON e.Id = pc.EmployeeId
   WHERE pc.ClosedCount + pc.OpenedCount > 0
GROUP BY e.FirstName + ' ' + e.LastName, e.Id
ORDER BY e.FirstName + ' ' + e.LastName, e.Id

SELECT * FROM Reports WHERE EmployeeId > 0
 
------------------------------------------------------------------------------

WITH cte_DepartmentReportTime (DepartmentName, Duration)
AS
(
	SELECT d.[Name],
		   DATEDIFF(DAY, r.OpenDate, r.CloseDate)
	  FROM Reports AS r
	  JOIN Categories AS c
		ON c.Id = r.CategoryId
	  JOIN Departments AS d
		ON d.Id = c.DepartmentId
)

  SELECT DepartmentName,
		 ISNULL(CAST(AVG(Duration) AS VARCHAR(10)), 'no info') AS [Average Duration]
	FROM cte_DepartmentReportTime
GROUP BY DepartmentName

------------------------------------------------------------------------------
GO

  SELECT d.[Name] AS [Department Name],
		 c.[Name] AS [Category Name],
		 CONVERT(INT, ROUND(H2.[Count] * 100.0 / H1.[Count], 0)) AS [Percentage]
    FROM Departments AS d
    JOIN Categories AS c
      ON c.DepartmentId = d.Id
    JOIN Reports AS r
      ON r.CategoryId = c.Id
	JOIN (
			  SELECT d.Id AS DepartmentId,
					 COUNT(r.Id) AS [Count] 
			  FROM Departments AS d
			  JOIN Categories AS c
			  ON c.DepartmentId = d.Id
			  JOIN Reports AS r
			  ON r.CategoryId = c.Id
			  GROUP BY d.Id) AS H1
	  ON H1.DepartmentId = d.Id
	JOIN (
			  SELECT c.Id AS CategoryId,
					 COUNT(r.Id) AS [Count] 
			  FROM Categories AS c
			  JOIN Reports AS r
			  ON r.CategoryId = c.Id
			  GROUP BY c.Id) AS H2
	  ON H2.CategoryId = c.Id
GROUP BY d.[Name], c.[Name], H1.[Count], H2.[Count]
ORDER BY [Department Name], [Category Name], Percentage
 
------------------------------------------------------------------------------
GO

CREATE OR ALTER FUNCTION udf_GetReportsCount(@employeeId INT, @statusId INT)
RETURNS INT
AS
BEGIN
	DECLARE @result INT = (
		SELECT COUNT(Id)
		  FROM Reports
		 WHERE EmployeeId = @employeeId
		   AND StatusId = @statusId
	);

	IF (@result IS NULL)
	BEGIN
		SET @result = 0;
	END

	RETURN @result;
END
GO

  SELECT Id,
		 FirstName,
		 Lastname,
		 dbo.udf_GetReportsCount(Id, 2) AS ReportsCount
	FROM Employees
ORDER BY Id

------------------------------------------------------------------------------
GO

CREATE OR ALTER PROC usp_AssignEmployeeToReport(@employeeId INT, @reportId INT)
AS
BEGIN
	BEGIN TRANSACTION

	UPDATE Reports
	   SET EmployeeId = @employeeId
	 WHERE Id = @reportId

	 DECLARE @employeeDepartmentId INT = (
		SELECT DepartmentId FROM Employees WHERE Id = @employeeId
	 );

	 DECLARE @reportDepartmentId INT = (
		SELECT c.DepartmentId
		  FROM Reports AS r
		  JOIN Categories AS c
		    ON c.Id = r.CategoryId
		 WHERE r.Id = @reportId
	 );

	 IF (@employeeDepartmentId <> @reportDepartmentId)
	 BEGIN
		ROLLBACK;
		RAISERROR('Employee doesn''t belong to the appropriate department!', 16, 1);
		RETURN;
	 END

	 COMMIT;
END

EXEC usp_AssignEmployeeToReport 16, 2;
SELECT EmployeeId FROM Reports WHERE id = 2

------------------------------------------------------------------------------
GO

CREATE OR ALTER TRIGGER tr_CloseReports
ON Reports
FOR UPDATE
AS
BEGIN
	UPDATE Reports
	   SET StatusId = (SELECT Id FROM [Status] WHERE Label = 'completed')
	 WHERE Id = (SELECT Id
				   FROM inserted
				  WHERE Id IN (
						SELECT Id
						FROM deleted
						WHERE CloseDate IS NULL)
					AND CloseDate IS NOT NULL)
END

UPDATE Reports
   SET CloseDate = GETDATE() 
 WHERE EmployeeId = 5;

------------------------------------------------------------------------------

  SELECT c.[Name] AS [Category Name],
		 COUNT(r.Id) AS [Reports Number],
		 CASE
		     WHEN SUM(CASE WHEN r.StatusId = 1 THEN 1 ELSE 0 END) >
				  SUM(CASE WHEN r.StatusId = 2 THEN 1 ELSE 0 END)
				  THEN 'waiting'
			 WHEN SUM(CASE WHEN r.StatusId = 1 THEN 1 ELSE 0 END) <
				  SUM(CASE WHEN r.StatusId = 2 THEN 1 ELSE 0 END)
				  THEN 'in progress'
			 ELSE 'equal'
		 END AS [Main Status]
    FROM Reports AS r
	JOIN Categories AS c
	  ON c.Id = r.CategoryId
   WHERE r.StatusId IN (1, 2)
GROUP BY c.[Name]
ORDER BY c.[Name], [Reports Number], [Main Status]
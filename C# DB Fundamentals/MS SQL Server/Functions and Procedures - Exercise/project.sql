-- SoftUni database

CREATE PROC usp_GetEmployeesSalaryAbove35000 
AS
BEGIN
	SELECT e.FirstName, e.LastName
	  FROM Employees AS e
	 WHERE e.Salary > 35000
END

EXEC usp_GetEmployeesSalaryAbove35000
GO

CREATE PROC usp_GetEmployeesSalaryAboveNumber (@MinSalary DECIMAL(18, 4))
AS
BEGIN
	SELECT e.FirstName, e.LastName
	  FROM Employees AS e
	 WHERE e.Salary >= @MinSalary
END

EXEC usp_GetEmployeesSalaryAboveNumber 48100
GO

CREATE PROC usp_GetTownsStartingWith (@Str NVARCHAR(50))
AS
BEGIN
	SELECT t.Name AS Town
	  FROM Towns AS t
	 WHERE t.Name
	  LIKE @Str + '%'
END

EXEC dbo.usp_GetTownsStartingWith 'b'
GO

CREATE PROC usp_GetEmployeesFromTown (@TownName NVARCHAR(50))
AS
BEGIN
	DECLARE @townId INT = (
		SELECT t.TownID
		  FROM Towns AS t
		 WHERE t.Name = @TownName
	)

	SELECT e.FirstName, e.LastName
	  FROM Employees AS e
	  JOIN Addresses AS a
	    ON a.AddressID = e.AddressID
	 WHERE a.TownID = @townId
END

EXEC dbo.usp_GetEmployeesFromTown 'Sofia'
GO

CREATE FUNCTION ufn_GetSalaryLevel(@salary DECIMAL(18,4))
RETURNS VARCHAR(7)
AS
BEGIN
	DECLARE @salaryLevel VARCHAR(7) = (
		CASE
			WHEN @salary < 30000 THEN 'Low'
			WHEN @salary >= 30000 AND @salary <= 50000 THEN 'Average'
			WHEN @salary > 50000 THEN 'High'
		END	
	)

	RETURN @salaryLevel
END
GO

CREATE PROC usp_EmployeesBySalaryLevel (@salaryLevel VARCHAR(7))
AS
BEGIN
	SELECT e.FirstName, e.LastName
	  FROM Employees AS e
	 WHERE dbo.ufn_GetSalaryLevel(e.Salary) = @salaryLevel
END

EXEC dbo.usp_EmployeesBySalaryLevel 'High'
GO

CREATE PROC usp_DeleteEmployeesFromDepartment (@departmentId INT)
AS
BEGIN
	UPDATE Employees
	   SET DepartmentID = NULL
	 WHERE DepartmentID = @departmentId

	UPDATE Departments
	   SET ManagerID = NULL
	 WHERE DepartmentID = @departmentId

	SELECT COUNT(e.EmployeeID)
	  FROM Employees AS e
	 WHERE DepartmentID = @departmentId
END
GO

CREATE FUNCTION ufn_IsWordComprised(@setOfLetters NVARCHAR(50), @word NVARCHAR(50))
RETURNS INT
AS
BEGIN
	DECLARE @index INT = 1;
	DECLARE @char NVARCHAR(1);

	WHILE (@index <= LEN(@word))
	BEGIN
		SET @char = SUBSTRING(@word, @index, 1);

		IF (CHARINDEX(@char, @setOfLetters) = 0)
		BEGIN
			RETURN 0;
		END

		SET @index += 1;
	END

	RETURN 1;
END
GO

CREATE PROC usp_DeleteEmployeesFromDepartment (@departmentId INT)
AS
BEGIN
	DELETE FROM EmployeesProjects
	 WHERE EmployeeID IN (
				SELECT EmployeeID
				  FROM Employees
				 WHERE DepartmentID = @departmentId)

	 ALTER TABLE Departments
	ALTER COLUMN ManagerID INT

	 ALTER TABLE Departments
	ALTER COLUMN ManagerID INT

	UPDATE Employees
	   SET ManagerID = NULL
	 WHERE ManagerID IN (
				SELECT EmployeeID
				  FROM Employees
				 WHERE DepartmentID = @departmentId)

	UPDATE Departments
	   SET ManagerID = NULL
	 WHERE ManagerID IN (
				SELECT EmployeeID
				  FROM Employees
				 WHERE DepartmentID = @departmentId)

	DELETE FROM Employees
	 WHERE DepartmentID = @departmentId

	DELETE FROM Departments
	 WHERE DepartmentID = @departmentId

	SELECT COUNT(*)
	  FROM Employees
	 WHERE DepartmentID = @departmentId
END

EXEC usp_DeleteEmployeesFromDepartment 1
GO

-- Bank database

CREATE PROC usp_GetHoldersFullName
AS
BEGIN
	SELECT ah.FirstName + ' ' + ah.LastName AS [Full Name]
	  FROM AccountHolders AS ah
END

EXEC dbo.usp_GetHoldersFullName
GO

CREATE PROC usp_GetHoldersWithBalanceHigherThan (@amount DECIMAL(18, 4))
AS
BEGIN
	WITH cte_AccountHolderBalance (AccountHolderId, Balance) AS (
		  SELECT a.AccountHolderId,
			     SUM(a.Balance) AS TotalBalance
		    FROM Accounts AS a
		GROUP BY a.AccountHolderId
	)

	  SELECT ah.FirstName, ah.LastName
	    FROM AccountHolders AS ah
	    JOIN cte_AccountHolderBalance AS ahb
	      ON ahb.AccountHolderId = ah.Id
	   WHERE ahb.Balance > @amount
	ORDER BY ah.LastName, ah.FirstName
END

EXEC [dbo].[usp_GetHoldersWithBalanceHigherThan] 50000
GO

CREATE OR ALTER FUNCTION ufn_CalculateFutureValue (@sum DECIMAL(18, 4), @interestRate FLOAT, @years INT)
RETURNS DECIMAL(18, 4)
AS
BEGIN
	DECLARE @result DECIMAL(18, 4) = (
		@sum * (POWER(1 + @interestRate, @years))
	);

	RETURN @result;
END

SELECT dbo.ufn_CalculateFutureValue(1000, 0.1, 5)
GO

CREATE OR ALTER PROC usp_CalculateFutureValueForAccount (@accountId INT, @interestRate FLOAT)
AS
BEGIN
	SELECT a.Id AS [Account Id],
		   ah.FirstName,
		   ah.LastName,
		   a.Balance,
		   dbo.ufn_CalculateFutureValue(a.Balance, @interestRate, 5) AS [Balance in 5 years]
	  FROM Accounts AS a
	  JOIN AccountHolders AS ah
	    ON ah.Id= a.AccountHolderId
	 WHERE a.Id = @accountId
END

EXEC dbo.usp_CalculateFutureValueForAccount 1, 0.1
GO

-- Diablo database

CREATE OR ALTER FUNCTION ufn_CashInUsersGames (@gameName NVARCHAR(50))
RETURNS TABLE
AS
RETURN (
		 SELECT SUM(a.Cash) AS [SumCash]
		   FROM (
				 SELECT ug.Cash,
						ROW_NUMBER() OVER(ORDER BY ug.Cash DESC) AS [RowNumber] 
				   FROM UsersGames AS ug
				   JOIN Games AS g
					 ON g.Id = ug.GameId
				  WHERE g.Name = @gameName
				) AS a
		  WHERE a.RowNumber % 2 = 1
	   )

SELECT *
  FROM dbo.ufn_CashInUsersGames('Lily Stargazer')
GO

-- Bank database

CREATE TABLE Logs (
	LogId INT IDENTITY,
	AccountId INT,
	OldSum DECIMAL(15, 2),
	NewSum DECIMAL(15, 2)
)
GO

CREATE OR ALTER TRIGGER tr_AccountsUpdate
ON Accounts
AFTER UPDATE
AS
BEGIN
	DECLARE @accountId INT = (
		SELECT Id FROM inserted
	)

	DECLARE @oldSum DECIMAL(15, 2) = (
		SELECT Balance FROM deleted
	)

	DECLARE @newSum DECIMAL(15, 2) = (
		SELECT Balance FROM inserted
	)

	INSERT INTO Logs VALUES
	(@accountId, @oldSum, @newSum)
END

SELECT * FROM Logs
GO

CREATE TABLE NotificationEmails (
	Id INT IDENTITY,
	Recipient INT,
	[Subject] NVARCHAR(100),
	Body NVARCHAR(100)
)
GO

CREATE OR ALTER TRIGGER tr_Logs
ON Logs
FOR INSERT
AS
BEGIN
	DECLARE @recipient INT = (
		SELECT AccountId FROM inserted
	);

	DECLARE @subject NVARCHAR(MAX) = CONCAT('Balance change for account: ', @recipient);

	DECLARE @oldSum DECIMAL(15, 2) = (
		SELECT OldSum FROM inserted
	)

	DECLARE @newSum DECIMAL(15, 2) = (
		SELECT NewSum FROM inserted
	)

	DECLARE @body NVARCHAR(MAX) = CONCAT('On ', GETDATE(), ' your balance was changed from ', @oldSum, ' to ', @newSum, '.');

	INSERT INTO NotificationEmails VALUES
	(@recipient, @subject, @body)
END

UPDATE Accounts
   SET Balance = 123.12
 WHERE Id = 1

SELECT * FROM NotificationEmails
GO

CREATE OR ALTER PROC usp_DepositMoney (@accountId INT, @moneyAmount DECIMAL(18, 4))
AS
BEGIN
	IF (@moneyAmount < 0)
	BEGIN
		RAISERROR('Deposit amount cannot be negative!', 16, 1);
		RETURN;
	END

	UPDATE Accounts
	   SET Balance += @moneyAmount
	 WHERE Id = @accountId
END
GO

CREATE OR ALTER PROC usp_WithdrawMoney (@accountId INT, @moneyAmount DECIMAL(18, 4))
AS
BEGIN
	DECLARE @currentBalance DECIMAL(18, 4) = (
		SELECT Balance FROM Accounts WHERE Id = @accountId
	)

	IF (@moneyAmount < 0 OR @currentBalance < @moneyAmount)
	BEGIN
		RAISERROR('Incorrect withdraw!', 16, 1);
		RETURN;
	END

	UPDATE Accounts
	   SET Balance -= @moneyAmount
	 WHERE Id = @accountId
END
GO

CREATE OR ALTER PROC usp_TransferMoney(@senderId INT, @receiverId INT, @amount DECIMAL(18, 4))
AS
BEGIN
	BEGIN TRANSACTION

	BEGIN TRY
		EXEC dbo.usp_WithdrawMoney @senderId, @amount;
		EXEC dbo.usp_DepositMoney @receiverId, @amount;
	END TRY
	BEGIN CATCH
		RAISERROR('Error!', 16, 1);
		ROLLBACK;
		RETURN;
	END CATCH

	COMMIT
END

EXEC dbo.usp_TransferMoney 1, 5, 5000

SELECT * FROM Accounts
GO

-- SoftUni database

CREATE PROC usp_AssignProject(@emloyeeId INT, @projectID INT)
AS
BEGIN
	BEGIN TRANSACTION

	INSERT INTO EmployeesProjects VALUES
	(@emloyeeId, @projectID)

	DECLARE @projectsCount INT = (
		SELECT COUNT(ProjectID) FROM EmployeesProjects WHERE EmployeeID = @emloyeeId
	);

	IF (@projectsCount > 3)
	BEGIN
		RAISERROR('The employee has too many projects!', 16, 1);
		ROLLBACK;
		RETURN;
	END

	COMMIT;
END
GO

CREATE TABLE Deleted_Employees (
	EmployeeId INT PRIMARY KEY,
	FirstName NVARCHAR(50),
	LastName NVARCHAR(50),
	MiddleName NVARCHAR(50),
	JobTitle NVARCHAR(50),
	DepartmentId INT,
	Salary DECIMAL(15, 2)
)
GO

CREATE OR ALTER TRIGGER tr_Employees
ON Employees
INSTEAD OF DELETE
AS 
BEGIN
	INSERT INTO Deleted_Employees
	SELECT EmployeeID, FirstName, LastName, MiddleName, JobTitle, DepartmentID, Salary
	  FROM deleted
END

DELETE 
  FROM Employees
 WHERE EmployeeID = 4

SELECT * FROM Employees
SELECT * FROM Deleted_Employees

-- Diablo database

BEGIN TRANSACTION [Tran1]

BEGIN TRY
	UPDATE UsersGames
	   SET Cash -=
		   (
				SELECT SUM(Price)
				  FROM Items
				 WHERE MinLevel BETWEEN 11 AND 12
		   )
	 WHERE Id = 110

	INSERT INTO UserGameItems
	SELECT Id, 110
	  FROM Items
	 WHERE MinLevel BETWEEN 11 AND 12

	COMMIT TRANSACTION [Tran1]
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION [Tran1];
END CATCH

BEGIN TRANSACTION [Tran2]

BEGIN TRY
	UPDATE UsersGames
	   SET Cash -= 
		   (
				SELECT SUM(Price)
				  FROM Items
				 WHERE MinLevel BETWEEN 19 AND 21
		   )
	 WHERE Id = 110

	INSERT INTO UserGameItems
	SELECT Id, 110
	  FROM Items 
	 WHERE MinLevel BETWEEN 19 AND 21

	COMMIT TRANSACTION [Tran2]
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION [Tran2];
END CATCH

  SELECT i.Name AS [Item Name]
    FROM UserGameItems AS ugi
    JOIN Items i
      ON i.Id = ugi.ItemId
   WHERE ugi.UserGameId = 110
ORDER BY i.Name
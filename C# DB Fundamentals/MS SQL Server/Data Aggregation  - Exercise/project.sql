SELECT COUNT(*)
	AS [Count]
  FROM WizzardDeposits

SELECT MAX(MagicWandSize)
	AS LongestMagicWand
  FROM WizzardDeposits

SELECT DepositGroup, MAX(MagicWandSize) AS LongestMagicWand
  FROM WizzardDeposits
GROUP BY DepositGroup

SELECT TOP(2) DepositGroup
  FROM WizzardDeposits
GROUP BY DepositGroup
ORDER BY AVG(MagicWandSize)

SELECT DepositGroup, SUM(DepositAmount)
  FROM WizzardDeposits
GROUP BY DepositGroup

  SELECT DepositGroup, SUM(DepositAmount)
	FROM WizzardDeposits
   WHERE MagicWandCreator = 'Ollivander family' 
GROUP BY DepositGroup

SELECT *
  FROM WizzardDeposits

  SELECT DepositGroup,
		 SUM(DepositAmount) AS TotalSum
	FROM WizzardDeposits
   WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup
  HAVING SUM(DepositAmount) < 150000
ORDER BY TotalSum DESC

SELECT DepositGroup,
	   MagicWandCreator,
	   MIN(DepositCharge) AS MinDepositCharge
  FROM WizzardDeposits
GROUP BY DepositGroup, MagicWandCreator
ORDER BY MagicWandCreator, DepositGroup

SELECT LEFT(FirstName, 1) AS FirstLetter
  FROM WizzardDeposits
WHERE DepositGroup = 'Troll Chest'
GROUP BY LEFT(FirstName, 1)
ORDER BY FirstLetter

SELECT *
  FROM WizzardDeposits

SELECT DepositGroup, IsDepositExpired, AVG(DepositInterest) AS AverageInterest
  FROM WizzardDeposits
 WHERE DepositStartDate > '1985-01-01'
GROUP BY DepositGroup, IsDepositExpired
ORDER BY DepositGroup DESC, IsDepositExpired

SELECT *
  FROM WizzardDeposits

SELECT FirstName AS [Host Wizard], 
	   DepositAmount AS [Host Wizard Deposit],
	   LEAD(FirstName, 1,0) AS [Guest Wizard],
	   LEAD(DepositAmount, 1, 0) AS [Guest Wizard Deposit],
	   DepositAmount - LEAD(DepositAmount, 1, 0) AS 'Difference'
  FROM WizzardDeposits

SELECT DepartmentID, SUM(Salary) AS TotalSalary
  FROM Employees
GROUP BY DepartmentID
ORDER BY DepartmentID

SELECT DepartmentID, MIN(Salary) AS MinimumSalary
  FROM Employees
 WHERE HireDate > '2000-01-01'
GROUP BY DepartmentID
HAVING DepartmentID IN (2, 5, 7) 

SELECT * FROM Employees

SELECT DepartmentID, MAX(Salary) AS MaxSalary
  FROM Employees
GROUP BY DepartmentID
HAVING MAX(Salary) < 30000
   OR MAX(Salary) > 70000

SELECT COUNT(Salary) AS [Count]
  FROM Employees
 WHERE ManagerID IS NULL

SELECT AgeGroup =
	   CASE
			WHEN Age >= 0 AND Age <= 10 THEN '[0-10]'
			WHEN Age >= 11 AND Age <= 20 THEN '[11-20]'
			WHEN Age >= 21 AND Age <= 30 THEN '[21-30]'
			WHEN Age >= 31 AND Age <= 40 THEN '[31-40]'
			WHEN Age >= 41 AND Age <= 50 THEN '[41-50]'
			WHEN Age >= 51 AND Age <= 60 THEN '[51-60]'
			WHEN Age >= 61 THEN '[61+]'
	   END,
	   COUNT(*) AS WizardCount
  FROM WizzardDeposits
GROUP BY CASE
			WHEN Age >= 0 AND Age <= 10 THEN '[0-10]'
			WHEN Age >= 11 AND Age <= 20 THEN '[11-20]'
			WHEN Age >= 21 AND Age <= 30 THEN '[21-30]'
			WHEN Age >= 31 AND Age <= 40 THEN '[31-40]'
			WHEN Age >= 41 AND Age <= 50 THEN '[41-50]'
			WHEN Age >= 51 AND Age <= 60 THEN '[51-60]'
			WHEN Age >= 61 THEN '[61+]'
	     END

SELECT SUM(DiffTable.Diff) AS [SumDifference]
  FROM (
		SELECT DepositAmount -
			   (SELECT DepositAmount
				  FROM WizzardDeposits 
				 WHERE Id = Host.Id + 1)
			AS [Diff]
		  FROM WizzardDeposits AS Host)
	AS [DiffTable]

-- same as above
SELECT SUM(DiffTable.Diff) AS [SumDifference]
  FROM (
		SELECT DepositAmount -
			   LEAD(DepositAmount) OVER (ORDER BY ID)
			AS Diff
		  FROM WizzardDeposits
	   ) AS DiffTable

SELECT *
  INTO EmployeesAverageSalaries
  FROM Employees
 WHERE Salary > 30000

DELETE 
  FROM EmployeesAverageSalaries
 WHERE ManagerID = 42

UPDATE EmployeesAverageSalaries
   SET Salary += 5000
 WHERE DepartmentID = 1

SELECT DepartmentID, AVG(Salary) AS [MaxSalary]
  FROM EmployeesAverageSalaries
GROUP BY DepartmentID

SELECT TOP(10) FirstName, LastName, DepartmentID
  FROM Employees AS emp
 WHERE Salary > (SELECT AVG(Salary) 
				 FROM Employees
				 GROUP BY DepartmentID
				 HAVING DepartmentID = emp.DepartmentID)
ORDER BY DepartmentID

SELECT DISTINCT DepartmentID, Salary
  FROM (SELECT DepartmentID,
			   Salary,
			   DENSE_RANK() OVER (PARTITION BY DepartmentID ORDER BY Salary DESC) AS [SalaryRank]
		  FROM Employees) AS e
 WHERE SalaryRank = 3
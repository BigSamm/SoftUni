CREATE TABLE Models (
	ModelId INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) UNIQUE NOT NULL
)

CREATE TABLE Mechanics (
	MechanicId INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	[Address] VARCHAR(255) NOT NULL
)

CREATE TABLE Clients (
	ClientId INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	Phone CHAR(12) NOT NULL
)

CREATE TABLE Vendors (
	VendorId INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) UNIQUE NOT NULL
)

CREATE TABLE Jobs (
	JobId INT PRIMARY KEY IDENTITY,
	ModelId INT FOREIGN KEY REFERENCES Models(ModelId) NOT NULL,
	[Status] VARCHAR(11) DEFAULT('Pending') NOT NULL,
	ClientId INT FOREIGN KEY REFERENCES Clients(ClientId) NOT NULL,
	MechanicId INT FOREIGN KEY REFERENCES Mechanics(MechanicId),
	IssueDate DATE NOT NULL,
	FinishDate DATE
)

CREATE TABLE Orders (
	OrderId INT PRIMARY KEY IDENTITY,
	JobId INT FOREIGN KEY REFERENCES Jobs(JobId) NOT NULL,
	IssueDate DATE,
	Delivered BIT DEFAULT(0) NOT NULL
)

CREATE TABLE Parts (
	PartId INT PRIMARY KEY IDENTITY,
	SerialNumber VARCHAR(50) UNIQUE NOT NULL,
	[Description] VARCHAR(255),
	Price DECIMAL(6, 2) NOT NULL,
	VendorId INT FOREIGN KEY REFERENCES Vendors(VendorId) NOT NULL,
	StockQty INT DEFAULT(0) NOT NULL,

	CHECK (Price > 0),
	CHECK (StockQty >= 0)
)

CREATE TABLE OrderParts (
	OrderId INT FOREIGN KEY REFERENCES Orders(OrderId) NOT NULL,
	PartId INT FOREIGN KEY REFERENCES Parts(PartId) NOT NULL,
	Quantity INT DEFAULT(1) NOT NULL,

	CHECK (Quantity > 0),

	CONSTRAINT PK_OrderParts
	PRIMARY KEY (OrderId, PartId)
)

CREATE TABLE PartsNeeded (
	JobId INT FOREIGN KEY REFERENCES Jobs(JobId) NOT NULL,
	PartId INT FOREIGN KEY REFERENCES Parts(PartId) NOT NULL,
	Quantity INT DEFAULT(1) NOT NULL,

	CHECK (Quantity > 0),

	CONSTRAINT PK_PartsNeeded
	PRIMARY KEY (JobId, PartId)
)

---------------------------------------------------------------------------

INSERT INTO Clients (FirstName, LastName, Phone)
VALUES
('Teri', 'Ennaco', '570-889-5187'),
('Merlyn', 'Lawler', '201-588-7810'),
('Georgene', 'Montezuma', '925-615-5185'),
('Jettie', 'Mconnell', '908-802-3564'),
('Lemuel', 'Latzke', '631-748-6479'),
('Melodie', 'Knipp', '805-690-1682'),
('Candida', 'Corbley', '908-275-8357')

INSERT INTO Parts (SerialNumber, [Description], Price, VendorId)
VALUES
('WP8182119', 'Door Boot Seal', 117.86, 2),
('W10780048', 'Suspension Rod', 42.81, 1),
('W10841140', 'Silicone Adhesive', 6.77, 4),
('WPY055980', 'High Temperature Adhesive', 13.94, 3)

---------------------------------------------------------------------------

UPDATE Jobs
   SET MechanicId = 3, [Status] = 'In Progress'
 WHERE [Status] = 'Pending'
 
---------------------------------------------------------------------------

ALTER TABLE OrderParts 
  ADD CONSTRAINT FK_OrderParts_Parts
  FOREIGN KEY (OrderId) 
  REFERENCES Orders(OrderId) 
  ON DELETE CASCADE;

DELETE
  FROM Orders
 WHERE OrderId = 19
 
---------------------------------------------------------------------------

  SELECT FirstName, LastName, Phone
    FROM Clients
ORDER BY LastName, ClientId

---------------------------------------------------------------------------

  SELECT [Status], IssueDate
    FROM Jobs
   WHERE [Status] <> 'Finished'
ORDER BY IssueDate, JobId

---------------------------------------------------------------------------

  SELECT m.FirstName + ' ' + m.LastName AS [Mechanic],
		 j.[Status],
		 j.IssueDate   
    FROM Jobs AS j
    JOIN Mechanics AS m
      ON m.MechanicId = j.MechanicId
ORDER BY m.MechanicId, j.IssueDate, j.JobId

---------------------------------------------------------------------------

  SELECT c.FirstName + ' ' + c.LastName AS [Client],
		 DATEDIFF(DAY, j.IssueDate, '2017-04-24') AS [Days going],
		 j.[Status]
    FROM Jobs AS j
    JOIN Clients AS c
      ON c.ClientId = j.ClientId
   WHERE j.[Status] <> 'Finished'
ORDER BY [Days going] DESC, c.ClientId

---------------------------------------------------------------------------

  SELECT m.FirstName + ' ' + m.LastName AS [Mechanic],
		 ROUND(AVG(DATEDIFF(DAY, j.IssueDate, j.FinishDate)), 0) AS [Average Days]
    FROM Jobs AS j
	JOIN Mechanics AS m
	  ON m.MechanicId = j.MechanicId
   WHERE j.FinishDate IS NOT NULL
GROUP BY m.FirstName + ' ' + m.LastName, m.MechanicId
ORDER BY m.MechanicId

---------------------------------------------------------------------------

  SELECT m.FirstName + ' ' + m.LastName AS [Mechanic],
		 COUNT(j.JobId) AS [Jobs]
    FROM Jobs AS j
	JOIN Mechanics AS m
	  ON m.MechanicId = j.MechanicId
   WHERE j.FinishDate IS NULL
GROUP BY m.FirstName + ' ' + m.LastName, m.MechanicId
  HAVING COUNT(j.JobId) > 1
ORDER BY [Jobs] DESC, m.MechanicId

---------------------------------------------------------------------------

WITH cte_BusyMechanics (MechanicId)
AS
(
	  SELECT m.MechanicId
		FROM Jobs AS j
		JOIN Mechanics AS m
		  ON m.MechanicId = j.MechanicId
	   WHERE j.FinishDate IS NULL
	GROUP BY m.MechanicId
)

   SELECT m.FirstName + ' ' + m.LastName AS [Available]
	 FROM Mechanics AS m
LEFT JOIN cte_BusyMechanics AS bm
	   ON bm.MechanicId = m.MechanicId
	WHERE bm.MechanicId IS NULL
	
---------------------------------------------------------------------------

SELECT ISNULL(SUM(p.Price * op.Quantity), 0) AS [Parts Total]
  FROM Parts AS p
  JOIN OrderParts AS op
	ON op.PartId = p.PartId
  JOIN Orders AS o
	ON o.OrderId = op.OrderId
 WHERE DATEDIFF(WEEK, o.IssueDate, '2017-04-24') <= 3
 
---------------------------------------------------------------------------

   SELECT j.JobId,
		  ISNULL(SUM(p.Price * op.Quantity), 0) AS Total
     FROM Jobs AS j
LEFT JOIN Orders AS o
       ON o.JobId = j.JobId
LEFT JOIN OrderParts AS op
       ON op.OrderId = o.OrderId
LEFT JOIN Parts AS p
       ON p.PartId = op.PartId
	WHERE j.FinishDate IS NOT NULL
 GROUP BY j.JobId
 ORDER BY Total DESC, j.JobId

---------------------------------------------------------------------------

  SELECT m.ModelId,
		 m.[Name],
		 CAST(ROUND(AVG(DATEDIFF(DAY, j.IssueDate, j.FinishDate)), 0) AS VARCHAR) + ' days' AS [Average Service Time]
    FROM Jobs AS j
	JOIN Models AS m
	  ON m.ModelId = j.ModelId
   WHERE j.FinishDate IS NOT NULL
GROUP BY m.ModelId, m.[Name]
ORDER BY ROUND(AVG(DATEDIFF(DAY, j.IssueDate, j.FinishDate)), 0)

---------------------------------------------------------------------------

WITH cte_JobsPrice (JobId, JobPrice)
AS
(
		  SELECT j.JobId,
			  ISNULL(SUM(p.Price * op.Quantity), 0) AS Total
		 FROM Jobs AS j
	LEFT JOIN Orders AS o
		   ON o.JobId = j.JobId
	LEFT JOIN OrderParts AS op
		   ON op.OrderId = o.OrderId
	LEFT JOIN Parts AS p
		   ON p.PartId = op.PartId
	 GROUP BY j.JobId
)

SELECT Model, [Times Serviced], [Parts Total]
  FROM (
		  SELECT m.[Name] AS [Model],
				 COUNT(j.JobId) AS [Times Serviced],
				 SUM(jp.JobPrice) AS [Parts Total],
				 ROW_NUMBER() OVER (ORDER BY COUNT(j.JobId) DESC) AS [Rank]
			FROM Models AS m
			JOIN Jobs AS j
			  ON j.ModelId = m.ModelId
			JOIN cte_JobsPrice AS jp
			  ON jp.JobId = j.JobId
		GROUP BY m.[Name]
	   ) AS H
 WHERE [Rank] = 1

---------------------------------------------------------------------------
GO

  SELECT p.PartId,
		 p.[Description],
		 SUM(pn.Quantity) AS [Required],
		 SUM(p.StockQty) AS [In Stock],
		 ISNULL(SUM(op.Quantity), 0) AS [Ordered]
    FROM Parts AS p
    JOIN PartsNeeded AS pn
	  ON pn.PartId = p.PartId
    JOIN Jobs AS j
      ON j.JobId = pn.JobId
LEFT JOIN Orders AS o
	  ON o.JobId = j.JobId
LEFT JOIN OrderParts AS op
	  ON op.OrderId = o.OrderId
   WHERE j.FinishDate IS NULL
GROUP BY p.PartId, p.[Description]
  HAVING SUM(pn.Quantity) > SUM(p.StockQty) + ISNULL(SUM(op.Quantity), 0)

---------------------------------------------------------------------------
GO

CREATE OR ALTER FUNCTION udf_GetCost (@jobId INT)
RETURNS DECIMAL(18, 2)
AS
BEGIN
DECLARE @result DECIMAL(18, 2) = (
	  SELECT SUM(p.Price * op.Quantity) AS [Result]
		FROM Jobs AS j
		JOIN Orders AS o
		  ON o.JobId = j.JobId
		JOIN OrderParts AS op
		  ON op.OrderId = o.OrderId
		JOIN Parts AS p
		  ON p.PartId = op.PartId
	   WHERE j.JobId = @jobId
	GROUP BY j.JobId);

IF (@result IS NULL)
BEGIN
	SET @result = 0;
END

RETURN @result;
END

SELEORDERCT dbo.udf_GetCost(1)

---------------------------------------------------------------------------
GO

CREATE OR ALTER PROC usp_PlaceOrder (@jobId INT, @partSerialNum VARCHAR(50), @quantity INT)
AS
BEGIN
	
END

---------------------------------------------------------------------------
GO

CREATE OR ALTER TRIGGER tr_OrderDeliver
ON Orders
FOR UPDATE
AS
BEGIN
	UPDATE Parts
	   SET StockQty += op.Quantity
	  FROM Parts AS p
	  JOIN OrderParts AS op
	    ON op.PartId = p.PartId
	  JOIN inserted AS i
	    ON i.OrderId = op.OrderId
	  JOIN deleted AS d
	    ON d.OrderId = op.OrderId
END
 
---------------------------------------------------------------------------

  SELECT CONCAT(m.FirstName, ' ', m.LastName) AS [Mechanic],
		 v.[Name] AS [Vendor],
		 SUM(op.Quantity) AS [Parts],
		 CAST(CONVERT(INT, SUM(op.Quantity) * 100.0 / H.[Count]) AS VARCHAR) + '%' AS [Preference]
    FROM Vendors AS v
	JOIN Parts AS p
	  ON p.VendorId = v.VendorId
	JOIN PartsNeeded AS pn
	  ON pn.PartId = p.PartId
	JOIN Jobs AS j
	  ON j.JobId = pn.JobId
	JOIN Mechanics AS m
	  ON m.MechanicId = j.MechanicId
	JOIN Orders AS o
	  ON o.JobId = j.JobId
	JOIN OrderParts AS op
	  ON op.OrderId = o.OrderId AND op.PartId = p.PartId
	JOIN (
		  SELECT m.MechanicId,
				 SUM(op.Quantity) AS [Count]
		  FROM Parts AS p
		  JOIN PartsNeeded AS pn
		  ON pn.PartId = p.PartId
		  JOIN Jobs AS j
		  ON j.JobId = pn.JobId
		  JOIN Mechanics AS m
		  ON m.MechanicId = j.MechanicId
		  JOIN Orders AS o
		  ON o.JobId = j.JobId
		  JOIN OrderParts AS op
		  ON op.OrderId = o.OrderId AND op.PartId = p.PartId
		  GROUP BY m.MechanicId
		 ) AS H
	  ON H.MechanicId = m.MechanicId
GROUP BY CONCAT(m.FirstName, ' ', m.LastName), v.[Name], H.[Count]
ORDER BY [Mechanic], [Parts] DESC, [Vendor]

select * from Mechanics
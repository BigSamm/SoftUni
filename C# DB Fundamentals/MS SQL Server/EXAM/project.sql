-- 01. DDL

CREATE TABLE Cities (
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(20) NOT NULL,
	CountryCode CHAR(2) NOT NULL,
)

CREATE TABLE Hotels (
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(30) NOT NULL,
	CityId INT FOREIGN KEY REFERENCES Cities(Id) NOT NULL,
	EmployeeCount INT NOT NULL,
	BaseRate DECIMAL(15, 2)
)

CREATE TABLE Rooms (
	Id INT PRIMARY KEY IDENTITY,
	Price DECIMAL(15, 2) NOT NULL,
	[Type] NVARCHAR(20) NOT NULL,
	Beds INT NOT NULL,
	HotelId INT FOREIGN KEY REFERENCES Hotels(Id) NOT NULL
)

CREATE TABLE Trips (
	Id INT PRIMARY KEY IDENTITY,
	RoomId INT FOREIGN KEY REFERENCES Rooms(Id) NOT NULL,
	BookDate DATE NOT NULL,
	ArrivalDate DATE NOT NULL,
	ReturnDate DATE NOT NULL,
	CancelDate DATE,

	CHECK (BookDate < ArrivalDate),
	CHECK (ArrivalDate < ReturnDate)
)

CREATE TABLE Accounts (
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(50) NOT NULL,
	MiddleName NVARCHAR(20),
	LastName NVARCHAR(50) NOT NULL,
	CityId INT FOREIGN KEY REFERENCES Cities(Id) NOT NULL,
	BirthDate DATE NOT NULL,
	Email VARCHAR(100) UNIQUE NOT NULL
)

CREATE TABLE AccountsTrips (
	AccountId INT FOREIGN KEY REFERENCES Accounts(Id) NOT NULL,
	TripId INT FOREIGN KEY REFERENCES Trips(Id) NOT NULL,
	Luggage INT NOT NULL,

	CHECK (Luggage >= 0),

	CONSTRAINT PK_AccountsTrips
	PRIMARY KEY (AccountId, TripId)
)

-- 02. Insert 

INSERT INTO Accounts (FirstName, MiddleName, LastName, CityId, BirthDate, Email)
VALUES
('John', 'Smith', 'Smith', 34, '1975-07-21', 'j_smith@gmail.com'),
('Gosho', NULL, 'Petrov', 11, '1978-05-16', 'g_petrov@gmail.com'),
('Ivan', 'Petrovich', 'Pavlov', 59, '1849-09-26', 'i_pavlov@softuni.bg'),
('Friedrich', 'Wilhelm', 'Nietzsche', 2, '1844-10-15', 'f_nietzsche@softuni.bg')

INSERT INTO Trips (RoomId, BookDate, ArrivalDate, ReturnDate, CancelDate)
VALUES
(101, '2015-04-12', '2015-04-14', '2015-04-20', '2015-02-02'),
(102, '2015-07-07', '2015-07-15', '2015-07-22', '2015-04-29'),
(103, '2013-07-17', '2013-07-23', '2013-07-24', NULL),
(104, '2012-03-17', '2012-03-31', '2012-04-01', '2012-01-10'),
(109, '2017-08-07', '2017-08-28', '2017-08-29', NULL)

-- 03. Update 

UPDATE Rooms
   SET Price += Price * 0.14
 WHERE HotelId IN (5, 7, 9)

-- 04. Delete

ALTER TABLE Trips
	ADD CONSTRAINT FK_Trips_AccountsTrips
	FOREIGN KEY (Id)
	REFERENCES AccountsTrips(TripId)
	ON DELETE CASCADE;

DELETE
  FROM AccountsTrips
 WHERE AccountId = 47

-- 05. Bulgarian Cities 

  SELECT Id,
		 [Name]
    FROM Cities
   WHERE CountryCode = 'BG'
ORDER BY [Name]

-- 06. People Born After 1991 

  SELECT FirstName + ' ' + ISNULL(MiddleName + ' ', '') + LastName AS [Full Name],
		 DATEPART(YEAR, BirthDate) AS [BirthYear]
    FROM Accounts
   WHERE DATEPART(YEAR, BirthDate) > 1991
ORDER BY [BirthYear] DESC, FirstName

-- 07. EEE-Mails

  SELECT a.FirstName,
		 a.LastName,
		 FORMAT(a.BirthDate, 'MM-dd-yyyy') AS [BirthDate],
		 c.[Name] AS Hometown,
		 a.Email
    FROM Accounts AS a
	JOIN Cities AS c
	  ON c.Id = a.CityId
   WHERE a.Email LIKE 'e%'
ORDER BY c.[Name] DESC

-- 08. City Statistics

   SELECT c.[Name] AS City,
		  COUNT(h.Id) AS Hotels
     FROM Cities AS c
LEFT JOIN Hotels AS h
	   ON h.CityId = c.Id
 GROUP BY c.[Name]
 ORDER BY Hotels DESC, City

-- 09. Expensive First Class Rooms

  SELECT r.Id,
		 r.Price,
		 h.[Name] AS [Hotel],
		 c.[Name] AS [City]
    FROM Rooms AS r
	JOIN Hotels AS h
	  ON h.Id = r.HotelId
	JOIN Cities AS c
	  ON c.Id = h.CityId
   WHERE r.[Type] = 'First Class'
ORDER BY r.Price DESC, r.Id

-- 10. Longest and Shortest Trips

  SELECT H.AccountId,
		 H.FullName,
		 MAX(H.[Days]) AS [LongestTrip],
		 MIN(H.[Days]) AS [ShortestTrip]
    FROM (
		  SELECT a.Id AS [AccountId],
				 CONCAT(a.FirstName, ' ', a.LastName) AS [FullName],
				 DATEDIFF(DAY, t.ArrivalDate, t.ReturnDate) AS [Days]
			FROM Trips AS t
			JOIN AccountsTrips AS [at]
			  ON [at].TripId = t.Id
			JOIN Accounts AS a
			  ON a.Id = [at].AccountId
		   WHERE a.MiddleName IS NULL
			 AND t.CancelDate IS NULL
	     ) AS H
GROUP BY H.AccountId, H.FullName
ORDER BY [LongestTrip] DESC, H.AccountId

-- 11. Metropolis

SELECT H.CityId AS [Id],
	   H.CityName AS [City],
	   c.CountryCode AS [Country],
	   H.Accounts
  FROM (
		  SELECT TOP(5) c.Id AS [CityId],
				 c.[Name] AS [CityName],
				 COUNT(a.Id) AS [Accounts]
			FROM Cities AS c
			JOIN Accounts AS a
			  ON a.CityId = c.Id
		GROUP BY c.Id, c.[Name]
		ORDER BY [Accounts] DESC
	   ) AS H
  JOIN Cities AS c
    ON c.Id = H.CityId

-- 12. Romantic Getaways

  SELECT a.Id,
		 a.Email,
		 c.[Name] AS [City],
		 COUNT(t.Id) AS [Trips]
    FROM Accounts AS a
	JOIN AccountsTrips AS ats
	  ON ats.AccountId = a.Id
	JOIN Trips AS t
	  ON t.Id = ats.TripId
	JOIN Rooms AS r
	  ON r.Id = t.RoomId
	JOIN Hotels AS h
	  ON h.Id = r.HotelId
	JOIN Cities AS c
	  ON c.Id = h.CityId AND c.Id = a.CityId
GROUP BY a.Id, a.Email, c.[Name]
  HAVING COUNT(t.Id) > 0
ORDER BY [Trips] DESC, a.Id

-- 13. Lucrative Destinations

  SELECT TOP(10) c.Id,
	     c.[Name],
		SUM(h.BaseRate + r.Price) AS [Total Revenue],
		COUNT(t.Id) AS [Trips]
	FROM Cities AS c
	JOIN Hotels AS h
	ON h.CityId = c.Id
	JOIN Rooms AS r
	ON R.HotelId = H.Id
	JOIN Trips AS t
	ON t.RoomId = r.Id
	WHERE DATEPART(YEAR, t.BookDate) = 2016
GROUP BY c.Id, c.[Name]
ORDER BY [Total Revenue] DESC, [Trips] DESC

-- 14. Trip Revenues

  SELECT t.Id,
	     h.[Name] AS [HotelName],
		 r.[Type] AS [RoomType],
		 SUM(CASE
			     WHEN t.CancelDate IS NOT NULL THEN 0
				 ELSE h.BaseRate + r.Price
			 END) AS [Revenue]
	FROM Hotels AS h
	JOIN Rooms AS r
	  ON R.HotelId = H.Id
	JOIN Trips AS t
	  ON t.RoomId = r.Id
	JOIN AccountsTrips AS ats
	  ON ats.TripId = t.Id
GROUP BY t.Id, h.[Name], r.[Type]
ORDER BY [RoomType], t.Id

-- 15. Top Travelers

  SELECT H.Id,
		 H.Email,
		 H.CountryCode,
		 H.Trips	   
    FROM (
		    SELECT a.Id,
		  		   a.Email,
		  		   c.CountryCode,
		  		   COUNT(t.Id) AS [Trips],
		  		   ROW_NUMBER() OVER (PARTITION BY c.CountryCode ORDER BY COUNT(t.Id) DESC) AS [Rank]
		  	  FROM Cities AS c
		  	  JOIN Hotels AS h
		  	    ON h.CityId = c.Id
		  	  JOIN Rooms AS r
		  	    ON r.HotelId = h.Id
		  	  JOIN Trips AS t
		  	    ON t.RoomId = R.Id
		  	  JOIN AccountsTrips AS ats
		  	    ON ats.TripId = t.Id
		  	  JOIN Accounts AS a
		  	    ON a.Id = ats.AccountId
		  GROUP BY a.Id, a.Email, c.CountryCode
	     ) AS H
   WHERE H.[Rank] = 1
ORDER BY H.Trips DESC, H.Id

-- 16. Luggage Fees

  SELECT t.Id,
		 SUM(ats.Luggage) AS [Luggage],
		 '$' + CAST(CASE
				   WHEN SUM(ats.Luggage) > 5 THEN SUM(ats.Luggage) * 5
			       ELSE 0
			   END AS VARCHAR) AS [Fee]
    FROM Trips AS t
	JOIN AccountsTrips AS ats
	  ON ats.TripId = t.Id
GROUP BY t.Id
  HAVING SUM(ats.Luggage) > 0
ORDER BY [Luggage] DESC

-- 17. GDPR Violation

  SELECT t.Id,
		 a.FirstName + ' ' + ISNULL(a.MiddleName + ' ', '') + a.LastName AS [Full Name],
		 c.[Name] AS [From],
		 H.CityName AS [To],
		 CASE
		    WHEN t.CancelDate IS NOT NULL THEN 'Canceled'
			ELSE CAST(DATEDIFF(DAY, t.ArrivalDate, t.ReturnDate) AS VARCHAR) + ' days'
		 END AS [Duration]
    FROM Trips AS t
	JOIN AccountsTrips AS ats
	  ON ats.TripId = t.Id
	JOIN Accounts AS a
	  ON a.Id = ats.AccountId
	JOIN Cities AS c
	  ON c.Id = a.CityId
	JOIN (
		  SELECT t.Id AS [TripId],
				 c.[Name] AS [CityName]
		  	FROM Trips AS t
		  	JOIN Rooms AS r
		  	  ON r.Id = t.RoomId
		  	JOIN Hotels AS h
		  	  ON h.Id = r.HotelId
		  	JOIN Cities AS c
		  	  ON c.Id = h.CityId
		 ) AS H
	  ON H.TripId = t.Id
ORDER BY [Full Name], t.Id

-- 18. Available Room
GO

CREATE OR ALTER FUNCTION udf_GetAvailableRoom(@HotelId INT, @Date DATE, @People INT)
RETURNS VARCHAR(MAX)
AS
BEGIN
	DECLARE @result VARCHAR(MAX) = (
		SELECT CONCAT('Room ', R.Id, ': ', R.[Type], ' (', R.Beds, ' beds) - $', r.TotalPrice)
		  FROM (
				SELECT TOP(1) r.Id AS [Id],
					   r.[Type] AS [Type],
					   r.Beds AS [Beds],
					   (h.BaseRate + r.Price) * 2 AS [TotalPrice]
				  FROM Hotels AS h
				  JOIN Rooms AS r
	 				ON r.HotelId = h.Id
				  JOIN Trips AS t
					ON t.RoomId = r.Id
				 WHERE (@Date < t.ArrivalDate OR @Date > t.ReturnDate) 
				   AND (t.CancelDate IS NULL)
				   AND (r.HotelId = @HotelId)
				   AND (r.Beds >= @People)
			ORDER BY [TotalPrice] DESC
			) AS R
	)
	
	IF (@result IS NULL)
	BEGIN
		RETURN 'No rooms available';
	END

	DECLARE @roomIdStr VARCHAR(3) = SUBSTRING(@result, 6, 1);
	IF (SUBSTRING(@result, 7, 1) LIKE '[0-9]')
	BEGIN
		SET @roomIdStr = CONCAT(@roomIdStr, SUBSTRING(@result, 7, 1));
	END
	IF (SUBSTRING(@result, 8, 1) LIKE '[0-9]')
	BEGIN
		SET @roomIdStr = CONCAT(@roomIdStr, SUBSTRING(@result, 8, 1));
	END
	DECLARE @roomId INT = CONVERT(INT, @roomIdStr);
	DECLARE @totalCount INT = (SELECT COUNT(*) FROM Rooms AS r JOIN Trips AS t ON t.RoomId = r.Id WHERE r.Id = @roomId);
	DECLARE @validsCount INT = (SELECT COUNT(*) FROM Rooms AS r JOIN Trips AS t ON t.RoomId = r.Id WHERE r.Id = @roomId AND (@Date < t.ArrivalDate OR @Date > t.ReturnDate));

	IF (@totalCount <> @validsCount)
	BEGIN
		RETURN 'No rooms available';
	END

	RETURN @result;
END

SELECT dbo.udf_GetAvailableRoom(112, '2011-12-17', 2)
SELECT dbo.udf_GetAvailableRoom(94, '2015-07-26', 3)

-- 19. Switch Room
GO

CREATE PROC usp_SwitchRoom(@TripId INT, @TargetRoomId INT)
AS
BEGIN
	DECLARE @tripCurrentHotelId INT = (
		SELECT h.Id
		  FROM Trips AS t
		  JOIN Rooms AS r ON r.Id = t.RoomId
		  JOIN Hotels AS h ON h.Id = r.HotelId
		 WHERE t.Id = @TripId
	);
	DECLARE @targetHotelId INT = (SELECT HotelId FROM Rooms WHERE Id = @TargetRoomId);

	IF (@tripCurrentHotelId <> @targetHotelId)
	BEGIN 
		RAISERROR('Target room is in another hotel!', 16, 1);
		RETURN;
	END

	DECLARE @targetRoomBedsCount INT = (SELECT Beds FROM Rooms WHERE Id = @TargetRoomId);
	DECLARE @tripAccounts INT = (
		SELECT COUNT(ats.AccountId)
		  FROM Trips AS t
		  JOIN AccountsTrips AS ats
		    ON ats.TripId = t.Id
		 WHERE t.Id = @TripId
	);

	IF (@targetRoomBedsCount < @tripAccounts)
	BEGIN
		RAISERROR('Not enough beds in target room!', 16, 2);
		RETURN;
	END

	UPDATE Trips
	   SET RoomId = @TargetRoomId
	 WHERE Id = @TripId
END

-- 20. Cancel Trip
GO

CREATE OR ALTER TRIGGER tr_DeleteTrip
ON Trips
INSTEAD OF DELETE
AS
BEGIN
	UPDATE Trips
	   SET CancelDate = GETDATE()
	  FROM Trips AS t
	  JOIN deleted AS d
	    ON d.Id = t.Id
	 WHERE t.CancelDate IS NULL
END

BEGIN TRANSACTION

DELETE FROM Trips
WHERE Id IN (1, 2, 3)

ROLLBACK
CREATE DATABASE Minions

CREATE TABLE Minions (
	Id INT PRIMARY KEY,
	[Name] NVARCHAR(50),
	Age INT
)

SELECT * FROM Minions

USE Minions

CREATE TABLE Towns (
	Id INT PRIMARY KEY,
	[Name] NVARCHAR(50)
)

SELECT * FROM Towns

ALTER TABLE Minions
		ADD TownId INT

ALTER TABLE Minions
ADD FOREIGN KEY (TownId) REFERENCES Towns(Id)

INSERT INTO Towns VALUES
(1, 'Sofia'),
(2, 'Plovdiv'),
(3, 'Varna')

INSERT INTO Minions VALUES
(1, 'Kevin', 22, 1),
(2, 'Bob', 15, 3),
(3, 'Steward', NULL, 2)

TRUNCATE TABLE Minions

SELECT * FROM Minions

DROP TABLE Minions

DROP TABLE Towns

CREATE TABLE People (
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(200) NOT NULL,
	Picture VARBINARY(2000),
	Height DECIMAL(3, 2),
	[Weight] DECIMAL(5, 2),
	Gender CHAR(1) NOT NULL,
	Birthdate DATE NOT NULL,
	Biography NVARCHAR(MAX)
)

INSERT INTO People VALUES
('Gosho', NULL, 1.83, 85.2, 'm', '1997-02-15', NULL),
('Pesho', NULL, 1.75, 72.4, 'm', '1982-04-24', 'Az sym Pesho.'),
('Merry', NULL, 1.52, 40.52, 'f', '1984-02-02', NULL),
('Penka', NULL, 1.64, 50.48, 'f', '1994-01-01', 'Az ne sym penka!'),
('Kiro', NULL, 1.98, 90.45, 'm', '1998-12-28', NULL)

SELECT * FROM People

CREATE TABLE Users (
	Id INT IDENTITY,
	Username VARCHAR(30) UNIQUE NOT NULL,
	[Password] VARCHAR(26) NOT NULL,
	ProfilePicture VARBINARY(900),
	LastLoginTime SMALLDATETIME,
	IsDeleted BIT
)

ALTER TABLE Users
ADD CONSTRAINT PK_Id
PRIMARY KEY (Id)

INSERT INTO Users VALUES
('Gosh', '123123', NULL, '2018-05-23 12:53', 0),
('Pesh', '123abc', NULL, '2018-05-22 12:54', 1),
('Merr', '987987', NULL, '2018-05-22 17:01', 0),
('Penk', '987abc', NULL, '2017-02-22 22:22', 1),
('Kir', 'abcabc', NULL, '2017-05-23 12:52', 0)

SELECT * FROM Users

ALTER TABLE Users
DROP CONSTRAINT PK_Id

ALTER TABLE Users
ADD CONSTRAINT PK_Id_Username
PRIMARY KEY (Id, Username)

ALTER TABLE Users
ADD CONSTRAINT CH_Password
CHECK (LEN([Password]) > 5)

ALTER TABLE Users
ADD DEFAULT GETDATE()
FOR LastLoginTime

INSERT INTO Users VALUES
('Spiri', 'qwerty', NULL, NULL, 0)

SELECT * FROM Users

ALTER TABLE Users
ADD CONSTRAINT uq_Username
UNIQUE (Username)

DROP DATABASE Movies

USE Movies

CREATE TABLE Directors (
	Id INT PRIMARY KEY IDENTITY,
	DirectorName NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO Directors VALUES
('Gosho', NULL),
('Пешо', 'Аз съм пешо.'),
('Ivan', NULL),
('Gesho', 'Аз съм гешо.'),
('Posho', NULL)

CREATE TABLE Genres (
	Id INT PRIMARY KEY IDENTITY,
	GenreName NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO Genres VALUES
('Gosho', NULL),
('Пешо', 'Аз съм пешо.'),
('Ivan', NULL),
('Gesho', 'Аз съм гешо.'),
('Posho', NULL)

CREATE TABLE Categories (
	Id INT PRIMARY KEY IDENTITY,
	CategoryName NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO Categories VALUES
('Gosho', NULL),
('Пешо', 'Аз съм пешо.'),
('Ivan', NULL),
('Gesho', 'Аз съм гешо.'),
('Posho', NULL)

CREATE TABLE Movies (
	Id INT PRIMARY KEY IDENTITY,
	Title NVARCHAR(50) NOT NULL,
	DirectorId INT NOT NULL,
	CopyrightYear DATE NOT NULL,
	[Length] TIME NOT NULL,
	GenreId INT NOT NULL,
	CategoryId INT NOT NULL,
	Rating DECIMAL(15, 2) NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO Movies VALUES
('Movie 1', 1, '2018', '01:11:11', 1, 1, 1.68, NULL),
('Movie 2', 2, '2017', '02:22:22', 2, 2, 2.68, NULL),
('Movie 3', 3, '2016', '03:33:33', 3, 3, 3.68, NULL),
('Movie 4', 4, '2015', '04:44:44', 4, 4, 4.68, NULL),
('Movie 5', 5, '2014', '05:55:55', 5, 5, 5.68, NULL)

USE CarRental

CREATE TABLE Categories (
	Id INT PRIMARY KEY IDENTITY,
	CategoryName NVARCHAR(50) NOT NULL,
	DailyRate DECIMAL(15, 2) NOT NULL,
	WeeklyRate DECIMAL(15, 2) NOT NULL,
	MonthlyRate DECIMAL(15, 2) NOT NULL,
	WeekendRate DECIMAL(15, 2) NOT NULL
)

INSERT INTO Categories VALUES
('Category 1', 1.11, 1.12, 1.13, 1.14),
('Category 2', 2.22, 2.23, 2.24, 2.25),
('Category 3', 3.33, 3.34, 3.35, 3.36)

CREATE TABLE Cars (
	Id INT PRIMARY KEY IDENTITY,
	PlateNumber NVARCHAR(50) UNIQUE NOT NULL,
	Manufacturer NVARCHAR(50) NOT NULL,
	Model NVARCHAR(50) NOT NULL,
	CarYear DATE NOT NULL,
	CategoryId INT NOT NULL,
	Doors INT NOT NULL,
	Picture VARBINARY(MAX),
	Condition NVARCHAR(MAX) NOT NULL,
	Available BIT NOT NULL
)

INSERT INTO Cars VALUES
('YV2112ZX', 'Audi', 'S4', '2012', 3, 5, NULL, 'New', 1),
('YV2332ZX', 'Audi', 'S6', '2013', 2, 5, NULL, 'New', 1),
('YV3443ZX', 'Audi', 'S8', '2014', 1, 5, NULL, 'New', 0)

CREATE TABLE Employees (
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	Title NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO Employees VALUES
('Gosho', 'Peshov', 'Title 1', NULL),
('Пешо', 'Гошов', 'Заглавие 2', 'Аз съм пешо.'),
('Ivan', 'Ivanov', 'Title 3', NULL)

CREATE TABLE Customers (
	Id INT PRIMARY KEY IDENTITY,
	DriverLicenceNumber INT NOT NULL,
	FullName NVARCHAR(50) NOT NULL,
	[Address] NVARCHAR(MAX) NOT NULL,
	City NVARCHAR(50) NOT NULL,
	ZIPCode INT NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO Customers VALUES
(854658, 'Gosho Ivanov', 'не ми се мисли адрес...', 'Sofia', 1700, NULL),
(45673, 'Pesho Ivanov', 'няма пък...', 'Sliven', 8800, NULL),
(6546412, 'Иван Пешов Гошов', 'казах не...', 'София', 1000, 'и бележки не ми се мислят...')

CREATE TABLE RentalOrders (
	Id INT PRIMARY KEY IDENTITY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id) NOT NULL,
	CustomerId INT FOREIGN KEY REFERENCES Customers(Id) NOT NULL,
	CarId INT FOREIGN KEY REFERENCES Cars(Id) NOT NULL,
	TankLevel DECIMAL(15, 2) NOT NULL,
	KilometrageStart DECIMAL(15, 3) NOT NULL,
	KilometrageEnd DECIMAL(15, 3) NOT NULL,
	TotalKilometrage DECIMAL(15, 3) NOT NULL,
	StartDate DATE NOT NULL,
	EndDate DATE NOT NULL,
	TotalDays INT NOT NULL,
	RateApplied DECIMAL(15, 2) NOT NULL,
	TaxRate DECIMAL (15, 2) NOT NULL,
	OrderStatus INT NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO RentalOrders VALUES
(1, 1, 1, 11.1, 111.11, 222.22, 111.11, '2001-01-01', '2002-01-01', 365, 1.11, 1.11, 1, NULL),
(2, 2, 2, 22.2, 222.22, 444.44, 222.22, '2002-02-02', '2003-02-02', 365, 2.22, 2.22, 2, NULL),
(3, 3, 3, 33.3, 333.33, 666.66, 333.33, '2003-03-03', '2004-03-03', 365, 3.33, 3.33, 3, NULL)

USE Hotel

CREATE TABLE Employees (
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	Title NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO Employees VALUES
('Gosho', 'Peshov', 'Title 1', NULL),
('Пешо', 'Гошов', 'Заглавие 2', 'Аз съм пешо.'),
('Ivan', 'Ivanov', 'Title 3', NULL)

CREATE TABLE Customers (
	Id INT PRIMARY KEY IDENTITY,
	AccountNumber INT UNIQUE NOT NULL,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	PhoneNumber NVARCHAR(50) NOT NULL,
	EmergencyName NVARCHAR(50) NOT NULL,
	EmergencyNumber NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO Customers VALUES
(111, 'Gosho', 'Peshov', '111-11', 'GoshoEm', '111-12', NULL),
(222, 'Пешо', 'Гошов', '222-22', 'ПешоЕм', '222-23', 'Аз съм пешо.'),
(333, 'Ivan', 'Ivanov', '333-33', 'IvanEm', '333-34', NULL)

CREATE TABLE RoomStatus (
	RoomStatus INT NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO RoomStatus VALUES
(3, NULL),
(2, NULL),
(1, NULL)

CREATE TABLE RoomTypes (
	RoomType NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO RoomTypes VALUES
('Small', NULL),
('Medium', NULL),
('Large', NULL)

CREATE TABLE BedTypes (
	BedType NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO BedTypes VALUES
('Small', NULL),
('Medium', NULL),
('Large', NULL)

CREATE TABLE Rooms (
	RoomNumber INT UNIQUE NOT NULL,
	RoomType NVARCHAR(50) NOT NULL,
	BedType NVARCHAR(50) NOT NULL,
	Rate DECIMAL(15, 2) NOT NULL,
	RoomStatus INT NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO Rooms VALUES
(1, 'Small', 'Small', 1.11, 1, NULL),
(2, 'Medium', 'Medium', 2.22, 2, NULL),
(3, 'Large', 'Large', 3.33, 3, NULL)

CREATE TABLE Payments (
	Id INT PRIMARY KEY IDENTITY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id) NOT NULL,
	PaymentDate DATE NOT NULL,
	AccountNumber INT FOREIGN KEY REFERENCES Customers(AccountNumber) NOT NULL,
	FirstDateOccupied DATE NOT NULL,
	LastDateOccupied DATE NOT NULL,
	TotalDays INT NOT NULL,
	AmountCharged DECIMAL(15, 2) NOT NULL,
	TaxRate DECIMAL(15, 2) NOT NULL,
	TaxAmount DECIMAL(15, 2) NOT NULL,
	PaymentTotal DECIMAL(15, 2) NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO Payments VALUES
(1, '2000-01-01', 111, '2000-01-01', '2000-01-02', 1, 252.31, 3.93, 2.52, 0.32, NULL),
(1, '2000-01-01', 222, '2000-01-01', '2000-01-02', 2, 252.31, 3.93, 2.52, 0.32, NULL),
(1, '2000-01-01', 333, '2000-01-01', '2000-01-02', 3, 252.31, 3.93, 2.52, 0.32, NULL)

CREATE TABLE Occupancies (
	Id INT PRIMARY KEY IDENTITY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id) NOT NULL,
	DateOccupied DATE NOT NULL,
	AccountNumber INT FOREIGN KEY REFERENCES Customers(AccountNumber) NOT NULL,
	RoomNumber INT FOREIGN KEY REFERENCES Rooms(RoomNumber) NOT NULL,
	RateApplied DECIMAL(15, 2) NOT NULL,
	PhoneCharge INT NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO Occupancies VALUES
(1, '2000-01-01', 111, 1, 3.93, 123, NULL),
(1, '2000-01-01', 111, 1, 3.93, 123, NULL),
(1, '2000-01-01', 111, 1, 3.93, 123, NULL)


--SOFTUNI DATABASE

USE SoftUni

CREATE TABLE Towns (
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(50) NOT NULL
)

CREATE TABLE Addresses (
	Id INT PRIMARY KEY IDENTITY,
	AddressText NVARCHAR(MAX) NOT NULL,
	TownId INT FOREIGN KEY REFERENCES Towns(Id) NOT NULL
)

CREATE TABLE Departments (
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(50) NOT NULL
)

CREATE TABLE Employees (
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(50) NOT NULL,
	MiddleName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	JobTitle VARCHAR(50) NOT NULL,
	DepartmentId INT FOREIGN KEY REFERENCES Departments(Id) NOT NULL,
	HireDate DATE NOT NULL,
	Salary DECIMAL(15, 2) NOT NULL,
	AddressId INT FOREIGN KEY REFERENCES Addresses(Id)
)

INSERT INTO Towns VALUES
('Sofia'),
('Plovdiv'),
('Varna'),
('Burgas')

SELECT * FROM Towns

INSERT INTO Departments VALUES
('Engineering'),
('Sales'),
('Marketing'),
('Software Development'),
('Quality Assurance')

SELECT * FROM Departments

INSERT INTO Employees VALUES
('Ivan', 'Ivanov', 'Ivanov', '.NET Developer', 4, '2013-02-01', 3500.00, NULL),
('Petar', 'Petrov', 'Petrov', 'Senior Engineer', 1, '2004-03-02', 4000.00, NULL),
('Maria', 'Petrova', 'Ivanova', 'Intern', 5, '2016-08-28', 525.25, NULL),
('Georgi', 'Teziev', 'Ivanov', 'CEO', 2, '2007-12-09', 3000.00, NULL),
('Peter', 'Pan', 'Pan', 'Intern', 3, '2016-08-28', 599.88, NULL)

SELECT * FROM Employees

SELECT * FROM Towns ORDER BY [Name] ASC

SELECT * FROM Departments ORDER BY [Name] ASC

SELECT * FROM Employees ORDER BY [Salary] DESC

SELECT [Name] FROM Towns ORDER BY [Name] ASC

SELECT [Name] FROM Departments ORDER BY [Name] ASC

SELECT FirstName, LastName, JobTitle, Salary  FROM Employees ORDER BY [Salary] DESC

UPDATE Employees SET Salary += Salary * 0.1

SELECT Salary FROM Employees

--Decrease Tax Rate

SELECT * FROM Payments

UPDATE Payments
   SET TaxRate *= 0.97

SELECT TaxRate FROM Payments

TRUNCATE TABLE Occupancies

SELECT * FROM Occupancies
GO

SELECT * FROM Addresses, Departments, Employees, Towns
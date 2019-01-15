--01. 
CREATE DATABASE MinionsDB
--02.  
CREATE TABLE Countries (Id INT PRIMARY KEY IDENTITY,Name VARCHAR(50))

CREATE TABLE Towns(Id INT PRIMARY KEY IDENTITY,Name VARCHAR(50), CountryCode INT FOREIGN KEY REFERENCES Countries(Id))

CREATE TABLE Minions(Id INT PRIMARY KEY IDENTITY,Name VARCHAR(30), Age INT, TownId INT FOREIGN KEY REFERENCES Towns(Id))

CREATE TABLE EvilnessFactors(Id INT PRIMARY KEY IDENTITY, Name VARCHAR(50))

CREATE TABLE Villains (Id INT PRIMARY KEY IDENTITY, Name VARCHAR(50), EvilnessFactorId INT FOREIGN KEY REFERENCES EvilnessFactors(Id))

CREATE TABLE MinionsVillains (MinionId INT FOREIGN KEY REFERENCES Minions(Id),VillainId INT FOREIGN KEY REFERENCES Villains(Id),CONSTRAINT PK_MinionsVillains PRIMARY KEY (MinionId, VillainId))
--03
INSERT INTO Countries ([Name]) VALUES ('Bulgaria'),('England'),('Cyprus'),('Germany'),('Norway')

INSERT INTO Towns ([Name], CountryCode) VALUES ('Plovdiv', 1),('Varna', 1),('Burgas', 1),('Sofia', 1),('London', 2),('Southampton', 2),('Bath', 2),('Liverpool', 2),('Berlin', 3),('Frankfurt', 3),('Oslo', 4)

INSERT INTO Minions (Name, Age, TownId) VALUES('Bob', 42, 3),('Kevin', 1, 1),('Bob ', 32, 6),('Simon', 45, 3),('Cathleen', 11, 2),('Carry ', 50, 10),('Becky', 125, 5),('Mars', 21, 1),('Misho', 5, 10),('Zoe', 125, 5),('Json', 21, 1)

INSERT INTO EvilnessFactors (Name) VALUES ('Super good'),('Good'),('Bad'), ('Evil'),('Super evil')

INSERT INTO Villains (Name, EvilnessFactorId) VALUES ('Gru',2),('Victor',1),('Jilly',3),('Miro',4),('Rosen',5),('Dimityr',1),('Dobromir',2)

INSERT INTO MinionsVillains (MinionId, VillainId) VALUES (4,2),(1,1),(5,7),(3,5),(2,6),(11,5),(8,4),(9,7),(7,1),(1,3),(7,3),(5,3),(4,3),(1,2),(2,1),(2,7)

----------

SELECT v.[Name], COUNT(mv.MinionId) AS [MinionsCount] FROM MinionsVillains AS mv JOIN Villains AS v ON v.Id = mv.VillainId GROUP BY v.[Name] HAVING COUNT(mv.MinionId) >= 3 ORDER BY [MinionsCount] DESC

SELECT v.[Name], m.[Name], m.Age FROM Villains AS v LEFT JOIN MinionsVillains AS mv ON mv.VillainId = v.Id LEFT JOIN Minions AS m ON m.Id = mv.MinionId ORDER BY m.[Name]

select t.[Name] from Towns as t join Countries as c on c.Id = t.CountryCode where c.[Name] = 'Bulgaria'

select v.[Name], count(mv.MinionId) from Villains as v join MinionsVillains as mv on mv.VillainId = v.Id where v.Id = 1 group by v.[Name]

ALTER TABLE MinionsVillains ADD CONSTRAINT FK_MinionsVillains_Villains FOREIGN KEY (VillainId) REFERENCES Villains(Id) ON DELETE CASCADE

update Minions set Age += 1 where id in (2, 1, 4)

update Minions set Name = upper(SUBSTRING(Name, 1, 1)) + lower(substring(Name, 2, len(Name) - 1)) where id in (2, 1, 4)

select Name, Age from Minions
go

create proc usp_GetOlder (@minionId int)
as
begin
	update Minions
	   set Age += 1
	 where Id = @minionId
end

exec dbo.usp_GetOlder 2

select Name, Age from Minions where id = 2

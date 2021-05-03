CREATE DATABASE StudentDB

GO

USE StudentDB

GO

CREATE TABLE Students
(
ID INT PRIMARY KEY IDENTITY, 
FirstName NVARCHAR(50) NOT NULL, 
LastName NVARCHAR (30) NOT NULL, 
Gender NVARCHAR (15) NOT NULL, 
Address NVARCHAR (200) NOT NULL
)
GO

INSERT INTO Students VALUES ('Jerome', 'Smith', 'Male', 'St.Mankato Mississippi') 
INSERT INTO Students VALUES ('Peter', 'Cruise', 'Male', 'Frederick Nebraska 20620')
INSERT INTO Students VALUES ('Sam', 'Allen', 'Female', 'Azusa New York 39531') 
INSERT INTO Students VALUES ('Mary', 'Williams', 'Female', 'San Antonio MI 47096')
INSERT INTO Students VALUES ('Leo', 'Son', 'Male', 'Tottenham Court Road London England')

GO
select * from Students;

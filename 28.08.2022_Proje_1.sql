CREATE DATABASE PROJE_1
GO
USE PROJE_1
GO
CREATE TABLE Users
(
	ID INT IDENTITY(1,1),
	Name NVARCHAR(50) NOT NULL,
	Surname NVARCHAR(50) NOT NULL,
	CONSTRAINT pk_user PRIMARY KEY (ID)
)

INSERT INTO Users(Name,Surname) VALUES ('Ufuk','Gömeçoðlu')
INSERT INTO Users(Name,Surname) VALUES ('Alp','Sarýkýþla')
INSERT INTO Users(Name,Surname) VALUES ('Doðuþ','Öztürk')
INSERT INTO Users(Name,Surname) VALUES ('Altuð','Alkan')
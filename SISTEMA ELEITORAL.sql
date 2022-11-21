USE MASTER 

DROP DATABASE URNA

CREATE DATABASE URNA

USE URNA

CREATE DATABASE URNA

CREATE TABLE Candidato
(Id INT PRIMARY KEY IDENTITY (1,1),
Numero INT,
Nome VARCHAR(150)
)

INSERT INTO Candidato(Numero, Nome) VALUES (6,'JOSE') 
 
 CREATE TABLE Eleicao
 (
 Id INT PRIMARY KEY IDENTITY (1,1),
 Ano INT,
 Turno INT
 )

 CREATE TABLE Eleitor
 (
 Id INT PRIMARY KEY IDENTITY (1,1),
 Nome VARCHAR (150),
 Titulo VARCHAR (15),
 Votou BIT
 )

 select * from Eleitor
 select * from Candidato
 select * from Eleicao

 SELECT * Id, Nome, Titulo, Votou
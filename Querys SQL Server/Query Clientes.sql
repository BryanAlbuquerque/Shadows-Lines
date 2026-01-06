USE ShadowLines
GO

CREATE TABLE Clientes(
ClienteID INT PRIMARY KEY IDENTITY (30,1),
Nome VARCHAR(50) NOT NULL,
CPF BIGINT NOT NULL UNIQUE,
Telefone BIGINT NOT NULL,
Email NVARCHAR(50),
DataNascimento DATE, 
Endereco NVARCHAR(200),
DataCadastro DATETIME DEFAULT GETDATE()
);

INSERT INTO Clientes
(Nome, CPF, Telefone, Email, DataNascimento, Endereco)
VALUES 
('Bryan Albuquerque', '5234158689', '11974217641', 'bryanalburquerque2@gmail.com', '07-04-2005', 'Rua Palmira Crepaldi 50')


SELECT * FROM Clientes

DROP TABLE Clientes



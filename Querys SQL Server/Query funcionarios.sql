CREATE DATABASE ShadowLines


CREATE TABLE Funcionarios(
FuncionarioID INT PRIMARY KEY IDENTITY(150,1),
Nome VARCHAR(50) NOT NULL,
CPF BIGINT NOT NULL UNIQUE,
DataNascimento DATE NOT NULL,
Email NVARCHAR(50) NOT NULL,
Telefone BIGINT NOT NULL,
Endereco NVARCHAR (200),
Cargo VARCHAR(100),
NivelAcesso INT  DEFAULT 0 NOT NULL
)

DROP TABLE Funcionarios

INSERT INTO Funcionarios
(Nome, CPF, DataNascimento, Email, Telefone, Endereco, Cargo, NivelAcesso)
VALUES
('Jordan Silva', '527563723', '07/04/2001', 'jordanSilva2@gmail.com', '1197459841', 'Rua Avenida Bressiani 55', 'tatuador', '1');


SELECT * FROM Funcionarios

UPDATE Funcionarios
SET Cargo = 'Tatuador'
WHERE FuncionarioID = '172'



CREATE TABLE Funcionarios(
FuncionarioID INT PRIMARY KEY IDENTITY(172,1),
Nome VARCHAR(50) NOT NULL,
CPF BIGINT NOT NULL UNIQUE,
Data_Nascimento DATE NOT NULL,
Email NVARCHAR(50) NOT NULL,
Telefone BIGINT NOT NULL,
Endereco NVARCHAR (200),
Cargo VARCHAR(100),
Nivel_Acesso INT NOT NULL
)


INSERT INTO Funcionarios
(Nome, CPF, Data_Nascimento, Email, Telefone, Endereco, Cargo, Nivel_Acesso)
VALUES
('Bryan Souza', '52341546889', '07/04/2005', 'bryanalburquerque2@gmail.com', '11974217641', 'Rua Palmira crepaldi 50', 'Gerente', '2');


SELECT * FROM Funcionarios

UPDATE Funcionarios
SET Cargo = 'Tatuador'
WHERE FuncionarioID = '172'



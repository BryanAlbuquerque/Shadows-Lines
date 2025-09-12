CREATE TABLE Funcionarios(
ID_Funcionario INT PRIMARY KEY IDENTITY(172,1),
Nome VARCHAR(50) NOT NULL,
CPF BIGINT NOT NULL UNIQUE,
Data_Nascimento NVARCHAR(20) NOT NULL,
Email NVARCHAR(50) NOT NULL,
Telefone BIGINT NOT NULL,
Endereco NVARCHAR (100),
Cargo VARCHAR(100),
Nivel_Acesso INT NOT NULL
)


INSERT INTO Funcionarios
(Nome, CPF, Data_Nascimento, Email, Telefone, Endereco, Cargo, Nivel_Acesso)
VALUES
('Bryan Souza', '52341546886', '07/04/2005', 'bryanalburquerque2@gmail.com', '11974217641', 'Rua Palmira crepaldi 50', 'Gerente', '2');

UPDATE Funcionarios
SET Nome = 'Bryan jesus'
WHERE ID_Funcionario = 175;

SELECT * FROM Funcionarios

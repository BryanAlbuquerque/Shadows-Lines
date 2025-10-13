USE ShadowLines
GO

CREATE TABLE Agendamentos(
AgendamentoID INT PRIMARY KEY IDENTITY(1,1),
ClienteID INT NOT NULL,
DataAgendamento DATETIME NOT NULL,
Servico NVARCHAR(100),
FuncionarioID INT,
Valor MONEY,
Situacao VARCHAR(30),
Pagamento VARCHAR(50)
)

ALTER TABLE Agendamentos
ADD CONSTRAINT DF_Agendamentos_Situacao DEFAULT 'Pendente' FOR Situacao;


SELECT * FROM Agendamentos


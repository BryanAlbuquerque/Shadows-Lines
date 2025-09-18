USE ShadowLines
GO

CREATE TABLE Agendamentos(
AgendamentoID INT PRIMARY KEY IDENTITY(1,1),
ClienteID INT NOT NULL,
DataAgendamento DATETIME NOT NULL,
Servico NVARCHAR(100),
FuncionarioID INT,
Status NVARCHAR(20) DEFAULT 'Agendado',
Observacoes NVARCHAR(255),
)

SELECT * FROM Agendamentos
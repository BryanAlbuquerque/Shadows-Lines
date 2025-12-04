USE ShadowLines
GO

CREATE TABLE Agendamentos(
AgendamentoID INT PRIMARY KEY IDENTITY(1,1),
ClienteID INT NOT NULL,
DataAgendamento DATETIME UNIQUE NOT NULL,
Servico NVARCHAR(100),
FuncionarioID INT,
Valor MONEY,
Situacao VARCHAR(30) Default 'Em Aberto',
Pagamento VARCHAR(50) Default 'Pendente'
)

drop table Agendamentos

insert into Agendamentos
(ClienteID, DataAgendamento, Servico, FuncionarioID, Valor)
Values
(30, '12/02/2026 15:00', 'Tatto', 173, 200.00)

SELECT * FROM Agendamentos


DELETE FROM agendamentos
WHERE AgendamentoID = 24




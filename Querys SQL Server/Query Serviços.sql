USE ShadowLines
GO

CREATE TABLE Servicos(
ServicoID INT PRIMARY KEY IDENTITY(1,1),
Nome VARCHAR(50),
Valor DECIMAL(12,2),
DataInclusao DATETIME NOT NULL DEFAULT GETDATE()
);

drop table Servicos

SELECT * FROM Servicos

INSERT INTO Servicos
(Nome, Valor)
VALUES
('Tatto','250.00'),
('Reconstrução','150.00'),
('Cobertura Tatuagem','300.00'),
('Consultoria','50.00'),
('Tatuagem Personalizada','500'),
('Tatuagem Coloria','500'),
('Manutenção','130'),
('Remoção','400');


USE ShadowLines
GO

CREATE TABLE Lista_Espera(
Data_Solicitacao DateTime,
ClienteID INT,
Servico VARCHAR(50),
Situacao VARCHAR(50)
)

SELECT * FROM Lista_Espera
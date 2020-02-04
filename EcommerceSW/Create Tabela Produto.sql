CREATE TABLE [dbo].[Produto]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nome] VARCHAR(50) NOT NULL, 
    [Preco] DECIMAL(18, 2) NOT NULL, 
    [Promocao] VARCHAR(50) NULL
)

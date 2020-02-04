CREATE TABLE [dbo].[Carrinho] (
    [Id]                INT             NOT NULL IDENTITY,
    [NomeProduto]       VARCHAR (50)    NOT NULL,
    [QuantidadeProduto] INT             NOT NULL,
    [ValorTotal]        DECIMAL (18, 2) NOT NULL,
    [PromocaoProduto]   VARCHAR (50)    NULL,
    [PrecoUnitario] DECIMAL(18, 2) NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[Operaio] (
    [IdDipendente]        INT             IDENTITY (1, 1) NOT NULL,
    [Nome]                NVARCHAR (50)   NOT NULL,
    [Cognome]             NVARCHAR (50)   NOT NULL,
    [CF]                  CHAR (16)       NOT NULL,
    [FigliACarico]        INT             NOT NULL,
    [Sposato]             BIT             NOT NULL,
    [LivelloLavorativo]   INT             NOT NULL,
    [DescrizioneMansione] NVARCHAR (255)  NULL,
    [Salario]             DECIMAL (10, 2) NOT NULL,
    [IdCantiere]          INT             NULL,
    PRIMARY KEY CLUSTERED ([IdDipendente] ASC),
    UNIQUE NONCLUSTERED ([CF] ASC)
);


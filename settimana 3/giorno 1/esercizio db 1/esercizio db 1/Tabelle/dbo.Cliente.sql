CREATE TABLE [dbo].[Cliente] (
    [Id]          INT             NOT NULL,
    [Nome]        NVARCHAR (50)   NOT NULL,
    [Cognome]     NVARCHAR (50)   NOT NULL,
    [DataNascita] DATE            NOT NULL,
    [Sesso]       CHAR (1)        NOT NULL,
    [CF]          CHAR (16)       NOT NULL,
    [P_IVA]       CHAR (11)       NOT NULL,
    [Attivo]      BIT             NOT NULL,
    [Saldo]       DECIMAL (10, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([P_IVA] ASC),
    UNIQUE NONCLUSTERED ([CF] ASC),
    CHECK ([Sesso]='F' OR [Sesso]='M')
);


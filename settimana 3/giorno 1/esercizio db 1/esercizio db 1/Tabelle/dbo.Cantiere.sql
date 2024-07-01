CREATE TABLE [dbo].[Cantiere] (
    [IdCantiere]            INT            IDENTITY (1, 1) NOT NULL,
    [DenominazioneCantiere] NVARCHAR (100) NOT NULL,
    [Indirizzo]             NVARCHAR (100) NOT NULL,
    [Citta]                 NVARCHAR (50)  NOT NULL,
    [CAP]                   CHAR (5)       NOT NULL,
    [PersonaRiferimento]    NVARCHAR (100) NOT NULL,
    [DataInizioLavori]      DATE           NOT NULL,
    [DataFineLavori]        DATE           NULL,
    [LavoriTerminatiSI_NO]  BIT            NOT NULL,
    [IdDipendente]          INT            NULL,
    PRIMARY KEY CLUSTERED ([IdCantiere] ASC)
);


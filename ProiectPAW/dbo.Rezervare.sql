CREATE TABLE [dbo].[Rezervare] (
    [Id]          INT        NOT NULL DEFAULT 0,
    [Nume_Client] NCHAR (40) NOT NULL DEFAULT 'Proba',
    [Nr_Persoane] INT        NOT NULL DEFAULT 2,
    [Telefon]     NCHAR (11) NULL,
	[DataSiOra] DATETIME NOT NULL
    PRIMARY KEY CLUSTERED ([Id] ASC) DEFAULT '11/09/2001'
);


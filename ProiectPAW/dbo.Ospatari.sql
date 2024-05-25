CREATE TABLE [dbo].[Osaptari]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Nume] NCHAR(10) NOT NULL, 
    [Prenume] NCHAR(10) NOT NULL, 
    [Data Nastere] DATE NULL, 
    [Data Angajare] DATE NULL, 
    [Telefon] NCHAR(10) NULL, 
    [Salariu] FLOAT NOT NULL
)

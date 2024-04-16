CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [NumePrenume] VARCHAR(50) NULL, 
    [CNP] VARCHAR(20) NULL, 
    [DataNasterii] DATETIME NULL, 
    [AnAbsolvire] DECIMAL NULL, 
    [Specializare] VARCHAR(50) NULL
)

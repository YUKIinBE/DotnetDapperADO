CREATE TABLE [dbo].[Collection]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Image] NTEXT NOT NULL, 
    [Title] NVARCHAR (250) NOT NULL,
    [Author] NVARCHAR(250) NOT NULL, 
    [Price] DECIMAL(10, 2) NOT NULL,
    [PublishedDate] DATE NOT NULL
)

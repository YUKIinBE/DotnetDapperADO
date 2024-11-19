CREATE TABLE [dbo].[Volume]
(
	[ISBN] NVARCHAR(13) NOT NULL PRIMARY KEY, 
    [VolNumber] INT NOT NULL, 
    [CoverImage] NTEXT NOT NULL, 
    [Stock] INT NOT NULL, 
    [EditorId] INT NOT NULL,
    [CollectionId] INT NOT NULL,
    CONSTRAINT FK_Edition FOREIGN KEY ([EditorId]) REFERENCES [Editor] (Id),
    CONSTRAINT FK_CollectionId FOREIGN KEY ([CollectionId]) REFERENCES [Collection] (Id)
)

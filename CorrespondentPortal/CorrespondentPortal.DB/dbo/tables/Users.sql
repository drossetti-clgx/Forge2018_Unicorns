CREATE TABLE [dbo].[Users]
(
	[UserID] INT NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(100) NULL, 
    [LastName] VARCHAR(100) NULL, 
    [Type] INT NOT NULL, 
    [CreatedDt] DATETIME NOT NULL, 
    [LastChangedDt] DATETIME NOT NULL
)

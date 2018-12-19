CREATE TABLE [dbo].[UsersClients]
(
	[UserID] INT NOT NULL PRIMARY KEY, 
    [ClientID] INT NOT NULL, 
	[IsActive] BIT NOT NULL,
    [CreatedDt] DATETIME NOT NULL,
    [LastChangedDt] DATETIME NOT NULL
)

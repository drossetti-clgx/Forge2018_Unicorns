CREATE TABLE [dbo].[UsersClientsFiles]
(
	[UserID] INT NOT NULL PRIMARY KEY, 
    [ClientID] INT NOT NULL, 
    [FileGuid] UNIQUEIDENTIFIER NOT NULL, 
    [Status] INT NOT NULL, 
    [AcceptedDt] DATETIME NULL, 
    [AssignedDt] DATETIME NULL, 
    [BaseScore] INT NULL
)

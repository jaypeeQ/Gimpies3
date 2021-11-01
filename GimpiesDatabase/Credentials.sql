CREATE TABLE [dbo].[Credentials]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Username] NVARCHAR(50) NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL, 
    [AssignedRole] NVARCHAR(50) NOT NULL
)

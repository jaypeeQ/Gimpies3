CREATE TABLE [dbo].[ShoeInventory]
(
	[ShoeId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ShoeMerk] NVARCHAR(50) NOT NULL, 
    [ShoeType] NVARCHAR(50) NOT NULL, 
    [ShoeMaat] CHAR(10) NOT NULL, 
    [ShoeKleur] NCHAR(10) NOT NULL, 
    [ShoeAantal] CHAR(10) NOT NULL, 
    [ShoePrijs] CHAR(10) NOT NULL
)

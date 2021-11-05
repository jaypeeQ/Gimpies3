CREATE TABLE [dbo].[ShoeInventory]
(
	[ShoeId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ShoeMerk] NVARCHAR(50) NOT NULL, 
    [ShoeType] NVARCHAR(50) NOT NULL, 
    [ShoeMaat] INT NOT NULL, 
    [ShoeKleur] NCHAR(10) NOT NULL, 
    [ShoeAantal] INT NOT NULL, 
    [ShoePrijs] DECIMAL(4, 2) NOT NULL
)

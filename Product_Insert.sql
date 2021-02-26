CREATE PROCEDURE Product_Insert
    @ProductID int output,
    @ProductName varchar(50),
    @SupplierID int,
    @CategoryID int,
    @QuantityPerUnit varchar(50),
    @UnitPrice decimal(18,2),
	@UnitsInStock int,
	@UnitsOnOrder int,
	@ReorderLevel int,
	@Discontinued int
AS
BEGIN
    SET NOCOUNT ON;

INSERT INTO [dbo].[Products]
           ([ProductName]
           ,[SupplierID]
           ,[CategoryID]
           ,[QuantityPerUnit]
           ,[UnitPrice]
           ,[UnitsInStock]
           ,[UnitsOnOrder]
           ,[ReorderLevel]
           ,[Discontinued])
     VALUES
           (@ProductName
           ,@SupplierID
           ,@CategoryID
           ,@QuantityPerUnit
           ,@UnitPrice
           ,@UnitsInStock
           ,@UnitsOnOrder
           ,@ReorderLevel
            ,@Discontinued)

    SELECT @ProductID = SCOPE_IDENTITY();
END
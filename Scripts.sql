Create Database ManageProduct
GO

IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [categories] (
    [CategoryID] int NOT NULL IDENTITY,
    [CategoryName] nvarchar(max) NULL,
    [Description] nvarchar(max) NULL,
    [Picture] varbinary(max) NULL,
    CONSTRAINT [PK_categories] PRIMARY KEY ([CategoryID])
);
GO

CREATE TABLE [Products] (
    [ProductID] int NOT NULL IDENTITY,
    [ProductName] nvarchar(max) NULL,
    [SupplierID] int NOT NULL,
    [CategoryID] int NOT NULL,
    [QuantityPerUnit] nvarchar(max) NULL,
    [UnitPrice] decimal(18,2) NOT NULL,
    [UnitsInStock] smallint NOT NULL,
    [UnitsOnOrder] smallint NOT NULL,
    [ReorderLevel] smallint NOT NULL,
    [Discontinued] bit NOT NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY ([ProductID])
);
GO

CREATE TABLE [suppliers] (
    [SupplierID] int NOT NULL IDENTITY,
    [CompanyName] nvarchar(max) NULL,
    [ContactName] nvarchar(max) NULL,
    [ContactTitle] nvarchar(max) NULL,
    [Address] nvarchar(max) NULL,
    [City] nvarchar(max) NULL,
    [Region] nvarchar(max) NULL,
    [PostalCode] nvarchar(max) NULL,
    [Country] nvarchar(max) NULL,
    [Phone] nvarchar(max) NULL,
    [Fax] nvarchar(max) NULL,
    [HomePage] nvarchar(max) NULL,
    CONSTRAINT [PK_suppliers] PRIMARY KEY ([SupplierID])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210225174924_Northwind', N'5.0.3');
GO

COMMIT;
GO


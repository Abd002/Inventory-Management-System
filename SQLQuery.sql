CREATE TABLE [Inventory].[AuditLogs] (
    [AuditLogID] INT            IDENTITY (1, 1) NOT NULL,
    [ActionType] NVARCHAR (50)  NOT NULL,
    [ProductID]  INT            NULL,
    [UserID]     INT            NULL,
    [Timestamp]  DATETIME       NOT NULL,
    [OldValues]  NVARCHAR (255) NULL,
    [NewValues]  NVARCHAR (255) NULL,
    CONSTRAINT [PK_AuditLogs_AuditLogID] PRIMARY KEY CLUSTERED ([AuditLogID] ASC),
    CONSTRAINT [FK_AuditLogs_Products] FOREIGN KEY ([ProductID]) REFERENCES [Inventory].[Products] ([ProductID]) ON DELETE SET NULL,
    CONSTRAINT [FK_AuditLogs_Users] FOREIGN KEY ([UserID]) REFERENCES [Inventory].[Users] ([UserID]) ON DELETE SET NULL
);







CREATE TABLE [Inventory].[Products] (
    [ProductID]       INT             IDENTITY (1, 1) NOT NULL,
    [ProductName]     NVARCHAR (100)  NOT NULL,
    [Description]     NVARCHAR (255)  NULL,
    [QuantityInStock] INT             NOT NULL,
    [Price]           DECIMAL (18, 2) NOT NULL,
    [SupplierName]    NVARCHAR (100)  NOT NULL,
    [Category]        NVARCHAR (50)   NULL,
    CONSTRAINT [PK_Products_ProductID] PRIMARY KEY CLUSTERED ([ProductID] ASC),
    UNIQUE NONCLUSTERED ([ProductName] ASC)
);


GO


CREATE TRIGGER [Inventory].trg_Products_Audit_Update
ON Inventory.Products
FOR UPDATE
AS
DECLARE @ProductID INT, @ProductName NVARCHAR(100), @Description NVARCHAR(255), @QuantityInStock INT, @Price DECIMAL(18,2), @SupplierName NVARCHAR(100);
DECLARE @OldProductName NVARCHAR(100), @OldDescription NVARCHAR(255), @OldQuantityInStock INT, @OldPrice DECIMAL(18,2), @OldSupplierName NVARCHAR(100);
DECLARE @ActionType NVARCHAR(50);
DECLARE @UserID INT; 

-- Get the UserID from the session context
SELECT @UserID = CAST(SESSION_CONTEXT(N'UserID') AS INT);

IF EXISTS (SELECT 1 FROM inserted) AND EXISTS (SELECT 1 FROM deleted)
BEGIN
    SELECT 
        @ProductID = i.ProductID, 
        @ProductName = i.ProductName, 
        @Description = i.Description, 
        @QuantityInStock = i.QuantityInStock, 
        @Price = i.Price, 
        @SupplierName = i.SupplierName,
        @OldProductName = d.ProductName, 
        @OldDescription = d.Description, 
        @OldQuantityInStock = d.QuantityInStock, 
        @OldPrice = d.Price, 
        @OldSupplierName = d.SupplierName
    FROM inserted i
    JOIN deleted d ON i.ProductID = d.ProductID;

    SET @ActionType = 'UPDATE';

    INSERT INTO Inventory.AuditLogs (ActionType, ProductID, UserID, Timestamp, OldValues, NewValues)
    VALUES (@ActionType, @ProductID, @UserID, GETDATE(), 
            CONCAT('Name: ', @OldProductName, ', Description: ', @OldDescription, 
                   ', Qty: ', @OldQuantityInStock, ', Price: ', @OldPrice, ', Supplier: ', @OldSupplierName), 
            CONCAT('Name: ', @ProductName, ', Description: ', @Description, 
                   ', Qty: ', @QuantityInStock, ', Price: ', @Price, ', Supplier: ', @SupplierName));

    PRINT 'Trigger fired - After Update';
END
GO
CREATE TRIGGER [Inventory].trg_Products_Audit_Insert
ON Inventory.Products
FOR INSERT
AS
DECLARE @ProductID INT, @ProductName NVARCHAR(100), @Description NVARCHAR(255), @QuantityInStock INT, @Price DECIMAL(18,2), @SupplierName NVARCHAR(100);
DECLARE @ActionType NVARCHAR(50);
DECLARE @UserID INT; 

-- Get the UserID from the session context
SELECT @UserID = CAST(SESSION_CONTEXT(N'UserID') AS INT);

IF EXISTS (SELECT 1 FROM inserted)
BEGIN
    SELECT 
        @ProductID = i.ProductID, 
        @ProductName = i.ProductName, 
        @Description = i.Description, 
        @QuantityInStock = i.QuantityInStock, 
        @Price = i.Price, 
        @SupplierName = i.SupplierName
    FROM inserted i;

    SET @ActionType = 'INSERT';

    INSERT INTO Inventory.AuditLogs (ActionType, ProductID, UserID, Timestamp, OldValues, NewValues)
    VALUES (@ActionType, @ProductID, @UserID, GETDATE(), NULL, 
            CONCAT('Name: ', @ProductName, ', Description: ', @Description, 
                   ', Qty: ', @QuantityInStock, ', Price: ', @Price, ', Supplier: ', @SupplierName));

    PRINT 'Trigger fired - After Insert';
END
GO


CREATE TRIGGER [Inventory].trg_Products_Audit_Delete
ON Inventory.Products
FOR DELETE
AS
DECLARE  @ProductName NVARCHAR(100), @Description NVARCHAR(255), @QuantityInStock INT, @Price DECIMAL(18,2), @SupplierName NVARCHAR(100);
DECLARE @ActionType NVARCHAR(50);
DECLARE @UserID INT; 

-- Get the UserID from the session context
SELECT @UserID = CAST(SESSION_CONTEXT(N'UserID') AS INT);

IF EXISTS (SELECT 1 FROM deleted)
BEGIN
    SELECT 
        @ProductName = d.ProductName, 
        @Description = d.Description, 
        @QuantityInStock = d.QuantityInStock, 
        @Price = d.Price, 
        @SupplierName = d.SupplierName
    FROM deleted d;

    SET @ActionType = 'DELETE';

    INSERT INTO Inventory.AuditLogs (ActionType, UserID, Timestamp, OldValues, NewValues)
    VALUES (@ActionType, @UserID, GETDATE(), 
            CONCAT('Name: ', @ProductName, ', Description: ', @Description, 
                   ', Qty: ', @QuantityInStock, ', Price: ', @Price, ', Supplier: ', @SupplierName), NULL);

    PRINT 'Trigger fired - After Delete';
END










CREATE TABLE [Inventory].[Users] (
    [UserID]       INT            IDENTITY (1, 1) NOT NULL,
    [Username]     NVARCHAR (50)  NOT NULL,
    [PasswordHash] NVARCHAR (255) NOT NULL,
    [IsAdmin]      BIT            NOT NULL,
    CONSTRAINT [PK_Users_UserID] PRIMARY KEY CLUSTERED ([UserID] ASC),
    UNIQUE NONCLUSTERED ([Username] ASC)
);


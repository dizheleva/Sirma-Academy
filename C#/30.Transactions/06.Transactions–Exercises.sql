CREATE DATABASE TransactionsDemo

USE TransactionsDemo

-- 1.Basic Transaction (INSERT and ROLLBACK)

CREATE TABLE Accounts (
AccountID INT PRIMARY KEY,
AccountName NVARCHAR(50),
Balance DECIMAL(10, 2)
);

BEGIN TRANSACTION;

INSERT INTO Accounts VALUES 
	(1, 'Tester', 5),
	(2, 'Tester2', 500);

IF EXISTS(
	SELECT Balance FROM Accounts
	WHERE Balance < 0
	)
	ROLLBACK;
ELSE
	COMMIT;

-- 2.Transfer Funds Between Accounts

BEGIN TRANSACTION;

UPDATE Accounts SET Balance = Balance + 500 WHERE AccountID = 1;
UPDATE Accounts SET Balance = Balance - 500 WHERE AccountID = 2;

IF EXISTS (
    SELECT *
    FROM Accounts
    WHERE AccountID = 1 AND Balance >= 0
) AND EXISTS (
    SELECT *
    FROM Accounts
    WHERE AccountID = 2 AND Balance >= 0
)
    COMMIT TRANSACTION;
ELSE
    ROLLBACK TRANSACTION;

SELECT * FROM Accounts

-- 3.Transaction with Error Handling

CREATE TABLE Products (
ProductID INT PRIMARY KEY,
ProductName NVARCHAR(50),
Stock INT,
Price DECIMAL(10, 2)
);

INSERT INTO Products VALUES 
	(1, 'Product1', 50, 200),
	(2, 'Product2', 100, 49.90);



BEGIN TRANSACTION;

BEGIN TRY    
    DECLARE @ProductID INT = 1; 
    DECLARE @StockChange INT = 100; 

    UPDATE Products SET Stock = Stock - @StockChange WHERE ProductID = @ProductID;	 
	
	IF (SELECT Stock FROM Products WHERE ProductID = @ProductID) < 0
    BEGIN;
        THROW 50001, 'Stock cannot be negative. Rolling back the transaction.', 1;
    END;
    COMMIT TRANSACTION;
END TRY

BEGIN CATCH
    ROLLBACK TRANSACTION;
    PRINT 'Error: ' + ERROR_MESSAGE();
END CATCH;

--SELECT * FROM Products

-- 4.Savepoint Example

BEGIN TRANSACTION;

UPDATE Products SET Stock += 50 WHERE ProductID = 1;
SAVE TRANSACTION SavePoint1;

BEGIN TRY    
	UPDATE Products SET Stock -= 1000 WHERE ProductID = 3;

	IF EXISTS(SELECT Stock FROM Products WHERE Stock < 0) OR @@ROWCOUNT = 0
    BEGIN;
        THROW 50001, 'Second product update failed.', 1;
    END;
	COMMIT TRANSACTION;
END TRY

BEGIN CATCH
    ROLLBACK TRANSACTION Savepoint1;
    PRINT 'First product updated successfullly. ' + ERROR_MESSAGE();
END CATCH;

-- 5.AFTER Trigger (Audit Logging)

CREATE TABLE Orders (
OrderID INT PRIMARY KEY,
CustomerID INT,
OrderDate DATE
);

CREATE TABLE OrderLog (
LogID INT IDENTITY(1,1) PRIMARY KEY,
OrderID INT,
LogDate DATETIME DEFAULT GETDATE()
);



CREATE TRIGGER trg_after_insert_orders
ON Orders
AFTER INSERT
AS
BEGIN
    INSERT INTO OrderLog (OrderID)
    SELECT OrderID FROM inserted;
END;

DROP TRIGGER trg_after_insert_orders

/*
INSERT INTO Orders VALUES 
	(1, 1, GETDATE()),
	(2, 1, GETDATE());

SELECT * FROM OrderLog
*/

-- 6.INSTEAD OF Trigger (Prevent Deletion)

CREATE TABLE Employees (
EmployeeID INT PRIMARY KEY,
Name NVARCHAR(50),
Position NVARCHAR(50)
);

CREATE TABLE DeletedEmployees (
EmployeeID INT PRIMARY KEY,
Name NVARCHAR(50),
Position NVARCHAR(50),
DeletedDate DATETIME DEFAULT GETDATE()
);


CREATE TRIGGER trg_instead_of_delete_employees
ON Employees
INSTEAD OF DELETE 
AS
BEGIN
    INSERT INTO DeletedEmployees (EmployeeID, Name, Position)
    SELECT d.EmployeeID, d.Name, d.Position FROM deleted AS d;

    PRINT 'Record moved to DeletedEmployees table.';
END;

/*
INSERT INTO Employees VALUES 
	(1, 'Emp1', 'Position1'),
	(2, 'Emp2', 'Position1'),
	(3, 'Emp3', 'Position2');

DELETE FROM Employees WHERE EmployeeID = 1;

SELECT * FROM DeletedEmployees;
SELECT * FROM Employees;
*/

-- 7.Trigger for Data Validation

CREATE TRIGGER trg_prevent_negative_price
ON Products
INSTEAD OF INSERT
AS
BEGIN
    
    IF EXISTS (SELECT * FROM inserted WHERE Price < 0)
    BEGIN
        RAISERROR('Cannot insert products with a negative price.', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END

	INSERT INTO Products (ProductID, ProductName, Stock, Price)
	SELECT ProductID, ProductName, Stock, Price FROM inserted;
END;

/*
INSERT INTO Products VALUES 
	(1, 'Product3', 50, -200);

SELECT * FROM Products
*/

-- 8.Cascade Update with Trigger

CREATE TABLE Departments (
DepartmentID INT PRIMARY KEY,
DepartmentName NVARCHAR(50)
);

--DROP TABLE Employees
CREATE TABLE Employees (
EmployeeID INT PRIMARY KEY,
Name NVARCHAR(50),
DepartmentID INT,
DepartmentName NVARCHAR(50)
);


CREATE TRIGGER trg_after_update_department
ON Departments
AFTER UPDATE
AS
BEGIN    
    IF UPDATE(DepartmentName)
    BEGIN        
        UPDATE Employees
        SET DepartmentName = i.DepartmentName
        FROM Employees e
        INNER JOIN inserted AS i ON e.DepartmentID = i.DepartmentID
        WHERE i.DepartmentName <> (SELECT DepartmentName FROM deleted WHERE DepartmentID = i.DepartmentID);
    END
END;

-- 9.Conditional Trigger

--DROP TABLE Orders
CREATE TABLE Orders (
OrderID INT PRIMARY KEY,
CustomerID INT,
TotalAmount DECIMAL(10, 2)
);

CREATE TABLE HighValueOrders (
OrderID INT PRIMARY KEY,
CustomerID INT,
TotalAmount DECIMAL(10, 2),
RecordedDate DATETIME DEFAULT GETDATE()
);



CREATE TRIGGER trg_after_insert_high_value_orders
ON Orders
AFTER INSERT
AS
BEGIN
    INSERT INTO HighValueOrders (OrderID, CustomerID, TotalAmount)
    SELECT OrderID, CustomerID, TotalAmount FROM inserted
	WHERE TotalAmount > 1000;
END;

/*
INSERT INTO Orders VALUES 
	(1, 1, 200),
	(2, 1, 1200);

SELECT * FROM Orders
SELECT * FROM HighValueOrders
*/
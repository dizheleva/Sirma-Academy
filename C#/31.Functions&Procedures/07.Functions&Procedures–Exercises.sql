-- 01.Database Setup

CREATE DATABASE PracticeDB;
GO
USE PracticeDB;
GO
CREATE TABLE Employees (
	EmployeeId INT PRIMARY KEY IDENTITY(1,1),
	Name NVARCHAR(50),
	DateOfBirth DATE,
	DepartmentId INT,
	Salary DECIMAL(10,2)
);

CREATE TABLE Departments (
	DepartmentId INT PRIMARY KEY IDENTITY(1,1),
	DepartmentName NVARCHAR(50)
);

CREATE TABLE Products (
	ProductId INT PRIMARY KEY IDENTITY(1,1),
	ProductName NVARCHAR(50),
	CategoryId INT,
	Price DECIMAL(10,2),
	Stock INT
);

CREATE TABLE Categories (
	CategoryId INT PRIMARY KEY IDENTITY(1,1),
	CategoryName NVARCHAR(50)
);

--Insert data
INSERT INTO Departments (DepartmentName) VALUES ('HR'),('IT'),('Sales'), ('Marketing');

INSERT INTO Employees (Name, DateOfBirth, DepartmentId, Salary)VALUES
('John Doe', '1990-06-15', 1, 50000),
('Jane Smith', '1985-12-22', 2, 70000),
('Alice Brown', '1992-03-10', 3, 45000),
('Bob Johnson', '1988-09-05', 4, 55000);

INSERT INTO Categories (CategoryName) VALUES ('Electronics'),('Clothing'), ('Home Appliances');

INSERT INTO Products (ProductName, CategoryId, Price, Stock)VALUES
('Smartphone', 1, 699.99, 50),
('Laptop', 1, 1299.99, 30),
('T-Shirt', 2, 19.99, 100),
('Vacuum Cleaner', 3, 149.99, 20);

-- 02.Scalar Functions

CREATE FUNCTION dbo.GetFullYear (@input DATETIME)
RETURNS INT
AS
BEGIN
	RETURN YEAR(@input)
END;

SELECT dbo.GetFullYear(GETDATE()) AS CurrentYear;

--

CREATE FUNCTION dbo.GetAnnualSalary (@inputSalary DECIMAL)
RETURNS INT
AS
BEGIN
	RETURN @inputSalary * 12
END;

SELECT dbo.GetAnnualSalary(5000) AS AnnualSalary;

--

CREATE FUNCTION dbo.IsInStock (@productID INT)
RETURNS NVARCHAR(5)
AS
BEGIN
	DECLARE @result NVARCHAR(5);
	IF (SELECT Stock FROM Products WHERE ProductId = @productID) > 0
		SET @result = 'TRUE';
	ELSE
		SET @result = 'FALSE';
	RETURN @result;
END;

SELECT dbo.IsInStock(1) AS ProductIsInStock; -- Smartphone

--

CREATE FUNCTION dbo.GetDiscountPrice (@price DECIMAL(18, 2), @discount DECIMAL(5, 2))
RETURNS DECIMAL(18, 2)
AS
BEGIN
	
	RETURN @price - @price * @discount / 100;
END;

SELECT dbo.GetDiscountPrice(699.99, 10) AS DiscountPrice;

-- 03.Inline Table-Valued Functions

CREATE FUNCTION GetEmployeesByDepartment (@deptId INT)
RETURNS TABLE
AS
RETURN 
(
	SELECT EmployeeId, Name, DepartmentId, Salary FROM Employees
	WHERE DepartmentId = @deptId
);

SELECT * FROM dbo.GetEmployeesByDepartment(2);

--

CREATE FUNCTION GetProductsByCategory (@categoryId INT)
RETURNS TABLE
AS
RETURN 
(
	SELECT * FROM Products
	WHERE CategoryId = @categoryId
);

SELECT * FROM dbo.GetProductsByCategory(1);

--

CREATE FUNCTION GetAffordableProducts (@maxPrice DECIMAL(18, 2))
RETURNS TABLE
AS
RETURN 
(
	SELECT ProductId, ProductName, Price FROM Products
	WHERE Price < @maxPrice
);

SELECT * FROM dbo.GetAffordableProducts(100);

--

CREATE FUNCTION GetDepartmentsWithEmployees ()
RETURNS TABLE
AS
RETURN 
(
	SELECT d.DepartmentId, d.DepartmentName FROM Departments AS d 
	JOIN Employees AS e ON d.DepartmentId = e.DepartmentId
	GROUP BY d.DepartmentId, d.DepartmentName
	HAVING COUNT(e.EmployeeID) > 0
);

SELECT * FROM dbo.GetDepartmentsWithEmployees();

-- 04.Multi-Statement Table-Valued Functions

CREATE FUNCTION GetTopPaidEmployees (@deptId INT)
RETURNS @TopSalaries TABLE (EmployeeId INT, Name NVARCHAR(50), Salary DECIMAL)
AS
BEGIN
	INSERT INTO @TopSalaries
	SELECT TOP 3 EmployeeId, Name, Salary
	FROM Employees
	WHERE DepartmentId = @deptId
	ORDER BY Salary DESC;
	RETURN;
END;

SELECT * FROM dbo.GetTopPaidEmployees(3);

--

CREATE FUNCTION GetEmployeeDetails ()
RETURNS @EmployeeDetails TABLE (EmployeeName NVARCHAR(50), DepartmentName NVARCHAR(50), Salary DECIMAL)
AS
BEGIN
	INSERT INTO @EmployeeDetails
	SELECT Name, DepartmentName, Salary FROM Employees AS e
	JOIN Departments AS d ON e.DepartmentId = d.DepartmentId;
	RETURN;
END;

SELECT * FROM dbo.GetEmployeeDetails();

--

CREATE FUNCTION GetOutOfStockProducts ()
RETURNS @OutOfStockProducts TABLE (ProductID INT, ProductName NVARCHAR(50))
AS
BEGIN
	INSERT INTO @OutOfStockProducts
	SELECT ProductID, ProductName FROM Products
	WHERE Stock = 0;
	RETURN;
END;

SELECT * FROM dbo.GetOutOfStockProducts();

--

CREATE FUNCTION GetEmployeesByAgeRange (@minAge INT, @maxAge INT)
RETURNS @EmployeesByAgeRange TABLE (EmployeeID INT, EmployeeName NVARCHAR(50), Age INT)
AS
BEGIN
	INSERT INTO @EmployeesByAgeRange
	SELECT EmployeeID, Name, DATEDIFF(YEAR, DateOfBirth, GETDATE()) FROM Employees
	WHERE DATEDIFF(YEAR, DateOfBirth, GETDATE()) BETWEEN @minAge AND @maxAge;
	RETURN;
END;

SELECT * FROM dbo.GetEmployeesByAgeRange(30, 40);

-- 05.Stored Procedures

CREATE PROC dbo.UpdateSalary(@employeeID INT, @percentage DECIMAL(5, 2))
AS
BEGIN
	UPDATE Employees
	SET Salary = Salary + Salary * @percentage / 100
	WHERE EmployeeId = @employeeId;
END;
GO

EXEC UpdateSalary 1, 10;
SELECT * FROM Employees;

--

CREATE PROC dbo.AddNewProduct(@ProductName NVARCHAR(50), @categoryID INT, @price DECIMAL(18, 2), @stock INT)
AS
	INSERT INTO Products VALUES
	(@ProductName, @categoryID, @price, @stock);
	PRINT 'Product added successfully.';
GO

EXEC AddNewProduct 'Smartwatch', 1, 199.99, 100;
SELECT * FROM Products;

--

CREATE PROC dbo.DeleteLowStockProducts
AS
	DELETE FROM Products 
	WHERE Stock < 5;
	PRINT 'Products with low stock deleted.'
GO

EXEC DeleteLowStockProducts;

--

CREATE PROC dbo.TransferEmployee(@employeeID INT, @departmentID INT)
AS
	UPDATE Employees
    SET DepartmentID = @departmentID
    WHERE EmployeeID = @employeeID;
GO

EXEC TransferEmployee 4, 2;
SELECT EmployeeId, Name, DepartmentId FROM Employees WHERE EmployeeId = 4;

-- 06.Optional Advanced Task

CREATE PROC dbo.GetEmployeeAndDepartmentInfo
AS
BEGIN
	SELECT EmployeeID, Name, DateOfBirth, DepartmentID FROM Employees;

	SELECT DepartmentID, DepartmentName FROM Departments;
END
GO

EXEC GetEmployeeAndDepartmentInfo;
USE SirmaAcademyJoinDB

-- 1.List Detailed Order Information

SELECT 
	o.OrderID, 
	c.CustomerName, 
	e.FirstName + ' ' + e.LastName AS EmployeeName, 
	s.ShipperName, 
	SUM(p.Price * od.Quantity) AS [Total Order Price]
FROM Orders AS o
JOIN OrderDetails AS od ON o.OrderID = od.OrderID
JOIN Customers AS c ON c.CustomerID = o.CustomerID
JOIN Employees AS e ON e.EmployeeID = o.EmployeeID
JOIN Products AS p ON p.ProductID = od.ProductID
JOIN Shippers AS s ON s.ShipperID = o.ShipperID
GROUP BY o.OrderID, c.CustomerName, e.FirstName, e.LastName, s.ShipperName;

-- 2.Products Supplied by Each Supplier for Specific Customers

SELECT 
	SupplierName, 
	ProductName, 
	CustomerName,
	SUM(p.Price * od.Quantity) AS [Total Order Price]
FROM Orders AS o 
JOIN OrderDetails AS od ON o.OrderID = od.OrderID 
JOIN Customers AS c ON c.CustomerID = o.CustomerID
JOIN Employees AS e ON e.EmployeeID = o.EmployeeID
JOIN Products AS p ON p.ProductID = od.ProductID
JOIN Suppliers AS s ON s.SupplierID = p.SupplierID
GROUP BY s.SupplierName, p.ProductName, c.CustomerName;

-- 3.Identify Employees Who Handled Orders with Products from Multiple Categories

SELECT FirstName, LastName FROM Employees AS e
JOIN Orders AS o ON o.EmployeeID = e.EmployeeID
JOIN OrderDetails AS od ON o.OrderID = od.OrderID 
JOIN Products AS p ON p.ProductID = od.ProductID
JOIN Categories AS c ON c.CategoryID = p.CategoryID
GROUP BY e.FirstName, e.LastName
HAVING COUNT(DISTINCT c.CategoryID) > 2;

-- 4.Total Revenue by Category and Supplier

SELECT 
	CategoryName, 
	SupplierName,
	SUM(Quantity * Price) AS [Total Revenue]
FROM OrderDetails AS od  
JOIN Products AS p ON p.ProductID = od.ProductID
JOIN Categories AS c ON c.CategoryID = p.CategoryID
JOIN Suppliers AS s ON s.SupplierID = p.SupplierID
GROUP BY CategoryName, SupplierName;

-- 5.Orders with Products from a Specific Supplier

SELECT o.OrderID, OrderDate, CustomerName, ProductName FROM Orders AS o
JOIN OrderDetails AS od ON o.OrderID = od.OrderID 
JOIN Products AS p ON p.ProductID = od.ProductID
JOIN Suppliers AS s ON s.SupplierID = p.SupplierID
JOIN Customers AS c ON c.CustomerID = o.CustomerID
WHERE SupplierName = 'Bigfoot Breweries'
ORDER BY OrderID;

-- 6.Customers Who Ordered the Most Expensive Products

SELECT CustomerName, o.OrderID, ProductName FROM Orders AS o
JOIN OrderDetails AS od ON o.OrderID = od.OrderID 
JOIN Products AS p ON p.ProductID = od.ProductID
JOIN Customers AS c ON c.CustomerID = o.CustomerID
WHERE p.Price > (SELECT AVG(Price) FROM Products);

-- 7.Find Orders with the Most Product Categories

SELECT 
	o.OrderID, 
	COUNT(DISTINCT cat.CategoryID) AS [CategoriesNumber],
	CustomerName,
	FirstName + ' ' + LastName AS EmployeeName
FROM Orders AS o
JOIN OrderDetails AS od ON o.OrderID = od.OrderID 
JOIN Products AS p ON p.ProductID = od.ProductID
JOIN Categories AS cat ON cat.CategoryID = p.CategoryID
JOIN Customers AS c ON c.CustomerID = o.CustomerID
JOIN Employees AS e ON e.EmployeeID = o.EmployeeID
GROUP BY o.OrderID, c.CustomerName, e.FirstName, e.LastName
ORDER BY o.OrderID;

-- 8.Shippers Who Transported Products from a Specific Category

SELECT 
	ShipperName, 
	ProductName, 
	SUM(Quantity) AS TotalQuantity
FROM Orders AS o
JOIN OrderDetails AS od ON o.OrderID = od.OrderID 
JOIN Products AS p ON p.ProductID = od.ProductID
JOIN Categories AS c ON c.CategoryID = p.CategoryID
JOIN Shippers AS s ON s.ShipperID = o.ShipperID
WHERE CategoryName = 'Beverages'
GROUP BY s.ShipperName, p.ProductName;

-- 9.Analyze Customer Spending Across Categories

SELECT 
	CustomerName, 
	CategoryName, 
	SUM(Quantity * Price) AS TotalAmount
FROM Orders AS o
JOIN OrderDetails AS od ON o.OrderID = od.OrderID 
JOIN Products AS p ON p.ProductID = od.ProductID
JOIN Categories AS cat ON cat.CategoryID = p.CategoryID
JOIN Customers AS c ON c.CustomerID = o.CustomerID
GROUP BY c.CustomerName, cat.CategoryName;

-- 10.Suppliers with Revenue Contributions by Employee

SELECT 
	SupplierName, 
	FirstName + ' ' + LastName AS EmployeeName, 
	SUM(Quantity * Price) AS TotalRevenue
FROM Orders AS o
JOIN OrderDetails AS od ON o.OrderID = od.OrderID 
JOIN Products AS p ON p.ProductID = od.ProductID
JOIN Categories AS cat ON cat.CategoryID = p.CategoryID
JOIN Customers AS c ON c.CustomerID = o.CustomerID
JOIN Suppliers AS s ON s.SupplierID = p.SupplierID
JOIN Employees AS e ON e.EmployeeID = o.EmployeeID
GROUP BY s.SupplierName, e.FirstName, e.LastName;

-- 11.Find Products Ordered by the Most Customers

SELECT 
	ProductName,  
	COUNT(DISTINCT CustomerName) AS UniqueCustomerNames
FROM Orders AS o
JOIN OrderDetails AS od ON o.OrderID = od.OrderID 
JOIN Products AS p ON p.ProductID = od.ProductID
JOIN Customers AS c ON c.CustomerID = o.CustomerID
GROUP BY ProductName;

-- 12.Shippers with the Highest Average Order Value

SELECT 
	ShipperName,  
	SUM(Quantity * Price) / COUNT(DISTINCT o.OrderID) AS [Average order value]
FROM Orders AS o
JOIN OrderDetails AS od ON o.OrderID = od.OrderID 
JOIN Products AS p ON p.ProductID = od.ProductID
JOIN Shippers AS s ON s.ShipperID = o.ShipperID
GROUP BY ShipperName;

-- 13.Employees Handling the Highest Quantity of Products

SELECT 
	FirstName + ' ' + LastName AS EmployeeName,   
	SUM(Quantity) AS TotalQuantityHandled
FROM Orders AS o
JOIN OrderDetails AS od ON o.OrderID = od.OrderID 
JOIN Products AS p ON p.ProductID = od.ProductID
JOIN Employees AS e ON e.EmployeeID = o.EmployeeID
GROUP BY FirstName, LastName;

-- 14.Top Suppliers for Each Category

SELECT 
	CategoryName,  
	SupplierName,
	SUM(Quantity * Price) AS TotalRevenue
FROM OrderDetails AS od 
JOIN Products AS p ON p.ProductID = od.ProductID
JOIN Categories AS cat ON cat.CategoryID = p.CategoryID
JOIN Suppliers AS s ON s.SupplierID = p.SupplierID
GROUP BY CategoryName, SupplierName
ORDER BY SUM(Quantity * Price);

-- 15.Orders Involving Customers and Employees from the Same Country

-- Assuming the Employees table includes column Country, 
-- otherwise there is no data for the employees' countries in the database.

SELECT 
	OrderID,  
	CustomerName,
	FirstName + ' ' + LastName AS EmployeeName,
	Country
FROM Orders AS o
JOIN Customers AS c ON c.CustomerID = o.CustomerID
JOIN Employees AS e ON e.EmployeeID = o.EmployeeID
WHERE e.Country = c.Country;

-- 16.Products That Have Been Shipped by All Shippers

SELECT ProductName
FROM Orders AS o
JOIN OrderDetails AS od ON o.OrderID = od.OrderID 
JOIN Products AS p ON p.ProductID = od.ProductID
JOIN Shippers AS s ON s.ShipperID = o.ShipperID
GROUP BY p.ProductName
HAVING COUNT(DISTINCT s.ShipperID) = 
(
	SELECT COUNT(DISTINCT ShipperID) 
	FROM Shippers
);

-- 17.Revenue Generated by Each Customer for Each Shipper

SELECT 
	CustomerName, 
	ShipperName,
	SUM(Quantity * Price) AS TotalRevenue
FROM Orders AS o
JOIN OrderDetails AS od ON o.OrderID = od.OrderID
JOIN Customers AS c ON c.CustomerID = o.CustomerID
JOIN Shippers AS s ON s.ShipperID = o.ShipperID
JOIN Products AS p ON p.ProductID = od.ProductID
GROUP BY CustomerName, ShipperName;

-- 18.Employees with Most Orders by Category

SELECT 
	FirstName + ' ' + LastName AS EmployeeName,
	CategoryName,
	COUNT(DISTINCT o.OrderID) AS OrdersNumber
FROM Orders AS o
JOIN OrderDetails AS od ON o.OrderID = od.OrderID
JOIN Products AS p ON p.ProductID = od.ProductID
JOIN Categories AS cat ON cat.CategoryID = p.CategoryID
JOIN Employees AS e ON e.EmployeeID = o.EmployeeID
GROUP BY FirstName, LastName, CategoryName;

-- 19.Products Ordered Together

SELECT 
    p1.ProductName AS ProductName1,
    p2.ProductName AS ProductName2,
    COUNT(*) AS OrderedTogetherNumber
FROM OrderDetails od1
JOIN OrderDetails od2 ON od1.OrderID = od2.OrderID 
JOIN Products p1 ON od1.ProductID = p1.ProductID
JOIN Products p2 ON od2.ProductID = p2.ProductID
WHERE od1.ProductID < od2.ProductID
GROUP BY p1.ProductName, p2.ProductName;

-- 20.Unordered Products by Suppliers

SELECT 
	SupplierName,
	ProductName
FROM Products AS p
LEFT JOIN OrderDetails AS od ON p.ProductID = od.ProductID
JOIN Suppliers AS s ON s.SupplierID = p.SupplierID
WHERE OrderID IS NULL;
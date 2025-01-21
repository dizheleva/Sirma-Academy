USE SirmaAcademyJoinDB

-- 1.Orders with Customer Names and Countries

SELECT OrderID, OrderDate, CustomerName, Country
FROM Orders AS o
JOIN Customers AS c
ON o.CustomerID = c.CustomerID;

-- 2.Order Details with Product Names and Prices

SELECT OrderID, ProductName, Price, Quantity
FROM OrderDetails AS o
JOIN Products AS p
ON o.ProductID = p.ProductID
ORDER BY p.Price, o.Quantity, p.ProductName;

-- 3.Orders with Shipper Information

SELECT OrderID, OrderDate, ShipperName
FROM Orders AS o
LEFT JOIN Shippers AS sh
ON o.ShipperID = sh.ShipperID;

-- 4.Products by Category with Prices

SELECT ProductName, CategoryName, Price
FROM Products AS p
LEFT JOIN Categories AS c
ON p.CategoryID = c.CategoryID;

-- 5.Supplier and Product List with Quantities Available

SELECT SupplierName, ProductName, Price
FROM Suppliers AS s
RIGHT JOIN Products AS p
ON s.SupplierID = p.SupplierID;

-- 6.Orders with Total Quantity and Total Price

SELECT o.OrderID, c.CustomerName, SUM(od.Quantity) AS TotalQuantity, SUM(od.Quantity * p.Price) AS TotalPrice
FROM Orders AS o
JOIN OrderDetails AS od
ON o.OrderID = od.OrderID
JOIN Customers AS c
ON o.CustomerID = c.CustomerID
JOIN Products As p
ON p.ProductID = od.ProductID
GROUP BY o.OrderID, CustomerName;

-- 7.Products Ordered by Customer Names

SELECT c.CustomerName, p.ProductName, SUM(od.Quantity) AS Quantity
FROM Products As p
JOIN OrderDetails AS od
ON p.ProductID = od.ProductID
JOIN Orders AS o
ON o.OrderID = od.OrderID
JOIN Customers AS c
ON o.CustomerID = c.CustomerID
GROUP BY CustomerName, ProductName;

-- 8.Shipped Orders with Shipper and Employee Names

SELECT OrderID, OrderDate, ShipperName, FirstName, LastName
FROM Orders AS o
JOIN Shippers AS s
ON o.ShipperID = s.ShipperID
JOIN Employees AS e
ON o.EmployeeID = e.EmployeeID;

-- 9.Orders by Category with Total Quantities

SELECT o.OrderID, CategoryName, SUM(Quantity) AS TotalQuantity
FROM Orders AS o
JOIN OrderDetails AS od
ON o.OrderID = od.OrderID
JOIN Products As p
ON p.ProductID = od.ProductID
JOIN Categories AS c
ON p.CategoryID = c.CategoryID
GROUP BY CategoryName, o.OrderID
ORDER BY CategoryName, o.OrderID;

-- 10.Customers Who Ordered Specific Products

-- SELECT * FROM Products

SELECT CustomerName, o.OrderID
FROM Orders AS o
JOIN OrderDetails AS od
ON o.OrderID = od.OrderID
JOIN Products As p
ON p.ProductID = od.ProductID
JOIN Customers AS c
ON o.CustomerID = c.CustomerID
WHERE ProductName = 'Ikura';

-- 11.Suppliers for Products in Each Category

SELECT CategoryName, SupplierName, ProductName
FROM Categories AS c
JOIN Products As p
ON c.CategoryID = p.CategoryID
JOIN Suppliers AS s
ON s.SupplierID = p.SupplierID;

-- 12.Orders Grouped by Employee with Total Sales

SELECT e.FirstName + ' ' + e.LastName AS Employee, 
SUM(p.Price) AS TotalSales
FROM Orders AS o
JOIN OrderDetails As od
ON o.OrderID = od.OrderID
JOIN Employees AS e
ON e.EmployeeID = o.EmployeeID
JOIN Products AS p
ON p.ProductID = od.ProductID
GROUP BY e.FirstName + ' ' + e.LastName;

-- 13.List of Products That Have Never Been Ordered

SELECT ProductName, od.OrderDetailID
FROM Products AS p
LEFT JOIN OrderDetails As od
ON p.ProductID = od.ProductID
WHERE od.OrderDetailID IS NULL;

-- 14.List All Orders Shipped by a Specific Shipper

--SELECT ShipperName FROM Shippers

SELECT OrderID, OrderDate, CustomerName
FROM Orders AS o
JOIN Customers AS c
ON o.CustomerID = c.CustomerID
JOIN Shippers AS s
ON s.ShipperID =  o.ShipperID
WHERE ShipperName = 'Speedy Express';

-- 15.Find Customers Who Have Placed Orders in a Specific Month

SELECT CustomerName, OrderID
FROM Orders AS o
JOIN Customers AS c
ON o.CustomerID = c.CustomerID
WHERE MONTH(o.OrderDate) = 1;

-- 16.Products with Prices Higher Than the Average Price per Category

SELECT p.ProductName, p.Price
FROM Products AS p
--JOIN Categories AS c ON p.CategoryID = c.CategoryID
WHERE p.Price > (
SELECT AVG(p2.Price) FROM Products AS p2
WHERE p2.CategoryID = p.CategoryID
);

-- 17.Orders Containing Products from Multiple Categories

SELECT od.OrderID
FROM OrderDetails AS od
JOIN Products AS p 
ON od.ProductID = p.ProductID
JOIN Categories AS c 
ON p.CategoryID = c.CategoryID
GROUP BY od.OrderID
HAVING COUNT(DISTINCT c.CategoryID) > 1;

-- 18.Customers and Employees Linked by Orders

SELECT c.CustomerName, e.FirstName + ' ' + e.LastName AS EmployeeName, o.OrderID
FROM Orders AS o
JOIN Customers AS c 
ON o.CustomerID = c.CustomerID
JOIN Employees AS e 
ON o.EmployeeID = e.EmployeeID;

-- 19.Suppliers That Provide Products Ordered by a Specific Customer

SELECT s.SupplierName, p.ProductName
FROM Orders AS o
JOIN Customers AS c 
ON o.CustomerID = c.CustomerID
JOIN OrderDetails AS od 
ON o.OrderID = od.OrderID
JOIN Products AS p 
ON od.ProductID = p.ProductID
JOIN Suppliers AS s 
ON p.SupplierID = s.SupplierID
WHERE c.CustomerName = 'Around the Horn';
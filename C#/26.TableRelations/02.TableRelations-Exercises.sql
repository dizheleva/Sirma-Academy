-- 1.Company database with entities: 

	-- Table: Employees, specification:
		-- Columns: ID, name, job title, email

	-- Table: Projects, specification:
		-- Columns: name, description, deadline

	-- Table: Departments, specification:
		-- Columns: ID, name, manager

-- 2.Entitles and Relationships

	-- Entities: Employees, Projects, Departments
	-- Relationships:
		-- "Employees" and "Departments" -> one-to-many relationship
		-- "Employees" and "Projects" -> many-to-many relationship
			-- Mapping table: EmployeesProjects

-- 3.Design Tables

CREATE DATABASE Company

USE Company

-- Table: Departments
CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY IDENTITY(1, 1),
    DepartmentName NVARCHAR(100) NOT NULL,
    Manager NVARCHAR(100) NOT NULL
);

	-- Table: Employees
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1, 1),
    EmployeeName NVARCHAR(50) NOT NULL,
	JobTitle VARCHAR(100),
    Email VARCHAR(100) UNIQUE NOT NULL,    
    DepartmentID INT,
	-- CONSTRAINT FK_Employees_Departments
    -- FOREIGN KEY (DepartmentID) 
	-- REFERENCES Departments(DepartmentID)
);

	-- Table: Projects
CREATE TABLE Projects (
	ProjectID INT PRIMARY KEY IDENTITY(1, 1),
	ProjectName NVARCHAR(50) NOT NULL,
	[Description] NVARCHAR(MAX),
	Deadline DATE NOT NULL
);

-- 4.Implementing One-to-Many Relationship

	-- "Employees" and "Departments" -> one-to-many relationship
ALTER TABLE Employees
    ADD CONSTRAINT FK_Employees_Departments
		FOREIGN KEY(DepartmentID) 
		REFERENCES Departments(DepartmentID);

-- 5.Implementing Many-to-Many Relationships

	-- Creating mapping table: EmployeesProjects
CREATE TABLE EmployeesProjects (
	EmployeeID INT, 
	ProjectID INT,
	PRIMARY KEY (EmployeeID, ProjectID),
	CONSTRAINT FK_EmployeesProjects_Employees
		FOREIGN KEY (EmployeeID)
		REFERENCES Employees(EmployeeID),
	CONSTRAINT FK_EmployeesProjects_Projects
		FOREIGN KEY (ProjectID)
		REFERENCES Projects(ProjectID)
);

ALTER TABLE Employees  WITH CHECK 
	ADD CONSTRAINT FK_Employees_Departments 
		FOREIGN KEY(DepartmentID)
		REFERENCES Departments (DepartmentID)
		ON DELETE CASCADE

-- 7.Cascade Update
ALTER TABLE Employees
	DROP CONSTRAINT FK_Employees_Departments

ALTER TABLE Employees  WITH CHECK 
	ADD CONSTRAINT FK_Employees_Departments 
		FOREIGN KEY(DepartmentID)
		REFERENCES Departments (DepartmentID)
		ON DELETE CASCADE
		ON UPDATE CASCADE

-- 8.JOIN Queries

-- Insert data for queries                                 
INSERT INTO Departments (DepartmentName, Manager) VALUES
('IT', 'Sofia Petrova'),
('Human Resources', 'Maria Atanasova'),
('Sales', 'Plamen Stefanov');

INSERT INTO Projects(ProjectName, Description, Deadline) VALUES
('First project', 'Some js project', CONVERT(DATE, '02/03/2025', 103)),
('Second', 'Some java project', CONVERT(DATE, '12/06/2025', 103)),
('Big project', 'Many components with js and java', CONVERT(DATE, '01/01/2026', 103));


INSERT INTO Employees (EmployeeName, Email, JobTitle, DepartmentID) VALUES
('Alice Brown', 'alice.brown@sirma.com', 'Software Engineer', 1),
('Bob Smith', 'bob.smith@sirma.com', 'HR Specialist', 2),
('Charlie Davis', 'charlie.davis@sirma.com', 'Sales Manager', 3),
('Dana White', 'dana.white@sirma.com', 'DevOps Engineer', 1),
('Eve Black', 'eve.black@sirma.com', 'Intern', 2),
('Frank Green', 'frank.green@sirma.com', 'Product Manager', 1),
('Grace Hall', 'grace.hall@sirma.com', 'Data Analyst', 1),
('Hank Jones', 'hank.jones@sirma.com', 'Marketing Specialist', 3),
('Ivy King', 'ivy.king@sirma.com', 'Software Developer', 1),
('Jack Lewis', 'jack.lewis@sirma.com', 'System Administrator', 1),
('Kara Moore', 'kara.moore@sirma.com', 'HR Manager', 2),
('Liam Nelson', 'liam.nelson@sirma.com', 'Sales Executive', 3),
('Mia Owens', 'mia.owens@sirma.com', 'Network Engineer', 1),
('Noah Parker', 'noah.parker@sirma.com', 'UX Designer', 1),
('Olivia Quinn', 'olivia.quinn@sirma.com', 'Project Manager', 1);

INSERT INTO EmployeesProjects (EmployeeID, ProjectID) 
VALUES
(1, 1),
(1, 2),
(2, 3),
(4, 1),
(3, 2),
(6, 2);

-- Query: all employees working on a specific project
SELECT ep.ProjectID, e.EmployeeName FROM Employees AS e
	JOIN EmployeesProjects AS ep 
	ON e.EmployeeID = ep.EmployeeID
WHERE ep.ProjectID = 1

-- Query: all projects assigned to employees in a specific department
SELECT DISTINCT p.ProjectName, e.DepartmentID FROM Employees AS e
	JOIN EmployeesProjects AS ep 
	ON e.EmployeeID = ep.EmployeeID
	JOIN Projects AS p
	ON ep.ProjectID = p.ProjectID	
	WHERE e.DepartmentID = 1

-- Query: all departments along with the names of their employees
SELECT DepartmentName, e.EmployeeName FROM Departments AS d
	JOIN Employees AS e
	ON d.DepartmentID = e.DepartmentID
	ORDER BY d.DepartmentID

-- 9.Database Normalization

	-- Anomalies: 
		-- insertion anomaly -> new employee cannot be inserted until assigned to a project
		-- deletion anomaly -> info for Bob will be lost when Project Beta is finished
	-- 3NF:
		-- the table needs primary key to avoid anomalies
		-- remove the employeeID column to avoid transitive dependency
		
	-- Create table: EmployeeName_ProjectName
CREATE TABLE EmployeeName_ProjectName (
	ID INT PRIMARY KEY IDENTITY(1, 1),
	EmployeeName NVARCHAR(50) NOT NULL,
	ProjectName NVARCHAR(50) 
);

	-- Insert data in the table:
INSERT INTO EmployeeName_ProjectName (EmployeeName, ProjectName)
SELECT e.EmployeeName, p.ProjectName 
	FROM Employees AS e
	JOIN EmployeesProjects AS ep 
	ON e.EmployeeID = ep.EmployeeID
	JOIN Projects AS p
	ON p.ProjectID = ep.ProjectID

SELECT * FROM EmployeeName_ProjectName

-- 10.Visualizing Relationships:

	-- SSMS -> Object Explorer -> Databases -> Company 
		--> rc on Database Diagrams -> New Database Diagram
	-- result in Company_Diagram

-- 11.SirmaDB Queries:

-- Execute sirmadb.sql
USE SirmaAcademy

-- List all employees
SELECT FirstName + ' ' + LastName AS FullName, JobTitle, Salary FROM Employees

-- Employees by department
SELECT e.FirstName + ' ' + e.LastName AS EmployeeName, d.DepartmentName 
FROM Employees AS e
JOIN Departments AS d
ON e.DepartmentID = d.DepartmentID

-- List Employees in a Specific Location
SELECT e.FirstName + ' ' + e.LastName AS EmployeeName, e.JobTitle 
FROM Employees AS e
JOIN OfficeLocations AS ol
ON ol.LocationID = e.LocationID
WHERE ol.LocationName = 'UK Branch'

-- Highest Paid Employee
SELECT TOP (1) FirstName, LastName, Salary FROM Employees
ORDER BY Salary DESC

--or:
SELECT FirstName, LastName, Salary FROM Employees
WHERE Salary = (SELECT MAX(Salary) FROM Employees)

-- Average Salary by Department
SELECT AVG(Salary) AS AverageSalary 
FROM Employees;

-- Employees Without a Manager
SELECT FirstName, LastName FROM Employees
WHERE JobTitle NOT LIKE '%Manager%';

--Departments and Their Managers
SELECT d.DepartmentName, e.FirstName + ' ' + e.LastName AS FullName
FROM Departments AS d
JOIN Employees AS e
ON d.ManagerID = e.EmployeeID

-- Employees in a Specific Country
SELECT e.FirstName, e.LastName  
FROM Employees AS e
JOIN OfficeLocations AS ol
ON e.LocationID = ol.LocationID
JOIN Countries AS c
ON ol.CountryID = c.CountryID
WHERE c.CountryName = 'Bulgaria'

-- Total Salaries by Country
SELECT c.CountryName, SUM(e.Salary) AS [Total Salaries] 
FROM Employees AS e
JOIN OfficeLocations AS ol
ON e.LocationID = ol.LocationID
JOIN Countries AS c
ON ol.CountryID = c.CountryID
GROUP BY c.CountryName

-- Employees Earning Above Average Salary
SELECT FirstName, LastName, Salary FROM Employees
WHERE Salary > 
(
SELECT AVG(Salary) AS AverageSalary 
FROM Employees
)
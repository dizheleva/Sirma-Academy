--1.Creating a Database and Table------------------------

CREATE DATABASE School

USE School

CREATE TABLE Students
(
StudentID INT PRIMARY KEY NOT NULL,
FirstName VARCHAR(50) NOT NULL,
LastName VARCHAR(50) NOT NULL,
Age INT,
Grade VARCHAR(10)
)

--2.Inserting Data------------------------------------------------

INSERT INTO Students(StudentID, FirstName, LastName, Age, Grade)
VALUES
		(1, 'John', 'Doe', 15, '10th'),
		(2, 'Alice', 'Cooper', 18, '12th'),
		(3, 'Peter', 'Lenkov', 13, '10th'),
		(4, 'Said', 'Ali', 16, '10th'),
		(5, 'Harry', 'Potter', 14, '10th')

--3.Querying Data-------------------------------------------------

SELECT * FROM Students
SELECT FirstName, Grade FROM Students

--4.Updating Data-------------------------------------------------

UPDATE Students
SET Grade = '11th'
WHERE StudentID = 1

--5.Deleting Data-------------------------------------------------

DELETE FROM Students
WHERE StudentID = 1

--6.Filtering Rows------------------------------------------------

SELECT * FROM Students
WHERE Grade = '10th' AND Age BETWEEN 14 AND 16

--7.Sorting Results-----------------------------------------------

SELECT * FROM Students
ORDER BY LastName ASC

--8.Using Aliases-------------------------------------------------

SELECT CONCAT(FirstName, ' ', LastName) 
AS FullName, Grade FROM Students

--9.Advanced Insertion--------------------------------------------

CREATE TABLE Graduates
(
StudentID INT PRIMARY KEY NOT NULL,
FirstName VARCHAR(50) NOT NULL,
LastName VARCHAR(50) NOT NULL,
Age INT,
Grade VARCHAR(10)
)

INSERT INTO Graduates 
SELECT * FROM Students
WHERE Grade = '12th'

--10.View Creation------------------------------------------------

CREATE VIEW v_StudentsByGrade AS
SELECT CONCAT(FirstName, ' ', LastName) AS FullName, Grade
FROM Students

--11.Exploration of SQL Functions (Optional)----------------------

SELECT COUNT(*)
FROM Students

SELECT AVG(Age)
FROM Students
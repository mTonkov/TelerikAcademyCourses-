/*
01. Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company.
 Use a nested SELECT statement.
*/
SELECT FirstName + ' ' + LastName [Name], Salary
FROM [TelerikAcademy].[dbo].Employees
WHERE Salary = 
	(SELECT MIN(Salary) 
	 FROM [TelerikAcademy].[dbo].Employees)

/*
02. Write a SQL query to find the names and salaries of the employees 
that have a salary that is up to 10% higher than the minimal salary for the company.
*/
SELECT e.FirstName + ' ' + e.LastName [Name], e.Salary
FROM [TelerikAcademy].[dbo].Employees e
WHERE Salary <= 1.10 *(SELECT MIN(Salary) 
					   FROM [TelerikAcademy].[dbo].Employees) 

/*
03. Write a SQL query to find the full name, salary and department of the employees 
that take the minimal salary in their department. 
Use a nested SELECT statement.
*/
SELECT e.FirstName + ' ' + e.LastName [Name], e.Salary, d.Name
FROM [TelerikAcademy].[dbo].Employees e
	INNER JOIN [TelerikAcademy].[dbo].Departments d
	ON(e.DepartmentID = d.DepartmentID)
WHERE e.Salary = 
	(SELECT MIN(Salary) 
	 FROM [TelerikAcademy].[dbo].Employees em	
		WHERE em.DepartmentID = d.DepartmentID)

/*
04. Write a SQL query to find the average salary in the department #1
*/
SELECT AVG(Salary) AvgSalary
FROM [TelerikAcademy].[dbo].Employees
WHERE DepartmentID = 1

/*
05. Write a SQL query to find the average salary  in the "Sales" department.
*/
SELECT AVG(Salary) AvgSalary
FROM [TelerikAcademy].[dbo].Employees e
	INNER JOIN [TelerikAcademy].[dbo].Departments d
	ON(e.DepartmentID = d.DepartmentID)
WHERE d.Name = 'Sales'

/*
06. Write a SQL query to find the number of employees in the "Sales" department.
*/
SELECT COUNT(*) SalesEmployees
FROM [TelerikAcademy].[dbo].Employees e
	INNER JOIN [TelerikAcademy].[dbo].Departments d
	ON(e.DepartmentID = d.DepartmentID)
WHERE d.Name = 'Sales'

/*
07. Write a SQL query to find the number of all employees that have manager.
*/
SELECT COUNT(ManagerID) EmployeesWithManager
FROM [TelerikAcademy].[dbo].Employees e

/*
08. Write a SQL query to find the number of all employees that have no manager.
*/
SELECT COUNT(*) EmployeesWithManager
FROM [TelerikAcademy].[dbo].Employees e
WHERE e.ManagerID IS NULL

/*
09. Write a SQL query to find all departments and the average salary for each of them.
*/
SELECT d.Name, AVG(Salary) AS [Average Salary]
FROM [TelerikAcademy].[dbo].Employees e
  JOIN [TelerikAcademy].[dbo].Departments d
    ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name

/* A bit longer version without GROUP BY:

SELECT DISTINCT d.Name [Department],
		(SELECT AVG(Salary) FROM [TelerikAcademy].[dbo].Employees 
		 WHERE DepartmentID = d.DepartmentID) AS [Average Salary] 
FROM [TelerikAcademy].[dbo].Employees e 
  JOIN [TelerikAcademy].[dbo].Departments d
    ON e.DepartmentID = d.DepartmentID */


/*
10. Write a SQL query to find the count of all employees in each department and for each town.
*/
SELECT d.Name [Department], t.Name [Town], COUNT(e.EmployeeID) [Employees Count]
FROM [TelerikAcademy].[dbo].Employees e 
  JOIN [TelerikAcademy].[dbo].Departments d
    ON e.DepartmentID = d.DepartmentID
		JOIN [TelerikAcademy].[dbo].Addresses a
		ON e.AddressID = a.AddressID
			JOIN [TelerikAcademy].[dbo].Towns t
			ON a.TownID = t.TownID
GROUP BY d.Name, t.Name

/*
11. Write a SQL query to find all managers that have exactly 5 employees. 
Display their first name and last name.
*/
SELECT m.FirstName + ' ' + m.LastName [MngrName]
FROM [TelerikAcademy].[dbo].Employees e 		  
  JOIN [TelerikAcademy].[dbo].Employees m		  
    ON e.ManagerID = m.EmployeeID				  
GROUP BY m.FirstName + ' ' + m.LastName		  
HAVING COUNT(e.ManagerID) = 5

/*
12. Write a SQL query to find all employees along with their managers. 
For employees that do not have manager display the value "(no manager)".
*/
SELECT e.FirstName + ' ' + e.LastName [Employee], ISNULL(m.FirstName + ' ' + m.LastName, '(no manager)') [Manager]
FROM [TelerikAcademy].[dbo].Employees e 		  
  LEFT OUTER JOIN [TelerikAcademy].[dbo].Employees m		  
    ON e.ManagerID = m.EmployeeID				  

/*
13. Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. 
Use the built-in LEN(str) function.
*/
SELECT FirstName, LastName
FROM [TelerikAcademy].[dbo].Employees
WHERE LEN(LastName)=5

/*
14. Write a SQL query to display the current date and time in the following format 
"day.month.year hour:minutes:seconds:milliseconds". 
Search in Google to find how to format dates in SQL Server.
*/
SELECT CONVERT(VARCHAR(30), GETDATE(), 113)

/*
15. Write a SQL statement to create a table Users. 
Users should have username, password, full name and last login time. 
Choose appropriate data types for the table fields. 
Define a primary key column with a primary key constraint. 
Define the primary key column as identity to facilitate inserting records. 
Define unique constraint to avoid repeating usernames. 
Define a check constraint to ensure the password is at least 5 characters long.
*/
USE TelerikAcademy
GO 
CREATE TABLE Users(
UserID int IDENTITY NOT NULL,
Username nvarchar(50) NOT NULL,
UserPassword nvarchar(50) NOT NULL CHECK (LEN(UserPassword)>=5),
FullName nvarchar(50),
LastLogin datetime 
CONSTRAINT PK_Users PRIMARY KEY(UserID),
CONSTRAINT UK_Username UNIQUE(Username)
);
GO
/*
16. Write a SQL statement to create a view that displays the users from the Users table 
that have been in the system today. 
Test if the view works correctly.
*/
USE TelerikAcademy
GO 
CREATE VIEW [Users From Today] AS
SELECT Username, FullName, LastLogin
FROM Users 
WHERE LastLogin = GETDATE();
GO

/*
17. Write a SQL statement to create a table Groups. 
Groups should have unique name (use unique constraint). 
Define primary key and identity column.
*/
USE TelerikAcademy
GO 
CREATE TABLE Groups(
GroupID int IDENTITY,
Name nvarchar(20) NOT NULL,
CONSTRAINT PK_Groups PRIMARY KEY(GroupID),
CONSTRAINT UK_Groups UNIQUE(Name)
);
GO

/*
18. Write a SQL statement to add a column GroupID to the table Users. 
Fill some data in this new column and as well in the Groups table. 
Write a SQL statement to add a foreign key constraint between tables Users and Groups tables.
*/
USE TelerikAcademy
GO 

ALTER TABLE Users
ADD GroupID int
GO

INSERT INTO Groups (Name)
VALUES 
('Group A'),
('Group B'),
('Group C');
GO

INSERT INTO Users (Username, UserPassword, GroupID)
VALUES 
('aaa', 'aaaaa', 1),
('bbb', 'bbbbb', 2),
('ccc', 'ccccc', 3);
GO

ALTER TABLE Users
ADD CONSTRAINT FK_Users_Groups
	FOREIGN KEY(GroupID)
	REFERENCES Groups(GroupID)
GO

/*
19. Write SQL statements to insert several records in the Users and Groups tables.
*/
/*Check the previous task 18.*/


/*
20. Write SQL statements to update some of the records in the Users and Groups tables.
*/
USE TelerikAcademy
GO 

UPDATE Users
SET UserPassword = UserPassword + '@Pa$$w0rd',
	FullName = Username + 'Name'
GO

UPDATE Groups
SET Name = REPLACE(Name, 'Group', 'Team')
GO

/*
21. Write SQL statements to delete some of the records from the Users and Groups tables.
*/
USE TelerikAcademy
GO 
DELETE FROM Users WHERE GroupID = 3
DELETE FROM Groups WHERE Name LIKE '%C'
GO

/*
22. Write SQL statements to insert in the Users table the names of all employees from the Employees table.
 Combine the first and last names as a full name. 
 For username use the first letter of the first name + the last name (in lowercase). 
 Use the same for the password, and NULL for last login time.
*/
USE TelerikAcademy
GO 
INSERT INTO Users (Username, UserPassword, FullName)
SELECT LOWER(LEFT(FirstName,1) + LastName + CONVERT(nvarchar, EmployeeID)), 
		LOWER(LEFT(FirstName,1) + LastName + CONVERT(nvarchar, EmployeeID)), 
			FirstName + ' ' + LastName
FROM Employees

/*
23. Write a SQL statement that changes the password to NULL for all users
 that have not been in the system since 10.03.2010.
*/
USE TelerikAcademy
GO 
UPDATE Users
SET UserPassword = NULL
WHERE LastLogin < CONVERT(datetime, '10.03.2010')

/*
24. Write a SQL statement that deletes all users without passwords (NULL password).
*/
USE TelerikAcademy
GO 
DELETE FROM Users
WHERE UserPassword IS NULL

/*
25. Write a SQL query to display the average employee salary by department and job title.
*/
USE TelerikAcademy
GO 
SELECT d.Name [Department], e.JobTitle [JobTitle], AVG(Salary) AS [AvgSalary]
FROM Employees e
	INNER JOIN Departments d
	ON(e.DepartmentID = d.DepartmentID)
GROUP BY d.Name, e.JobTitle

/*
26. Write a SQL query to display the minimal employee salary by department and job title 
along with the name of some of the employees that take it.
*/
USE TelerikAcademy
GO 
SELECT Department, grouped.JobTitle, MinSalary, emp.FirstName +' '+emp.LastName [Name]
FROM(SELECT d.Name [Department], e.JobTitle [JobTitle], MIN(Salary) AS [MinSalary]
	 FROM Employees e
		INNER JOIN Departments d
	 	ON(e.DepartmentID = d.DepartmentID)
	 GROUP BY d.Name, e.JobTitle ) AS grouped
INNER JOIN Employees emp
ON(emp.Salary = grouped.MinSalary AND emp.JobTitle = grouped.JobTitle)

/*
27. Write a SQL query to display the town where maximal number of employees work.
*/
USE TelerikAcademy
GO 
SELECT t.Name [TownName], COUNT(*) AS [EmpCount]
FROM Employees e
	INNER JOIN Addresses a
	ON(e.AddressID = a.AddressID)
		INNER JOIN Towns t
		ON(a.TownID = t.TownID)
GROUP BY t.Name
HAVING COUNT(*) = (SELECT MAX(EmpCount)
				FROM(SELECT t.Name [TownName], COUNT(*) AS [EmpCount]
					 FROM Employees e
					 	INNER JOIN Addresses a
					 	ON(e.AddressID = a.AddressID)
					 		INNER JOIN Towns t
					 		ON(a.TownID = t.TownID)
					 GROUP BY t.Name) AS Counted)

/*
28. Write a SQL query to display the number of managers from each town
*/
USE TelerikAcademy
GO 
SELECT t.Name, COUNT(e.ManagerID) [MngrsCount]
FROM Employees e
	INNER JOIN Addresses a
 	ON(e.AddressID = a.AddressID)
 		INNER JOIN Towns t
 		ON(a.TownID = t.TownID)
 GROUP BY t.Name

/*
29. Write a SQL to create table WorkHours to store work reports for each employee 
(employee id, date, task, hours, comments). 
Don't forget to define  identity, primary key and appropriate foreign key. 
Issue few SQL statements to insert, update and delete of some data in the table.
Define a table WorkHoursLogs to track all changes in the WorkHours table with triggers. 
For each change keep the old record data, the new record data and the command (insert / update / delete).
*/
USE TelerikAcademy
GO 
CREATE TABLE WorkHours(
WorkHoursID int IDENTITY,
EmployeeID int NOT NULL,
AssignedOn datetime NOT NULL,
Task nvarchar(100) NOT NULL, 
HoursNeeded int,
Comments nvarchar (200)
CONSTRAINT PK_WorkHours PRIMARY KEY(WorkHoursID)
CONSTRAINT FK_WorkHours_Employees
	FOREIGN KEY(EmployeeID)
	REFERENCES Employees(EmployeeID)
)
GO

INSERT INTO WorkHours (EmployeeID, AssignedOn, HoursNeeded, Task)
VALUES 
(5, NULL,  36, 'FirstTask'),
(4, NULL,  16, 'SecondTask'),
(2, NULL,  23, 'ThirdTask'),
(8, NULL,  12, 'ForthTask'),
(6, NULL,  48, 'FifthTask')

UPDATE WorkHours
SET Comments = 'SmallComment'
WHERE HoursNeeded <= 20

DELETE FROM WorkHours WHERE HoursNeeded > 24


CREATE TABLE WorkHoursLogs
(
  LogID int IDENTITY,
  WorkHoursIDOld int,
  EmployeeIDOld int,
  AssignedOnOld date,
  TaskOld nvarchar(100),
  HoursNeededOld int,
  CommentsOld nvarchar(200),

  WorkHoursIDNew int,
  EmployeeIDNew int,
  AssignedOnNew date,
  TaskNew nvarchar(100),
  HoursNeededNew int,
  CommentsNew nvarchar(200),
  CommandName nvarchar(10),
  CONSTRAINT PK_LogID PRIMARY KEY(LogID),
)
GO

CREATE TRIGGER TR_InsertWorkHours 
ON WorkHours FOR INSERT
AS
	INSERT INTO WorkHoursLogs (WorkHoursIDOld, EmployeeIDOld, AssignedOnOld, TaskOld, HoursNeededOld, CommentsOld, 
								WorkHoursIDNew, EmployeeIDNew, AssignedOnNew, TaskNew, HoursNeededNew, CommentsNew, CommandName)						
						SELECT NULL, NULL, NULL, NULL, NULL, NULL,
								i.WorkHoursID, i.AssignedOn, i.Task, i.HoursNeeded, i.Comments, i.EmployeeID, 'insert'
						FROM WorkHours w 
							INNER JOIN inserted i 	
							ON w.WorkHoursID = i.WorkHoursID
GO

CREATE TRIGGER TR_UpdateWorkHours 
ON WorkHours FOR UPDATE
AS
	INSERT INTO WorkHoursLogs (WorkHoursIDOld, EmployeeIDOld, AssignedOnOld, TaskOld, HoursNeededOld, CommentsOld, 
								WorkHoursIDNew, EmployeeIDNew, AssignedOnNew, TaskNew, HoursNeededNew, CommentsNew, CommandName)
						SELECT d.WorkHoursID, d.AssignedOn, d.Task, d.HoursNeeded, d.Comments, d.EmployeeID,
								i.WorkHoursID, i.AssignedOn, i.Task, i.HoursNeeded, i.Comments, i.EmployeeID,'update'
						FROM deleted d 
							INNER JOIN inserted i 
							ON d.WorkHoursID = i.WorkHoursID
GO

CREATE TRIGGER TR_DeleteWorkHours ON WorkHours FOR DELETE
AS
  INSERT INTO WorkHoursLogs (WorkHoursIDOld, EmployeeIDOld, AssignedOnOld, TaskOld, HoursNeededOld, CommentsOld,
								WorkHoursIDNew, EmployeeIDNew, AssignedOnNew, TaskNew, HoursNeededNew, CommentsNew, CommandName)
						SELECT d.WorkHoursID, d.AssignedOn, d.Task, d.HoursNeeded, d.Comments, d.EmployeeID,
							NULL, NULL, NULL, NULL, NULL, NULL,'delete'
						FROM deleted d
GO

/*
30. Start a database transaction, delete all employees from the 'Sales' department along with all dependent records from the pother tables. At the end rollback the transaction.
*/
USE TelerikAcademy
GO 
BEGIN TRAN 
ALTER TABLE Departments DROP [FK_Departments_Employees]
DELETE FROM Employees 
WHERE DepartmentID = (SELECT DepartmentID FROM Departments WHERE Name = 'Sales')
ROLLBACK TRAN
GO

/*
31. Start a database transaction and drop the table EmployeesProjects. Now how you could restore back the lost table data?
*/
USE TelerikAcademy
GO 
BEGIN TRAN 
DROP TABLE EmployeesProjects
ROLLBACK TRAN
GO

/*
32. Find how to use temporary tables in SQL Server. 
Using temporary tables backup all records from EmployeesProjects and 
restore them back after dropping and re-creating the table.
*/
USE TelerikAcademy
GO 
BEGIN TRAN
SELECT * 
INTO #TempTable 
FROM EmployeesProjects
DROP TABLE EmployeesProjects
COMMIT

CREATE TABLE [dbo].[EmployeesProjects](
	[EmployeeID] [int] NOT NULL,
	[ProjectID] [int] NOT NULL,
 CONSTRAINT [PK_EmployeesProjects] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC,
	[ProjectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) 
ON [PRIMARY]) ON [PRIMARY]

GO

ALTER TABLE [dbo].[EmployeesProjects]  WITH CHECK 
ADD CONSTRAINT [FK_EmployeesProjects_Employees] 
	FOREIGN KEY([EmployeeID])
	REFERENCES [dbo].[Employees] ([EmployeeID])
GO

ALTER TABLE [dbo].[EmployeesProjects] CHECK 
CONSTRAINT [FK_EmployeesProjects_Employees]
GO

ALTER TABLE [dbo].[EmployeesProjects]  WITH CHECK 
ADD CONSTRAINT [FK_EmployeesProjects_Projects] 
	FOREIGN KEY([ProjectID])
	REFERENCES [dbo].[Projects] ([ProjectID])
GO

ALTER TABLE [dbo].[EmployeesProjects] CHECK 
CONSTRAINT [FK_EmployeesProjects_Projects]
GO

--Restore information to re-created table
INSERT INTO EmployeesProjects
SELECT * FROM #TempTable
GO
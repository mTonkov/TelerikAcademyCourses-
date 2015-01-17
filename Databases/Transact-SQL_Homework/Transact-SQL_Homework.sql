/*
01. Create a database with two tables: Persons(Id(PK), FirstName, LastName, SSN) and Accounts(Id(PK), PersonId(FK), Balance). 
Insert few records for testing. 
Write a stored procedure that selects the full names of all persons.
*/
CREATE TABLE Persons(
Id int IDENTITY,
FirstName nvarchar(50),
LastName nvarchar(50),
SSN int
CONSTRAINT PK_Persons PRIMARY KEY(Id)
)
GO

CREATE TABLE Accounts(
Id int IDENTITY,
PersonId int,
Balance money
CONSTRAINT PK_Accounts PRIMARY KEY(Id)
CONSTRAINT FK_Accounts_Persons
	FOREIGN KEY (PersonId)
	REFERENCES Persons(Id)
)
GO

INSERT INTO Persons(FirstName, LastName, SSN)
VALUES
('Pesho', 'Ivanov', 123456789),
('Gosho', 'Petrov', 123456987),
('Ivan', 'Gorgiev', 123654987)
GO

INSERT INTO Accounts(PersonId, Balance)
VALUES
(1, 2500),
(2, 750),
(3, 3000)
GO

CREATE PROC dbo.usp_SelectFullNames
AS
SELECT FirstName + ' ' + LastName [FullName]
FROM dbo.Persons
GO

--Test
EXEC usp_SelectFullNames 
GO
/*
02. Create a stored procedure that accepts a number as a parameter and returns all persons
 who have more money in their accounts than the supplied number.
*/
CREATE PROC dbo.usp_PersonsWithMinimumMoney (@minMoney money)
AS
SELECT FirstName + ' ' + LastName [FullName], Balance
FROM dbo.Persons p
	INNER JOIN dbo.Accounts a
	ON(p.Id = a.PersonId)
WHERE Balance > @minMoney
GO

--Test
EXEC usp_PersonsWithMinimumMoney 1000 
GO
/*
03. Create a function that accepts as parameters – sum, yearly interest rate and number of months. 
It should calculate and return the new sum. 
Write a SELECT to test whether the function works as expected.
*/
CREATE FUNCTION dbo.ufn_CalcInterest(@sum int, @interest decimal(5,3), @months int)
  RETURNS int
AS
BEGIN
 RETURN @sum*(@interest*@months/12)
END
GO

SELECT FirstName + ' ' + LastName [FullName], Balance, dbo.ufn_CalcInterest(Balance, 0.1, 12) AS Interest
FROM dbo.Persons p
	INNER JOIN dbo.Accounts a
	ON(p.Id = a.PersonId)
GO
/*
04. Create a stored procedure that uses the function from the previous example 
to give an interest to a person's account for one month. 
It should take the AccountId and the interest rate as parameters.
*/
CREATE PROC dbo.usp_PayInterestForMonth (@accountId int, @interestRate decimal(5,3))
AS
UPDATE Accounts 
SET Balance = Balance+dbo.ufn_CalcInterest(Balance, @interestRate, 1)
WHERE Id = @accountId
GO

--Test
EXEC usp_PayInterestForMonth 3, 0.15
GO
SELECT FirstName + ' ' + LastName [FullName], Balance
FROM dbo.Persons p
	INNER JOIN dbo.Accounts a
	ON(p.Id = a.PersonId)
GO
/*
05. Add two more stored procedures WithdrawMoney( AccountId, money) and 
DepositMoney (AccountId, money) that operate in transactions.
*/
CREATE PROC dbo.usp_WithdrawMoney(@accountId int, @money int)
AS
BEGIN TRY
	BEGIN TRAN
		UPDATE Accounts
		SET Balance = Balance - @money
		WHERE Id = @accountId
	COMMIT TRAN
END TRY
BEGIN CATCH
	ROLLBACK TRAN
END CATCH
GO 

CREATE PROC dbo.usp_DepositMoney(@accountId int, @money int)
AS
BEGIN TRY
	BEGIN TRAN
		UPDATE Accounts
		SET Balance = Balance + @money
		WHERE Id = @accountId

	COMMIT TRAN
END TRY
BEGIN CATCH
	ROLLBACK TRAN
END CATCH
GO

/*
06. Create another table – Logs(LogID, AccountID, OldSum, NewSum). 
Add a trigger to the Accounts table that enters a new entry into the Logs table
 every time the sum on an account changes.
*/
CREATE TABLE Logs(
LogID int IDENTITY,
AccountID int NOT NULL,
OldSum money,
NewSum money
CONSTRAINT PK_Logs PRIMARY KEY(LogID)
CONSTRAINT FK_Logs_Accounts
	FOREIGN KEY (AccountID)
	REFERENCES Accounts(Id)
)
GO

CREATE TRIGGER tr_LogAccountBalance ON Accounts FOR UPDATE
AS
IF(EXISTS(SELECT * FROM inserted i 
INNER JOIN deleted d 
ON i.Id = d.Id 
WHERE i.Balance <> d.Balance))
	BEGIN							
		INSERT INTO Logs(AccountID, OldSum, NewSum)
			SELECT i.Id, d.Balance, i.Balance 
			FROM inserted i 
				INNER JOIN deleted d 
				ON i.Id = d.Id 
			WHERE i.Balance <> d.Balance
	END
GO
/*
07. Define a function in the database TelerikAcademy that returns all Employee's names (first or middle or last name) 
and all town's names that are comprised of given set of letters. 
Example 'oistmiahf' will return 'Sofia', 'Smith', … but not 'Rob' and 'Guy'.
*/
USE TelerikAcademy
GO

CREATE FUNCTION dbo.ufn_CheckIfHasLetters (@word nvarchar(20), @letters nvarchar(20))
RETURNS BIT
AS
BEGIN
	DECLARE @lettersLen int = LEN(@letters),
	@matches int = 0,
	@currentChar nvarchar(1)

	WHILE(@lettersLen > 0)
		BEGIN
			SET @currentChar = SUBSTRING(@letters, @lettersLen, 1)
			IF(CHARINDEX(@currentChar, @word, 0) > 0)
				BEGIN
					SET @matches += 1
				END
			SET @lettersLen -= 1
		END
	
	IF(@matches >= LEN(@word) OR @matches >= LEN(@letters))
		BEGIN
			RETURN 1
		END	
	RETURN 0
END
GO

CREATE FUNCTION ufn_GetNamesAndTowns (@pattern nvarchar(20))
RETURNS TABLE
AS
RETURN (
	SELECT fn.FirstName [Name]
	FROM Employees fn
	WHERE dbo.ufn_CheckIfHasLetters(fn.FirstName, @pattern) = 1 
		UNION
	SELECT mn.MiddleName
	FROM Employees mn
	WHERE dbo.ufn_CheckIfHasLetters(mn.MiddleName, @pattern) = 1 
		UNION
	SELECT ln.LastName
	FROM Employees ln
	WHERE dbo.ufn_CheckIfHasLetters(ln.LastName, @pattern) = 1 
		UNION
	SELECT t.Name 
	FROM Towns t
	WHERE dbo.ufn_CheckIfHasLetters(t.Name, @pattern) = 1
	)
GO

--TEST
SELECT * FROM ufn_GetNamesAndTowns('oistmiahf') 
GO


/*
08. Using database cursor write a T-SQL script that scans all employees and their addresses and prints all pairs of employees 
that live in the same town.
*/
DECLARE empCursor CURSOR READ_ONLY FOR
  SELECT DISTINCT e.FirstName + ' ' + e.LastName, t.Name 
  FROM Employees e
	JOIN Addresses a
	ON e.AddressID = a.AddressID
		JOIN Towns t
		ON a.TownID = t.TownID

OPEN empCursor
DECLARE @Name nvarchar(50), @Town nvarchar(50), @prevName nvarchar(50), @prevTown nvarchar(50)
FETCH NEXT FROM empCursor 
INTO @prevName, @prevTown

WHILE @@FETCH_STATUS = 0
  BEGIN
    FETCH NEXT FROM empCursor 
    INTO @Name, @Town
	    IF (@Town = @prevTown)
		BEGIN
			PRINT @prevName + ' ->' + @prevTown
			PRINT @Name + ' ->' + @Town
		END
	SET @prevName = @Name
	SET @prevTown = @Town
  END

CLOSE empCursor
DEALLOCATE empCursor
GO

/*
09.* Write a T-SQL script that shows for each town a list of all employees that live in it. Sample output:
*/
DECLARE empCursor CURSOR READ_ONLY FOR
  SELECT  t.Name AS Town, (e.FirstName + ' ' + e.LastName) AS Name
  FROM Employees e
	JOIN Addresses a
	ON e.AddressID = a.AddressID
		JOIN Towns t
		ON a.TownID = t.TownID
		GROUP BY t.Name, (e.FirstName + ' ' + e.LastName) 

OPEN empCursor
DECLARE @Name nvarchar(50), @Town nvarchar(50), @nameToPrint nvarchar(50), @townToPrint nvarchar(50)
FETCH NEXT FROM empCursor 
INTO @townToPrint, @nameToPrint

WHILE @@FETCH_STATUS = 0
  BEGIN
    FETCH NEXT FROM empCursor 
    INTO @Town, @Name
	    IF (@Town = @townToPrint)
		BEGIN
			SET @nameToPrint = CONCAT(@nameToPrint, ', ',  @Name)
		END
		ELSE
		BEGIN
			PRINT @townToPrint + '->' + @nameToPrint
			SET @townToPrint = @Town
			SET @nameToPrint = @Name
		END
  END
CLOSE empCursor
DEALLOCATE empCursor
/*
10. Define a .NET aggregate function StrConcat that takes as input a sequence of strings and 
return a single string that consists of the input strings separated by ','. 
For example the following SQL statement should return a single string:

SELECT StrConcat(FirstName + ' ' + LastName)
FROM Employees
*/
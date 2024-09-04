USE CompanyDB;
GO

CREATE PROCEDURE sp_AddEmployee 
    @FirstName NVARCHAR(50), 
    @LastName NVARCHAR(50), 
    @Position NVARCHAR(50), 
    @Salary DECIMAL(18,2), 
    @Location INT
AS
BEGIN
    INSERT INTO Employees (FirstName, LastName, Position, Salary, Location)
    VALUES (@FirstName, @LastName, @Position, @Salary, @Location)
END
GO
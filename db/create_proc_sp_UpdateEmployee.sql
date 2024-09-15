USE CompanyDB;
GO

CREATE PROCEDURE sp_UpdateEmployee
    @EmployeeId INT, 
    @FirstName NVARCHAR(50), 
    @LastName NVARCHAR(50), 
    @Position NVARCHAR(50), 
    @Salary DECIMAL(18,2),     
	@Location INT		
AS
BEGIN    
    UPDATE Employees
    SET FirstName = @FirstName,
        LastName = @LastName,
        Position = @Position,
        Salary = @Salary,
        Location = @Location
    WHERE EmployeeId = @EmployeeId;
END;
GO

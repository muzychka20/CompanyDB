USE CompanyDB;
GO

CREATE PROCEDURE sp_DeleteEmployee @EmployeeId INT
AS
BEGIN
    DELETE FROM Employees WHERE Employees.EmployeeId = @EmployeeId;
END
GO
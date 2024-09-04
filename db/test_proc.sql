USE CompanyDB;

EXEC sp_AddEmployee 
		@FirstName = 'First Name',
		@LastName = 'Last Name',
		@Position='Position',
		@Salary = 1000.00,
		@Location = 1;

EXEC sp_GetAllEmployees;

EXEC sp_UpdateEmployee 
		@EmployeeId = 1,
		@FirstName = 'New First Name',
		@LastName = 'New Last Name',
		@Position='New Position',
		@Salary = 2000.00,
		@Location = 1;

EXEC sp_DeleteEmployee 1;
USE CompanyDB;

EXEC sp_GetAllEmployees;

EXEC sp_AddEmployee 
    @FirstName = 'Name',
    @LastName = 'LName',
    @Position = 'Manager',
    @Salary = 5000.00,
    @CountryName = 'Ukraine',
    @CityName = 'Kyiv',
    @StreetName = 'Street',
    @HouseNumber = '10',
    @ApartmentNumber = '25',
    @FloorNumber = '5';

EXEC sp_UpdateEmployee 
    @EmployeeId = 7,
    @FirstName = 'Ivan',
    @LastName = 'Ivanov',
    @Position = 'Developer',
    @Salary = 12000.00,
    @CountryName = 'Germany',
    @CityName = 'Berlin',
    @StreetName = 'STREET',
    @HouseNumber = '5',
    @ApartmentNumber = '50',
    @FloorNumber = '10';

EXEC sp_DeleteEmployee 3;
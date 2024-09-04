USE CompanyDB;
GO

CREATE PROCEDURE sp_GetAllEmployees
AS
BEGIN
    SELECT 
        Employees.EmployeeId AS 'Id',
        Employees.FirstName AS 'First Name',
        Employees.LastName AS 'Last Name',
        Employees.Position AS 'Position',
        Employees.Salary AS 'Salary',
        Apartments.ApartmentNumber AS 'Apartment',
        Apartments.FloorNumber AS 'Floor',        
        Houses.HouseNumber AS 'House',
        Streets.StreetName AS 'Street',
        Cities.CityName AS 'City',
        Countries.CountryName AS 'Country'
    FROM Employees
    JOIN Apartments ON Apartments.ApartmentId = Employees.Location
    JOIN Houses ON Houses.HouseId = Apartments.HouseId
    JOIN Streets ON Streets.StreetId = Houses.StreetId
    JOIN Cities ON Cities.CityId = Streets.CityId
    JOIN Countries ON Countries.CountryId = Cities.CountryId
END
GO
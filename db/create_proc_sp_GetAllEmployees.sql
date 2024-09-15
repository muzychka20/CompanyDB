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
        Countries.CountryName AS 'Country',
        Cities.CityName AS 'City',
        Streets.StreetName AS 'Street',
        Houses.HouseNumber AS 'House',
        Apartments.FloorNumber AS 'Floor',        
        Apartments.ApartmentNumber AS 'Apartment',
        Countries.CountryId AS 'CountryId',
		Cities.CityId AS 'CityId',
		Streets.StreetId AS 'StreetId',
		Houses.HouseId AS 'HouseId',
		Apartments.ApartmentId AS 'ApartmentId'
    FROM Employees
    JOIN Apartments ON Apartments.ApartmentId = Employees.Location
    JOIN Houses ON Houses.HouseId = Apartments.HouseId
    JOIN Streets ON Streets.StreetId = Houses.StreetId
    JOIN Cities ON Cities.CityId = Streets.CityId
    JOIN Countries ON Countries.CountryId = Cities.CountryId
END
GO
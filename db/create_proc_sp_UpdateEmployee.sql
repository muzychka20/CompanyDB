USE CompanyDB;
GO

CREATE PROCEDURE sp_UpdateEmployee
    @EmployeeId INT, 
    @FirstName NVARCHAR(50), 
    @LastName NVARCHAR(50), 
    @Position NVARCHAR(50), 
    @Salary DECIMAL(18,2), 
    @CountryName NVARCHAR(50),
    @CityName NVARCHAR(50),
    @StreetName NVARCHAR(50),
    @HouseNumber NVARCHAR(10),
    @ApartmentNumber NVARCHAR(10),
    @FloorNumber NVARCHAR(10)
AS
BEGIN
    DECLARE @CountryId INT, @CityId INT, @StreetId INT, @HouseId INT, @ApartmentId INT;

    -- Add or update the country if it doesn't exist
    IF NOT EXISTS (SELECT 1 FROM Countries WHERE CountryName = @CountryName)
    BEGIN
        INSERT INTO Countries (CountryName) VALUES (@CountryName);
        SET @CountryId = SCOPE_IDENTITY();
    END
    ELSE
    BEGIN
        SELECT @CountryId = CountryId FROM Countries WHERE CountryName = @CountryName;
    END;

    -- Add or update the city if it doesn't exist (considering the country)
    IF NOT EXISTS (SELECT 1 FROM Cities WHERE CityName = @CityName AND CountryId = @CountryId)
    BEGIN
        INSERT INTO Cities (CityName, CountryId) VALUES (@CityName, @CountryId);
        SET @CityId = SCOPE_IDENTITY();
    END
    ELSE
    BEGIN
        SELECT @CityId = CityId FROM Cities WHERE CityName = @CityName AND CountryId = @CountryId;
    END;

    -- Add or update the street if it doesn't exist (considering the city)
    IF NOT EXISTS (SELECT 1 FROM Streets WHERE StreetName = @StreetName AND CityId = @CityId)
    BEGIN
        INSERT INTO Streets (StreetName, CityId) VALUES (@StreetName, @CityId);
        SET @StreetId = SCOPE_IDENTITY();
    END
    ELSE
    BEGIN
        SELECT @StreetId = StreetId FROM Streets WHERE StreetName = @StreetName AND CityId = @CityId;
    END;

    -- Add or update the house if it doesn't exist (considering the street)
    IF NOT EXISTS (SELECT 1 FROM Houses WHERE HouseNumber = @HouseNumber AND StreetId = @StreetId)
    BEGIN
        INSERT INTO Houses (HouseNumber, StreetId) VALUES (@HouseNumber, @StreetId);
        SET @HouseId = SCOPE_IDENTITY();
    END
    ELSE
    BEGIN
        SELECT @HouseId = HouseId FROM Houses WHERE HouseNumber = @HouseNumber AND StreetId = @StreetId;
    END;

    -- Add or update the apartment
    IF NOT EXISTS (SELECT 1 FROM Apartments WHERE ApartmentNumber = @ApartmentNumber AND FloorNumber = @FloorNumber AND HouseId = @HouseId)
    BEGIN
        INSERT INTO Apartments (ApartmentNumber, FloorNumber, HouseId)
        VALUES (@ApartmentNumber, @FloorNumber, @HouseId);
        SET @ApartmentId = SCOPE_IDENTITY();
    END
    ELSE
    BEGIN
        SELECT @ApartmentId = ApartmentId FROM Apartments WHERE ApartmentNumber = @ApartmentNumber AND FloorNumber = @FloorNumber AND HouseId = @HouseId;
    END;

    -- Update employee information
    UPDATE Employees
    SET FirstName = @FirstName,
        LastName = @LastName,
        Position = @Position,
        Salary = @Salary,
        Location = @ApartmentId
    WHERE EmployeeId = @EmployeeId;
END;
GO

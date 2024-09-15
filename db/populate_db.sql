USE CompanyDB;

-- Insert countries
INSERT INTO Countries (CountryName) VALUES ('USA');
INSERT INTO Countries (CountryName) VALUES ('Canada');
INSERT INTO Countries (CountryName) VALUES ('Germany');
INSERT INTO Countries (CountryName) VALUES ('France');




-- Insert cities for USA
INSERT INTO Cities (CityName, CountryId) VALUES ('New York', 1);
INSERT INTO Cities (CityName, CountryId) VALUES ('Los Angeles', 1);
INSERT INTO Cities (CityName, CountryId) VALUES ('Chicago', 1);

-- Insert cities for Canada
INSERT INTO Cities (CityName, CountryId) VALUES ('Toronto', 2);
INSERT INTO Cities (CityName, CountryId) VALUES ('Vancouver', 2);
INSERT INTO Cities (CityName, CountryId) VALUES ('Montreal', 2);

-- Insert cities for Germany
INSERT INTO Cities (CityName, CountryId) VALUES ('Berlin', 3);
INSERT INTO Cities (CityName, CountryId) VALUES ('Munich', 3);
INSERT INTO Cities (CityName, CountryId) VALUES ('Hamburg', 3);

-- Insert cities for France
INSERT INTO Cities (CityName, CountryId) VALUES ('Paris', 4);
INSERT INTO Cities (CityName, CountryId) VALUES ('Marseille', 4);
INSERT INTO Cities (CityName, CountryId) VALUES ('Lyon', 4);




-- Insert streets for New York
INSERT INTO Streets (StreetName, CityId) VALUES ('5th Avenue', 1);
INSERT INTO Streets (StreetName, CityId) VALUES ('Broadway', 1);
INSERT INTO Streets (StreetName, CityId) VALUES ('Wall Street', 1);

-- Insert streets for Los Angeles
INSERT INTO Streets (StreetName, CityId) VALUES ('Hollywood Blvd', 2);
INSERT INTO Streets (StreetName, CityId) VALUES ('Sunset Blvd', 2);
INSERT INTO Streets (StreetName, CityId) VALUES ('Rodeo Drive', 2);

-- Insert streets for Chicago
INSERT INTO Streets (StreetName, CityId) VALUES ('Michigan Avenue', 3);
INSERT INTO Streets (StreetName, CityId) VALUES ('State Street', 3);
INSERT INTO Streets (StreetName, CityId) VALUES ('Wacker Drive', 3);

-- Insert streets for Toronto
INSERT INTO Streets (StreetName, CityId) VALUES ('Yonge Street', 4);
INSERT INTO Streets (StreetName, CityId) VALUES ('Queen Street', 4);
INSERT INTO Streets (StreetName, CityId) VALUES ('King Street', 4);

-- Insert streets for Vancouver
INSERT INTO Streets (StreetName, CityId) VALUES ('Granville Street', 5);
INSERT INTO Streets (StreetName, CityId) VALUES ('Robson Street', 5);
INSERT INTO Streets (StreetName, CityId) VALUES ('Main Street', 5);

-- Insert streets for Montreal
INSERT INTO Streets (StreetName, CityId) VALUES ('St. Catherine Street', 6);
INSERT INTO Streets (StreetName, CityId) VALUES ('St. Denis Street', 6);
INSERT INTO Streets (StreetName, CityId) VALUES ('St. Laurent Boulevard', 6);

-- Insert streets for Berlin
INSERT INTO Streets (StreetName, CityId) VALUES ('Unter den Linden', 7);
INSERT INTO Streets (StreetName, CityId) VALUES ('Kurfürstendamm', 7);
INSERT INTO Streets (StreetName, CityId) VALUES ('Alexanderplatz', 7);

-- Insert streets for Munich
INSERT INTO Streets (StreetName, CityId) VALUES ('Marienplatz', 8);
INSERT INTO Streets (StreetName, CityId) VALUES ('Kaufingerstrasse', 8);
INSERT INTO Streets (StreetName, CityId) VALUES ('Maximilianstrasse', 8);

-- Insert streets for Hamburg
INSERT INTO Streets (StreetName, CityId) VALUES ('Reeperbahn', 9);
INSERT INTO Streets (StreetName, CityId) VALUES ('Mönckebergstraße', 9);
INSERT INTO Streets (StreetName, CityId) VALUES ('Altonaer Straße', 9);

-- Insert streets for Paris
INSERT INTO Streets (StreetName, CityId) VALUES ('Champs-Élysées', 10);
INSERT INTO Streets (StreetName, CityId) VALUES ('Rue de Rivoli', 10);
INSERT INTO Streets (StreetName, CityId) VALUES ('Boulevard Saint-Germain', 10);

-- Insert streets for Marseille
INSERT INTO Streets (StreetName, CityId) VALUES ('La Canebière', 11);
INSERT INTO Streets (StreetName, CityId) VALUES ('Rue Saint-Ferréol', 11);
INSERT INTO Streets (StreetName, CityId) VALUES ('Boulevard des Dames', 11);

-- Insert streets for Lyon
INSERT INTO Streets (StreetName, CityId) VALUES ('Rue de la République', 12);
INSERT INTO Streets (StreetName, CityId) VALUES ('Rue Victor Hugo', 12);
INSERT INTO Streets (StreetName, CityId) VALUES ('Cours Lafayette', 12);




-- Insert houses for every street with random house numbers
DECLARE @StreetId INT = 1;
DECLARE @MaxStreetId INT = 36;
DECLARE @HouseCount INT = 3; -- Number of houses per street

WHILE @StreetId <= @MaxStreetId
BEGIN
    -- Insert for each house on the current street
    DECLARE @HouseNumber INT = 1;
    WHILE @HouseNumber <= @HouseCount
    BEGIN
        -- Generate a random house number between 1 and 999
        DECLARE @RandomHouseNumber NVARCHAR(10) = CAST((ABS(CHECKSUM(NEWID())) % 999) + 1 AS NVARCHAR(10));

        -- Insert into the Houses table
        INSERT INTO Houses (HouseNumber, StreetId) VALUES (@RandomHouseNumber, @StreetId);

        SET @HouseNumber = @HouseNumber + 1;
    END

    -- Move to the next street
    SET @StreetId = @StreetId + 1;
END




-- Inserting random data into the Apartments table for each of the 108 houses
DECLARE @HouseId INT = 1;
DECLARE @MaxHouseId INT = 108;

WHILE @HouseId <= @MaxHouseId
BEGIN
    -- Generate random apartment number and floor number
    DECLARE @RandomApartmentNumber NVARCHAR(10) = CAST((ABS(CHECKSUM(NEWID())) % 1000) + 1 AS NVARCHAR(10));
    DECLARE @RandomFloorNumber NVARCHAR(10) = CAST((ABS(CHECKSUM(NEWID())) % 10) + 1 AS NVARCHAR(10));

    -- Insert the random data into the Apartments table
    INSERT INTO Apartments (ApartmentNumber, FloorNumber, HouseId) VALUES (@RandomApartmentNumber, @RandomFloorNumber, @HouseId);
    INSERT INTO Apartments (ApartmentNumber, FloorNumber, HouseId) VALUES (@RandomApartmentNumber + 'A', @RandomFloorNumber + 'A', @HouseId);
    
    SET @HouseId = @HouseId + 1;
END




-- Insert Employees
EXEC sp_AddEmployee 
    @FirstName = 'John',
    @LastName = 'Doe',
    @Position = 'Manager',
    @Salary = 5000.00,
    @Location = 1;

EXEC sp_AddEmployee 
    @FirstName = 'Jane',
    @LastName = 'Smith',
    @Position = 'Developer',
    @Salary = 4500.00,
    @Location = 30;

EXEC sp_AddEmployee 
    @FirstName = 'Alice',
    @LastName = 'Johnson',
    @Position = 'Designer',
    @Salary = 4000.00,
    @Location = 60;

EXEC sp_AddEmployee 
    @FirstName = 'Bob',
    @LastName = 'Brown',
    @Position = 'Analyst',
    @Salary = 5500.00,
    @Location = 90;

EXEC sp_AddEmployee 
    @FirstName = 'Charlie',
    @LastName = 'Davis',
    @Position = 'HR Specialist',
    @Salary = 4200.00,
    @Location = 100;

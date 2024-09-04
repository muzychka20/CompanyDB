USE CompanyDB;

CREATE TABLE Countries (
    CountryId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    CountryName NVARCHAR(50) NOT NULL
);

CREATE TABLE Cities (
    CityId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    CityName NVARCHAR(50) NOT NULL,
    CountryId INT NOT NULL,
    FOREIGN KEY (CountryId) REFERENCES Countries(CountryId)
);

CREATE TABLE Streets (
    StreetId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    StreetName NVARCHAR(50) NOT NULL,
    CityId INT NOT NULL,
    FOREIGN KEY (CityId) REFERENCES Cities(CityId)
);

CREATE TABLE Houses (
    HouseId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    HouseNumber NVARCHAR(10) NOT NULL,
    StreetId INT NOT NULL,
    FOREIGN KEY (StreetId) REFERENCES Streets(StreetId)
);

CREATE TABLE Apartments (
    ApartmentId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    ApartmentNumber NVARCHAR(10) NOT NULL,
    FloorNumber INT NOT NULL,
    HouseId INT NOT NULL,
    FOREIGN KEY (HouseId) REFERENCES Houses(HouseId)
);

CREATE TABLE Employees (
    EmployeeId INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Position NVARCHAR(50) NOT NULL,
    Salary DECIMAL(18,2) NOT NULL,
    Location INT NOT NULL,
    FOREIGN KEY (Location) REFERENCES Apartments(ApartmentId)
);

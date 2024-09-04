USE CompanyDB;

INSERT INTO Countries (CountryName)
VALUES ('Ukraine');

INSERT INTO Cities (CityName, CountryId)
VALUES ('Dnipro', 1);

INSERT INTO Streets (StreetName, CityId)
VALUES ('Street1', 1);

INSERT INTO Houses (HouseNumber, StreetId)
VALUES ('House1', 1);

INSERT INTO Apartments (ApartmentNumber, FloorNumber, HouseId)
VALUES ('422b', 4, 1);

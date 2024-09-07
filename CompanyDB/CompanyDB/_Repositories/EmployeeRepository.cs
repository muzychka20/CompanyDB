using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CompanyDB.Models;
using static System.Net.Mime.MediaTypeNames;

namespace CompanyDB._Repositories
{
    public class EmployeeRepository : BaseRepository, IEmployeeRepository
    {
        // Constructor
        public EmployeeRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Methods
        public void AddEmployee(EmployeeModel employeeModel)
        {
            var employeeList = new List<EmployeeModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;                
                command.CommandText = "INSERT INTO Employees values (@firstName, @lastName, @position, @salary, @location)";
                command.Parameters.Add("@firstName", SqlDbType.NVarChar).Value = employeeModel.FirstName;
                command.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = employeeModel.LastName;
                command.Parameters.Add("@position", SqlDbType.NVarChar).Value = employeeModel.Position;
                command.Parameters.Add("@salary", SqlDbType.Decimal).Value = employeeModel.Salary;
                command.Parameters.Add("@location", SqlDbType.Int).Value = employeeModel.Location;
                command.ExecuteNonQuery();
            }
        }

        public void DeleteEmployee(int id)
        {
            var employeeList = new List<EmployeeModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Employees WHERE EmployeeId = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;                
                command.ExecuteNonQuery();
            }
        }

        public void EditEmployee(EmployeeModel employeeModel)
        {
            var employeeList = new List<EmployeeModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Employees 
                                        SET FirstName = @firstName, LastName = @lastName, Position = @position, Salary = @salary, Location = @location 
                                        WHERE EmployeeId = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = employeeModel.Id;
                command.Parameters.Add("@firstName", SqlDbType.NVarChar).Value = employeeModel.FirstName;
                command.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = employeeModel.LastName;
                command.Parameters.Add("@position", SqlDbType.NVarChar).Value = employeeModel.Position;
                command.Parameters.Add("@salary", SqlDbType.Decimal).Value = employeeModel.Salary;
                command.Parameters.Add("@location", SqlDbType.Int).Value = employeeModel.Location;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
            /* var employeeList = new List<EmployeeModel>();
             SqlConnection connection = new SqlConnection(connectionString);            
             using (var command = new SqlCommand("sp_GetAllEmployees", connection))
             { 
                 connection.Open();
                 command.CommandType = System.Data.CommandType.StoredProcedure;
                 SqlDataReader reader = command.ExecuteReader();

                 while (reader.Read())
                 {
                     var employeeModel = new EmployeeModel();
                     employeeModel.Id = reader.GetInt32(0);
                     employeeModel.FirstName = reader[1].ToString();
                     employeeModel.LastName = reader[2].ToString();
                     employeeModel.Position = reader[3].ToString();
                     employeeModel.Salary = reader.GetDecimal(4);
                     employeeModel.Location = reader.GetInt32(5);
                     employeeList.Add(employeeModel);
                 }

                 return employeeList;
             } */

            var employeeList = new List<EmployeeModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                // command.CommandText = "SELECT Employees.EmployeeId AS 'Id', Employees.FirstName AS 'First Name', Employees.LastName AS 'Last Name', Employees.Position AS 'Position', Employees.Salary AS 'Salary', Apartments.ApartmentNumber AS 'Apartment', Apartments.FloorNumber AS 'Floor', Houses.HouseNumber AS 'House', Streets.StreetName AS 'Street',\r\n        Cities.CityName AS 'City',\r\n        Countries.CountryName AS 'Country' FROM Employees JOIN Apartments ON Apartments.ApartmentId = Employees.Location JOIN Houses ON Houses.HouseId = Apartments.HouseId JOIN Streets ON Streets.StreetId = Houses.StreetId JOIN Cities ON Cities.CityId = Streets.CityId JOIN Countries ON Countries.CountryId = Cities.CountryId";
                command.CommandText = "SELECT * FROM Employees";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var employeeModel = new EmployeeModel();
                        employeeModel.Id = reader.GetInt32(0);
                        employeeModel.FirstName = reader.GetString(1);
                        employeeModel.LastName = reader.GetString(2);
                        employeeModel.Position = reader.GetString(3);
                        employeeModel.Salary = reader.GetDecimal(4);
                        employeeModel.Location = reader.GetInt32(5);
                        employeeList.Add(employeeModel);
                    }
                }
                return employeeList;
            }
        }        
    }
}

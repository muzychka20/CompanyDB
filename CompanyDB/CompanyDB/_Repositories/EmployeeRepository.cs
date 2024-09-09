using System.Data.SqlClient;
using System.Data;
using CompanyDB.Models;

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
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("sp_AddEmployee", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();                                
                command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = employeeModel.FirstName;
                command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = employeeModel.LastName;
                command.Parameters.Add("@Position", SqlDbType.NVarChar).Value = employeeModel.Position;
                command.Parameters.Add("@Salary", SqlDbType.Decimal).Value = employeeModel.Salary;
                command.Parameters.Add("@CountryName", SqlDbType.NVarChar).Value = employeeModel.CountryName;
                command.Parameters.Add("@CityName", SqlDbType.NVarChar).Value = employeeModel.CityName;
                command.Parameters.Add("@StreetName", SqlDbType.NVarChar).Value = employeeModel.StreetName;
                command.Parameters.Add("@HouseNumber", SqlDbType.NVarChar).Value = employeeModel.HouseNumber;
                command.Parameters.Add("@ApartmentNumber", SqlDbType.NVarChar).Value = employeeModel.ApartmentNumber;
                command.Parameters.Add("@FloorNumber", SqlDbType.NVarChar).Value = employeeModel.FloorNumber;               
                command.ExecuteNonQuery();
            }
        }

        public void DeleteEmployee(int id)
        {            
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("sp_DeleteEmployee", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();                                
                command.Parameters.Add("@EmployeeId", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void UpdateEmployee(EmployeeModel employeeModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("sp_UpdateEmployee", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                command.Parameters.Add("@EmployeeId", SqlDbType.Int).Value = employeeModel.Id;
                command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = employeeModel.FirstName;
                command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = employeeModel.LastName;
                command.Parameters.Add("@Position", SqlDbType.NVarChar).Value = employeeModel.Position;
                command.Parameters.Add("@Salary", SqlDbType.Decimal).Value = employeeModel.Salary;
                command.Parameters.Add("@CountryName", SqlDbType.NVarChar).Value = employeeModel.CountryName;
                command.Parameters.Add("@CityName", SqlDbType.NVarChar).Value = employeeModel.CityName;
                command.Parameters.Add("@StreetName", SqlDbType.NVarChar).Value = employeeModel.StreetName;
                command.Parameters.Add("@HouseNumber", SqlDbType.NVarChar).Value = employeeModel.HouseNumber;
                command.Parameters.Add("@ApartmentNumber", SqlDbType.NVarChar).Value = employeeModel.ApartmentNumber;
                command.Parameters.Add("@FloorNumber", SqlDbType.NVarChar).Value = employeeModel.FloorNumber;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<EmployeeModel> GetAllEmployees()
        { 
            var employeeList = new List<EmployeeModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("sp_GetAllEmployees", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();                
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
                        employeeModel.CountryName = reader.GetString(5);
                        employeeModel.CityName = reader.GetString(6);
                        employeeModel.StreetName = reader.GetString(7);
                        employeeModel.HouseNumber = reader.GetString(8);
                        employeeModel.FloorNumber = reader.GetString(9);
                        employeeModel.ApartmentNumber = reader.GetString(10);
                        employeeList.Add(employeeModel);
                    }
                }
                return employeeList;
            }            
        }        
    }
}
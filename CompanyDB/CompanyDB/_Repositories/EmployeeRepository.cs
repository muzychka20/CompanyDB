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
                command.Parameters.AddWithValue("@FirstName", employeeModel.EmployeeFirstName);
                command.Parameters.AddWithValue("@LastName", employeeModel.EmployeeLastName);
                command.Parameters.AddWithValue("@Position", employeeModel.EmployeePosition);
                command.Parameters.AddWithValue("@Salary", employeeModel.EmployeeSalary);
                command.Parameters.AddWithValue("@Location", employeeModel.EmployeeApartmentID);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteEmployee(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("sp_DeleteEmployee", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmployeeId", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdateEmployee(EmployeeModel employeeModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("sp_UpdateEmployee", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmployeeId", employeeModel.EmployeeID);
                command.Parameters.AddWithValue("@FirstName", employeeModel.EmployeeFirstName);
                command.Parameters.AddWithValue("@LastName", employeeModel.EmployeeLastName);
                command.Parameters.AddWithValue("@Position", employeeModel.EmployeePosition);
                command.Parameters.AddWithValue("@Salary", employeeModel.EmployeeSalary);
                command.Parameters.AddWithValue("@Location", employeeModel.EmployeeApartmentID);

                connection.Open();
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
                        var employeeModel = new EmployeeModel
                        {
                            EmployeeID = reader.GetInt32(reader.GetOrdinal("Id")),
                            EmployeeFirstName = reader.GetString(reader.GetOrdinal("First Name")),
                            EmployeeLastName = reader.GetString(reader.GetOrdinal("Last Name")),
                            EmployeePosition = reader.GetString(reader.GetOrdinal("Position")),
                            EmployeeSalary = reader.GetDecimal(reader.GetOrdinal("Salary")),
                            EmployeeCountryName = reader.GetString(reader.GetOrdinal("Country")),
                            EmployeeCityName = reader.GetString(reader.GetOrdinal("City")),
                            EmployeeStreetName = reader.GetString(reader.GetOrdinal("Street")),
                            EmployeeHouseNumber = reader.GetString(reader.GetOrdinal("House")),
                            EmployeeFloorNumber = reader.GetString(reader.GetOrdinal("Floor")),
                            EmployeeApartmentNumber = reader.GetString(reader.GetOrdinal("Apartment")),
                            EmployeeCountryID = reader.GetInt32(reader.GetOrdinal("CountryId")),
                            EmployeeCityID = reader.GetInt32(reader.GetOrdinal("CityId")),
                            EmployeeStreetID = reader.GetInt32(reader.GetOrdinal("StreetId")),
                            EmployeeHouseID = reader.GetInt32(reader.GetOrdinal("HouseId")),
                            EmployeeApartmentID = reader.GetInt32(reader.GetOrdinal("ApartmentID")),
                        };

                        employeeList.Add(employeeModel);
                    }
                }
            }

            return employeeList;
        }
    }
}

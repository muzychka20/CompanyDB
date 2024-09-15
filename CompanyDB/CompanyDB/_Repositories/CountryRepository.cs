using System.Data.SqlClient;
using System.Data;
using CompanyDB.Models;

namespace CompanyDB._Repositories
{
    public class CountryRepository : BaseRepository, ICountryRepository
    {
        // Constructor
        public CountryRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Methods                       
        public async Task<IEnumerable<CountryModel>> GetAllCountries()
        {
            List<CountryModel> countries = new List<CountryModel>();

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("SELECT CountryId, CountryName FROM Countries;", connection))
            {
                connection.Open();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (reader.Read())
                    {
                        countries.Add(new CountryModel
                        {
                            CountryID = reader.GetInt32(reader.GetOrdinal("CountryId")),
                            CountryName = reader.GetString(reader.GetOrdinal("CountryName"))
                        });
                    }
                }
            }

            return countries;
        }
    }
}
using System.Data.SqlClient;
using System.Data;
using CompanyDB.Models;

namespace CompanyDB._Repositories
{
    public class CityRepository : BaseRepository, ICityRepository
    {
        // Constructor
        public CityRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Methods                       
        public async Task<IEnumerable<CityModel>> GetCitiesByCountryId(int countryId)
        {
            List<CityModel> cities = new List<CityModel>();

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("SELECT Cities.CityId, Cities.CityName FROM Cities WHERE Cities.CountryId = @CountryId;", connection))
            {
                command.Parameters.AddWithValue("@CountryId", countryId);
                connection.Open();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (reader.Read())
                    {
                        cities.Add(new CityModel
                        {
                            CityID = reader.GetInt32(reader.GetOrdinal("CityId")),
                            CityName = reader.GetString(reader.GetOrdinal("CityName"))
                        });
                    }
                }
            }

            return cities;
        }
    }
}
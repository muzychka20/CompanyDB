using System.Data.SqlClient;
using System.Data;
using CompanyDB.Models;

namespace CompanyDB._Repositories
{
    public class StreetRepository : BaseRepository, IStreetRepository
    {
        // Constructor
        public StreetRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Methods        
        public async Task<IEnumerable<StreetModel>> GetStreetsByCityId(int cityId)
        {
            List<StreetModel> streets = new List<StreetModel>();

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("SELECT Streets.StreetId, Streets.StreetName FROM Streets WHERE CityId = @CityId;", connection))
            {
                command.Parameters.AddWithValue("@CityId", cityId);
                connection.Open();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        streets.Add(new StreetModel
                        {
                            StreetID = reader.GetInt32(reader.GetOrdinal("StreetId")),
                            StreetName = reader.GetString(reader.GetOrdinal("StreetName"))
                        });
                    }
                }
            }
            return streets;
        }
    }
}
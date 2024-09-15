using System.Data.SqlClient;
using System.Data;
using CompanyDB.Models;

namespace CompanyDB._Repositories
{
    public class HouseRepository : BaseRepository, IHouseRepository
    {
        // Constructor
        public HouseRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Methods        
        public async Task<IEnumerable<HouseModel>> GetHousesByStreetId(int streetId)
        {
            List<HouseModel> houses = new List<HouseModel>();

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("SELECT HouseId, HouseNumber FROM Houses WHERE StreetId = @StreetId;", connection))
            {
                command.Parameters.AddWithValue("@StreetId", streetId);
                connection.Open();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        houses.Add(new HouseModel
                        {
                            HouseID = reader.GetInt32(reader.GetOrdinal("HouseId")),
                            HouseNumber = reader.GetString(reader.GetOrdinal("HouseNumber"))
                        });
                    }
                }
            }
            return houses;
        }
    }
}
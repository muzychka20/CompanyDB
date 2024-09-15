using System.Data.SqlClient;
using System.Data;
using CompanyDB.Models;

namespace CompanyDB._Repositories
{
    public class ApartmentRepository : BaseRepository, IApartmentRepository
    {
        // Constructor
        public ApartmentRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Methods        
        public async Task<IEnumerable<ApartmentModel>> GetApartmentsByHouseId(int houseId)
        {
            List<ApartmentModel> apartments = new List<ApartmentModel>();

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("SELECT ApartmentId, ApartmentNumber, FloorNumber FROM Apartments WHERE HouseId = @HouseId;", connection))
            {
                command.Parameters.AddWithValue("@HouseId", houseId);
                connection.Open();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        apartments.Add(new ApartmentModel
                        {
                            ApartmentID = reader.GetInt32(reader.GetOrdinal("ApartmentId")),
                            ApartmentNumber = reader.GetString(reader.GetOrdinal("ApartmentNumber")),
                            ApartmentFloorNumber = reader.GetString(reader.GetOrdinal("FloorNumber"))
                        });
                    }
                }
            }
            return apartments;
        }

    }
}
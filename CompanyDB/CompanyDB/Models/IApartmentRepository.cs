namespace CompanyDB.Models
{
    public interface IApartmentRepository
    {
        public Task<IEnumerable<ApartmentModel>> GetApartmentsByHouseId(int houseId);
    }
}

namespace CompanyDB.Models
{
    public interface IHouseRepository
    {
        public Task<IEnumerable<HouseModel>> GetHousesByStreetId(int streetId);
    }
}

namespace CompanyDB.Models
{
    public interface IStreetRepository
    {
        public Task<IEnumerable<StreetModel>> GetStreetsByCityId(int cityId);
    }
}

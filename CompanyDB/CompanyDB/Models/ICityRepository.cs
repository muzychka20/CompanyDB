namespace CompanyDB.Models
{
    public interface ICityRepository
    {
        public Task<IEnumerable<CityModel>> GetCitiesByCountryId(int countryId);
    }
}

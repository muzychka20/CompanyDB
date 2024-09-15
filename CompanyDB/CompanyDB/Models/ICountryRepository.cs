namespace CompanyDB.Models
{
    public interface ICountryRepository
    {
        public Task<IEnumerable<CountryModel>> GetAllCountries();
    }
}

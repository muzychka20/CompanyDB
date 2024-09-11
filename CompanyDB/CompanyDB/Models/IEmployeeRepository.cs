namespace CompanyDB.Models
{
    public interface IEmployeeRepository
    {
        void AddEmployee(EmployeeModel employeeModel);
        void UpdateEmployee(EmployeeModel employeeModel);
        void DeleteEmployee(int id);
        IEnumerable<EmployeeModel> GetAllEmployees();
        Task<IEnumerable<string>> GetAllCountries();
        Task<IEnumerable<string>> GetCitiesByCountryName(string countryName);        
    }
}

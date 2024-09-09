namespace CompanyDB.Models
{
    public interface IEmployeeRepository
    {
        void AddEmployee(EmployeeModel employeeModel);
        void UpdateEmployee(EmployeeModel employeeModel);
        void DeleteEmployee(int id);
        IEnumerable<EmployeeModel> GetAllEmployees();        
    }
}

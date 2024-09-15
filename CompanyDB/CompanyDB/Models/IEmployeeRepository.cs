namespace CompanyDB.Models
{
    public interface IEmployeeRepository
    {
        public void AddEmployee(EmployeeModel employeeModel);
        public void DeleteEmployee(int id);
        public void UpdateEmployee(EmployeeModel employeeModel);
        public IEnumerable<EmployeeModel> GetAllEmployees();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyDB.Models
{
    public interface IEmployeeRepository
    {
        void AddEmployee(EmployeeModel employeeModel);
        void EditEmployee(EmployeeModel employeeModel);
        void DeleteEmployee(int id);
        IEnumerable<EmployeeModel> GetAllEmployees();        
    }
}

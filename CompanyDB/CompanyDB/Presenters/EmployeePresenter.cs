using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyDB.Models;
using CompanyDB.Views;

namespace CompanyDB.Presenters
{
    public class EmployeePresenter
    {
        // Fields
        private IEmployeeView view;
        private IEmployeeRepository repository;
        private BindingSource employeeBindingSource;
        private IEnumerable<EmployeeModel> employeeList;

        // Constructor
        public EmployeePresenter(IEmployeeView view, IEmployeeRepository repository)
        {
            this.employeeBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            
            // Subscrivbe event handler methods to view events            
            this.view.AddNewEvent += AddNewEmployee;
            this.view.EditEvent += LoadSelectedEmployeeToEdit;
            this.view.DeleteEvent += DeleteSelectedEmployee;
            this.view.SaveEvent += SaveEmployee;
            this.view.CancelEvent += CancelAction;
            
            this.view.ShowAllEvent += LoadAllEmployeeList;

            // Set employees binding source
            this.view.SetEmployeeListBindingSource(employeeBindingSource);

            // Load employee list view
            // LoadAllEmployeeList();

            // Show view
            this.view.Show();
        }

        // Methods
        // private void LoadAllEmployeeList()
        private void LoadAllEmployeeList(object? sender, EventArgs e)
        {
            employeeList = repository.GetAllEmployees();
            employeeBindingSource.DataSource = employeeList; // Set data source
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveEmployee(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedEmployee(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectedEmployeeToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewEmployee(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }        
    }
}

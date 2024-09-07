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
            
            // Show view
            this.view.Show();
        }

        // Methods        
        private void LoadAllEmployeeList(object? sender, EventArgs e)
        {
            employeeList = repository.GetAllEmployees();
            employeeBindingSource.DataSource = employeeList; // Set data source
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanviewFields();
        }

        private void SaveEmployee(object? sender, EventArgs e)
        {
            try
            {
                var model = new EmployeeModel();
                model.Id = Convert.ToInt32(view.Id);
                model.FirstName = view.FirstName;
                model.LastName = view.LastName;
                model.Position = view.Position; 
                model.Salary = (decimal)Convert.ToDouble(view.Salary);
                model.Location = Convert.ToInt32(view.Location);
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)
                {
                    repository.EditEmployee(model);
                    view.Message = "Employee edited successfully";
                }
                else
                {
                    repository.AddEmployee(model);
                    view.Message = "Employee added successfully";
                }
                view.IsSuccessful = true;
                LoadAllEmployeeList(this, EventArgs.Empty);
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            view.Id = "0";
            view.FirstName = "";
            view.LastName = "";
            view.Position = "";
            view.Salary = "0";
            view.Location = "0";
        }

        private void DeleteSelectedEmployee(object? sender, EventArgs e)
        {
            try
            {
                var employee = (EmployeeModel)employeeBindingSource.Current;
                repository.DeleteEmployee(employee.Id);
                view.IsSuccessful = true;
                view.Message = "Employee deleted succesfully";
                LoadAllEmployeeList(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete employee";
            }
        }

        private void LoadSelectedEmployeeToEdit(object? sender, EventArgs e)
        {
            var employee = (EmployeeModel)employeeBindingSource.Current;            
            view.Id =  employee.Id.ToString();
            view.FirstName = employee.FirstName;
            view.LastName = employee.LastName;
            view.Position = employee.Position;
            view.Salary = employee.Salary.ToString();
            view.Location = employee.Location.ToString();
            view.IsEdit = true;                        
        }

        private void AddNewEmployee(object? sender, EventArgs e)
        {
            view.IsEdit = false;            
        }        
    }
}

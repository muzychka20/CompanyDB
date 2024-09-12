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
            this.view.OnChangeCountry += OnChangeCountry;                                   

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

        // Load countries
        private async void LoadCountries()
        {
            var countries = await repository.GetAllCountries();
            view.CountryNameComboBox.DataSource = null;
            view.CountryNameComboBox.Items.Clear();
            view.CountryNameComboBox.Items.AddRange(countries.ToArray());            
        }

        // Load cities based on selected country
        private async void LoadCities(string countryName)
        {
            var cities = await repository.GetCitiesByCountryName(countryName);
            view.CityNameComboBox.DataSource = null;
            view.CityNameComboBox.Items.Clear();
            view.CityNameComboBox.Items.AddRange(cities.ToArray());            
        }

        private void OnChangeCountry()
        {            
            string selectedCountry = view.CountryName;
            LoadCities(selectedCountry);
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
                model.CountryName = view.CountryName;
                model.CityName = view.CityName;
                model.StreetName = view.StreetName;
                model.HouseNumber = view.HouseNumber;
                model.ApartmentNumber = view.ApartmentNumber;
                model.FloorNumber = view.FloorNumber;                
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)
                {
                    repository.UpdateEmployee(model);
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
            view.CountryName = "";
            view.CityName = "";
            view.StreetName = "";
            view.HouseNumber = "";
            view.ApartmentNumber = "";
            view.FloorNumber = "";
            view.CountryNameComboBox.DataSource = null;
            view.CountryNameComboBox.Items.Clear();
            view.CountryNameComboBox.SelectedIndex = -1;
            view.CountryNameComboBox.SelectedItem = null;
            view.CityNameComboBox.DataSource = null;
            view.CityNameComboBox.Items.Clear();
            view.CityNameComboBox.SelectedIndex = -1;
            view.CityNameComboBox.SelectedItem = null;
            view.CountryNameComboBox.Text = string.Empty;
            view.CityNameComboBox.Text = string.Empty;
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
                view.Message = "An error ocurred, could not delete employee" + ex.Message;
            }
        }

        private void LoadSelectedEmployeeToEdit(object? sender, EventArgs e)
        {
            var employee = (EmployeeModel)employeeBindingSource.Current;

            LoadCountries();
            view.CountryNameComboBox.SelectedItem = employee.CountryName;

            view.Id = employee.Id.ToString();
            view.FirstName = employee.FirstName;
            view.LastName = employee.LastName;
            view.Position = employee.Position;
            view.Salary = employee.Salary.ToString();
            view.StreetName = employee.StreetName;
            view.HouseNumber = employee.HouseNumber;
            view.ApartmentNumber = employee.ApartmentNumber;
            view.FloorNumber = employee.FloorNumber;
            view.IsEdit = true;
            
            LoadCities(employee.CountryName);
            view.CityNameComboBox.SelectedItem = employee.CityName;
        }

        private void AddNewEmployee(object? sender, EventArgs e)
        {
            view.IsEdit = false;            
            LoadCountries();            
        }        
    }
}

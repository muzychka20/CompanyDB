﻿using CompanyDB._Repositories;
using CompanyDB.Models;
using CompanyDB.Views;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CompanyDB.Presenters
{
    public class EmployeePresenter
    {
        // Fields
        private IEmployeeView view;
        private IEmployeeRepository employeeRepository;
        private ICountryRepository countryRepository;
        private ICityRepository cityRepository;
        private IStreetRepository streetRepository;
        private IHouseRepository houseRepository;
        private IApartmentRepository apartmentRepository;
        private BindingSource employeeBindingSource;
        private IEnumerable<EmployeeModel> employeeList;

        // Constructor
        public EmployeePresenter(IEmployeeView view,
            IEmployeeRepository employeeRepository, ICountryRepository countryRepository,
            ICityRepository cityRepository, IStreetRepository streetRepository,
            IHouseRepository houseRepository, IApartmentRepository apartmentRepository)
        {
            this.employeeBindingSource = new BindingSource();
            this.view = view;
            this.employeeRepository = employeeRepository;
            this.countryRepository = countryRepository;
            this.cityRepository = cityRepository;
            this.streetRepository = streetRepository;
            this.houseRepository = houseRepository;
            this.apartmentRepository = apartmentRepository;

            // Subscrivbe event handler methods to view events            
            this.view.AddNewEvent += AddNewEmployee;
            this.view.EditEvent += LoadSelectedEmployeeToEdit;
            this.view.DeleteEvent += DeleteSelectedEmployee;
            this.view.SaveEvent += SaveEmployee;
            this.view.CancelEvent += CancelAction;
            this.view.ShowAllEvent += LoadAllEmployeeList;
            this.view.OnChangeCountry += OnChangeCountry;
            this.view.OnChangeCity += OnChangeCity;
            this.view.OnChangeStreet += OnChangeStreet;
            this.view.OnChangeHouse += OnChangeHouse;
            this.view.OnChangeApartment += OnChangeApartment;
            this.view.OnClickCountry += OnClickCountry;
            this.view.OnClickCity += OnClickCity;
            this.view.OnClickStreet += OnClickStreet;
            this.view.OnClickHouse += OnClickHouse;

            // Set employees binding source
            this.view.SetEmployeeListBindingSource(employeeBindingSource);

            // Show view            
            this.view.Show();
        }

        private void OnClickHouse()
        {
            ClearComboBoxSelection(view.ApartmentComboBox);
            view.HouseNumber = "";
            view.ApartmentNumber = "";
        }

        private void OnClickStreet()
        {
            ClearComboBoxSelection(view.HouseComboBox);
            ClearComboBoxSelection(view.ApartmentComboBox);
            view.HouseComboBox.Enabled = false;
            view.ApartmentComboBox.Enabled = false;

            view.StreetName = "";
            view.HouseNumber = "";
            view.ApartmentNumber = "";
        }

        private void OnClickCity()
        {
            ClearComboBoxSelection(view.StreetNameComboBox);
            ClearComboBoxSelection(view.HouseComboBox);
            ClearComboBoxSelection(view.ApartmentComboBox);
            view.StreetNameComboBox.Enabled = false;
            view.HouseComboBox.Enabled = false;
            view.ApartmentComboBox.Enabled = false;

            view.CityName = "";
            view.StreetName = "";
            view.HouseNumber = "";
            view.ApartmentNumber = "";
        }

        private void OnClickCountry()
        {
            ClearComboBoxSelection(view.CityNameComboBox);
            ClearComboBoxSelection(view.StreetNameComboBox);
            ClearComboBoxSelection(view.HouseComboBox);
            ClearComboBoxSelection(view.ApartmentComboBox);
            view.CityNameComboBox.Enabled = false;
            view.StreetNameComboBox.Enabled = false;
            view.HouseComboBox.Enabled = false;
            view.ApartmentComboBox.Enabled = false;

            view.CountryName = "";
            view.CityName = "";
            view.StreetName = "";
            view.HouseNumber = "";
            view.ApartmentNumber = "";
        }

        // Methods
        private void LoadAllEmployeeList(object? sender, EventArgs e)
        {
            employeeList = employeeRepository.GetAllEmployees();
            employeeBindingSource.DataSource = employeeList; // Set data source           
        }

        // Load countries
        private async Task LoadCountries()
        {
            try
            {
                view.IsLoadingData = true;
                ClearComboBox(view.CountryNameComboBox);
                IEnumerable<CountryModel> countries = await countryRepository.GetAllCountries();
                view.CountryNameComboBox.DataSource = countries;
                view.CountryNameComboBox.DisplayMember = "CountryName";
                view.CountryNameComboBox.ValueMember = "CountryID";

                ClearComboBoxSelection(view.CountryNameComboBox);
            }
            finally
            {
                view.IsLoadingData = false;
            }
        }

        // Load cities based on selected country
        private async Task LoadCities(int countryId)
        {
            try
            {
                view.IsLoadingData = true;
                ClearComboBox(view.CityNameComboBox);
                IEnumerable<CityModel> cities = await cityRepository.GetCitiesByCountryId(countryId);
                view.CityNameComboBox.DataSource = cities;
                view.CityNameComboBox.DisplayMember = "CityName";
                view.CityNameComboBox.ValueMember = "CityID";
                ClearComboBoxSelection(view.CityNameComboBox);
            }
            finally
            {
                view.IsLoadingData = false;
            }
        }

        // Load streets based on selected city
        private async Task LoadStreets(int cityId)
        {

            try
            {
                view.IsLoadingData = true;
                ClearComboBox(view.StreetNameComboBox);
                IEnumerable<StreetModel> streets = await streetRepository.GetStreetsByCityId(cityId);
                view.StreetNameComboBox.DataSource = streets;
                view.StreetNameComboBox.DisplayMember = "StreetName";
                view.StreetNameComboBox.ValueMember = "StreetID";
                ClearComboBoxSelection(view.StreetNameComboBox);
            }
            finally
            {
                view.IsLoadingData = false;
            }
        }


        // Load houses based on selected street
        private async Task LoadHouses(int streetId)
        {
            try
            {
                view.IsLoadingData = true;
                ClearComboBox(view.HouseComboBox);
                IEnumerable<HouseModel> houses = await houseRepository.GetHousesByStreetId(streetId);
                view.HouseComboBox.DataSource = houses;
                view.HouseComboBox.DisplayMember = "HouseNumber";
                view.HouseComboBox.ValueMember = "HouseID";
                ClearComboBoxSelection(view.HouseComboBox);
            }
            finally
            {
                view.IsLoadingData = false;
            }
        }

        // Load apartments based on selected street
        private async Task LoadApartments(int houseId)
        {
            try
            {
                view.IsLoadingData = true;
                ClearComboBox(view.ApartmentComboBox);
                IEnumerable<ApartmentModel> apartments = await apartmentRepository.GetApartmentsByHouseId(houseId);
                view.ApartmentComboBox.DataSource = apartments;
                view.ApartmentComboBox.DisplayMember = "DisplayApartmentInfo";
                view.ApartmentComboBox.ValueMember = "ApartmentID";
                ClearComboBoxSelection(view.ApartmentComboBox);
            }
            finally
            {
                view.IsLoadingData = false;
            }
        }

        // Handle country change
        private async void OnChangeCountry()
        {
            if (view.IsLoadingData)
                return;

            view.IsLoadingData = true;
            try
            {
                if (view.CountryNameComboBox.SelectedItem is CountryModel selectedCountry)
                {
                    int selectedCountryId = selectedCountry.CountryID;
                    view.CountryName = selectedCountry.CountryName;
                    await LoadCities(selectedCountryId);
                    view.CityNameComboBox.Enabled = true;
                }
            }
            finally
            {
                view.IsLoadingData = false;
            }
        }

        // Handle city change
        private async void OnChangeCity()
        {
            if (view.IsLoadingData)
                return;

            view.IsLoadingData = true;
            try
            {
                if (view.CityNameComboBox.SelectedItem is CityModel selectedCity)
                {
                    int selectedCityId = selectedCity.CityID;
                    view.CityName = selectedCity.CityName;
                    await LoadStreets(selectedCityId);
                    view.StreetNameComboBox.Enabled = true;
                }
            }
            finally
            {
                view.IsLoadingData = false;
            }
        }

        // Handle street change
        private async void OnChangeStreet()
        {
            if (view.IsLoadingData)
                return;
            view.IsLoadingData = true;
            try
            {
                if (view.StreetNameComboBox.SelectedItem is StreetModel selectedStreet)
                {
                    int selectedStreetId = selectedStreet.StreetID;
                    view.StreetName = selectedStreet.StreetName;
                    await LoadHouses(selectedStreetId);
                    view.HouseComboBox.Enabled = true;
                }
            }
            finally 
            {
                view.IsLoadingData = false;  
            }
        }

        // Handle house change
        private async void OnChangeHouse()
        {
            if (view.IsLoadingData)
                return;
            
            view.IsLoadingData = true;
            try
            {
                if (view.HouseComboBox.SelectedItem is HouseModel selectedHouse)
                {
                    int selectedHouseId = selectedHouse.HouseID;
                    view.HouseNumber = selectedHouse.HouseNumber;
                    await LoadApartments(selectedHouseId);
                    view.ApartmentComboBox.Enabled = true;
                }
            }
            finally
            {
                view.IsLoadingData = false;
            }
        }

        // Handle apartment change
        private void OnChangeApartment()
        {
            if (view.IsLoadingData)
                return;

            view.IsLoadingData = true;
            try
            {
                if (view.ApartmentComboBox.SelectedItem is ApartmentModel selectedApartment)
                {
                    int selectedApartmentId = selectedApartment.ApartmentID;
                    var apartmentDetails = ParseApartmentDetails(view.ApartmentNumber);
                    view.ApartmentID = selectedApartmentId.ToString();
                    view.ApartmentNumber = selectedApartment.ApartmentNumber;
                }
            }
            finally
            {
                view.IsLoadingData = false;
            }
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanviewFields();
        }

        private void SaveEmployee(object? sender, EventArgs e)
        {
            try
            {
                var model = new EmployeeModel()
                {
                    EmployeeID = Convert.ToInt32(view.Id),
                    EmployeeFirstName = view.FirstName,
                    EmployeeLastName = view.LastName,
                    EmployeePosition = view.Position,
                    EmployeeSalary = (decimal)Convert.ToDouble(view.Salary),
                    EmployeeCountryName = view.CountryName,
                    EmployeeCityName = view.CityName,
                    EmployeeStreetName = view.StreetName,
                    EmployeeHouseNumber = view.HouseNumber,
                    EmployeeApartmentID = Convert.ToInt32(view.ApartmentID),
                    EmployeeApartmentNumber = view.ApartmentNumber,
                };
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)
                {
                    employeeRepository.UpdateEmployee(model);
                    view.Message = "Employee edited successfully";
                }
                else
                {
                    employeeRepository.AddEmployee(model);
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

        private (string ApartmentNumber, string FloorNumber) ParseApartmentDetails(string apartmentDetail)
        {
            string apartmentNumber = "";
            string floorNumber = "";

            // Regular expression to match the pattern "532VB (Floor: 7a)"
            var match = Regex.Match(apartmentDetail, @"([A-Za-z0-9]+)\s*\(Floor:\s*([A-Za-z0-9]+)\)");

            if (match.Success)
            {
                apartmentNumber = match.Groups[1].Value;
                floorNumber = match.Groups[2].Value;
            }

            return (apartmentNumber, floorNumber);
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
            ClearComboBox(view.CountryNameComboBox);
            ClearComboBox(view.CityNameComboBox);
            ClearComboBox(view.StreetNameComboBox);
            ClearComboBox(view.HouseComboBox);
            ClearComboBox(view.ApartmentComboBox);
            view.CityNameComboBox.Enabled = false;
            view.StreetNameComboBox.Enabled = false;
            view.HouseComboBox.Enabled = false;
            view.ApartmentComboBox.Enabled = false;
        }

        // Clear list of options in ComboBox
        private void ClearComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = null;
            comboBox.Items.Clear();
            comboBox.SelectedIndex = -1;
            comboBox.SelectedItem = null;
            comboBox.Text = string.Empty;
        }

        // Clear the selection for ComboBox
        private void ClearComboBoxSelection(ComboBox comboBox)
        {
            comboBox.SelectedIndex = -1;
            comboBox.SelectedItem = null;
            comboBox.Text = string.Empty;
        }

        // Set the selection for ComboBox
        private void SetComboBoxSelection(ComboBox comboBox, object selectedValue, string displayText)
        {
            comboBox.SelectedValue = selectedValue;
            comboBox.Text = displayText;

        }

        private void DeleteSelectedEmployee(object? sender, EventArgs e)
        {
            try
            {
                var employee = (EmployeeModel)employeeBindingSource.Current;
                employeeRepository.DeleteEmployee(employee.EmployeeID);
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

        private async void LoadSelectedEmployeeToEdit(object? sender, EventArgs e)
        {
            try
            {
                // Get the selected employee from the binding source
                var employee = (EmployeeModel)employeeBindingSource.Current;

                view.Id = employee.EmployeeID.ToString();
                view.FirstName = employee.EmployeeFirstName;
                view.LastName = employee.EmployeeLastName;
                view.Position = employee.EmployeePosition;
                view.Salary = employee.EmployeeSalary.ToString();
                view.CountryName = employee.EmployeeCountryName;
                view.CityName = employee.EmployeeCityName;
                view.StreetName = employee.EmployeeStreetName;
                view.HouseNumber = employee.EmployeeHouseNumber;
                view.ApartmentID = employee.EmployeeApartmentID.ToString();
                view.ApartmentNumber = employee.EmployeeApartmentNumber;
                view.FloorNumber = employee.EmployeeFloorNumber;

                if (await GetLocation(employee))
                {
                    Console.WriteLine(employee.EmployeeCountryName);
                    Console.WriteLine(employee.EmployeeCityName);
                    Console.WriteLine(employee.EmployeeStreetName);
                    Console.WriteLine(employee.EmployeeHouseNumber);
                    Console.WriteLine(employee.EmployeeApartmentNumber);

                    view.CityNameComboBox.Enabled = true;
                    view.CityNameComboBox.Enabled = true;
                    view.StreetNameComboBox.Enabled = true;
                    view.HouseComboBox.Enabled = true;
                    view.ApartmentComboBox.Enabled = true;

                    view.IsEdit = true;

                    SetComboBoxSelection(view.CountryNameComboBox, employee.EmployeeCountryID, employee.EmployeeCountryName);
                    SetComboBoxSelection(view.CityNameComboBox, employee.EmployeeCityID, employee.EmployeeCityName);
                    SetComboBoxSelection(view.StreetNameComboBox, employee.EmployeeStreetID, employee.EmployeeStreetName);
                    SetComboBoxSelection(view.HouseComboBox, employee.EmployeeHouseID, employee.EmployeeHouseNumber);
                    SetComboBoxSelection(view.ApartmentComboBox, employee.EmployeeApartmentID, employee.EmployeeApartmentNumber);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while loading the employee details: {ex.Message}");
            }
        }

        private async Task<bool> GetLocation(EmployeeModel employee)
        {
            await LoadCountries();
            SetComboBoxSelection(view.CountryNameComboBox, employee.EmployeeCountryID, employee.EmployeeCountryName);

            await LoadCities(employee.EmployeeCountryID);
            SetComboBoxSelection(view.CityNameComboBox, employee.EmployeeCityID, employee.EmployeeCityName);

            await LoadStreets(employee.EmployeeCityID);
            SetComboBoxSelection(view.StreetNameComboBox, employee.EmployeeStreetID, employee.EmployeeStreetName);

            await LoadHouses(employee.EmployeeStreetID);
            SetComboBoxSelection(view.HouseComboBox, employee.EmployeeHouseID, employee.EmployeeHouseNumber);

            await LoadApartments(employee.EmployeeHouseID);
            SetComboBoxSelection(view.ApartmentComboBox, employee.EmployeeApartmentID, employee.EmployeeApartmentNumber);

            return true;
        }

        private async void AddNewEmployee(object? sender, EventArgs e)
        {
            view.IsEdit = false;
            await LoadCountries();
            ClearComboBoxSelection(view.CountryNameComboBox);
            view.CityNameComboBox.Enabled = false;
            view.StreetNameComboBox.Enabled = false;
            view.HouseComboBox.Enabled = false;
            view.ApartmentComboBox.Enabled = false;
        }
    }
}

namespace CompanyDB.Views
{
    public interface IEmployeeView
    {
        // Properties - Fields
        string Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Position { get; set; }
        string Salary { get; set; }
        string ApartmentID { get; set; }
        string CountryName
        {
            get => CountryNameComboBox.SelectedItem?.ToString() ?? string.Empty;
            set
            {
                if (CountryNameComboBox.Items.Contains(value))
                    CountryNameComboBox.SelectedItem = value;
            }
        }
        string CityName
        {
            get => CityNameComboBox.SelectedItem?.ToString() ?? string.Empty;
            set
            {
                if (CityNameComboBox.Items.Contains(value))
                    CityNameComboBox.SelectedItem = value;
            }
        }
        string StreetName
        {
            get => StreetNameComboBox.SelectedItem?.ToString() ?? string.Empty;
            set
            {
                if (StreetNameComboBox.Items.Contains(value))
                    StreetNameComboBox.SelectedItem = value;
            }
        }
        string HouseNumber
        {
            get => HouseComboBox.SelectedItem?.ToString() ?? string.Empty;
            set
            {
                if (HouseComboBox.Items.Contains(value))
                    HouseComboBox.SelectedItem = value;
            }
        }
        string ApartmentNumber
        {
            get => ApartmentComboBox.SelectedItem?.ToString() ?? string.Empty;
            set
            {
                if (ApartmentComboBox.Items.Contains(value))
                    ApartmentComboBox.SelectedItem = value;
            }
        }
        string FloorNumber { get; set; }

        ComboBox CountryNameComboBox { get; set; }
        ComboBox CityNameComboBox { get; set; }
        ComboBox StreetNameComboBox { get; set; }
        ComboBox HouseComboBox { get; set; }
        ComboBox ApartmentComboBox { get; set; }

        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }
        bool IsLoadingData { get; set; }

        // Events        
        event EventHandler ShowAllEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        event Action OnChangeCountry;
        event Action OnChangeCity;
        event Action OnChangeStreet;
        event Action OnChangeHouse;
        event Action OnChangeApartment;
        event Action OnClickCountry;
        event Action OnClickCity;
        event Action OnClickStreet;
        event Action OnClickHouse;        

        // Methods
        void SetEmployeeListBindingSource(BindingSource employeeList);
        void Show();
    }
}
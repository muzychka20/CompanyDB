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
        string CountryName { get; set; }
        ComboBox CountryNameComboBox { get; set; }
        string CityName { get; set; }
        ComboBox CityNameComboBox { get; set; }
        string StreetName { get; set; }
        string HouseNumber { get; set; }
        string FloorNumber { get; set; }
        string ApartmentNumber { get; set; }

        bool IsEdit {  get; set; } 
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        // Events        
        event EventHandler ShowAllEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;        
        event Action OnChangeCountry;

        // Methods
        void SetEmployeeListBindingSource(BindingSource employeeList);
        void Show();
    }
}
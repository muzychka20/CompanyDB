using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.VisualBasic.Devices;

namespace CompanyDB.Models
{
    public class EmployeeModel
    {
        // Fields 
        protected int id;
        protected string firstName;
        protected string lastName;
        protected string position;
        protected decimal salary;
        protected CountryModel country;
        protected CityModel city;
        protected StreetModel street;
        protected HouseModel house;
        protected ApartmentModel apartment;

        // Constructor
        public EmployeeModel()
        {
            country = new CountryModel();
            city = new CityModel();
            street = new StreetModel();
            house = new HouseModel();
            apartment = new ApartmentModel();
        }

        // Properties - Validation
        [DisplayName("Id")]
        public int EmployeeID { get => id; set => id = value; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name is required!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "First Name must be between 3 and 50 characters!")]
        public string EmployeeFirstName { get => firstName; set => firstName = value; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is required!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Last Name must be between 3 and 50 characters!")]
        public string EmployeeLastName { get => lastName; set => lastName = value; }

        [DisplayName("Position")]
        [Required(ErrorMessage = "Position is required!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Position must be between 3 and 50 characters!")]
        public string EmployeePosition { get => position; set => position = value; }

        [DisplayName("Salary")]
        [Required(ErrorMessage = "Salary is required!")]
        [RegularExpression(@"^\d{1,16}(\.\d{0,2})?$", ErrorMessage = "Salary must be a valid decimal!")]
        public decimal EmployeeSalary { get => salary; set => salary = value; }

        [DisplayName("Country")]
        public string EmployeeCountryName
        {
            get => country.CountryName;
            set
            {
                country.CountryName = value;
            }
        }

        [DisplayName("City")]
        public string EmployeeCityName
        {
            get => city.CityName;
            set => city.CityName = value;
        }

        [DisplayName("Street")]
        public string EmployeeStreetName
        {
            get => street.StreetName;
            set => street.StreetName = value;
        }

        [DisplayName("House")]
        public string EmployeeHouseNumber
        {
            get => house.HouseNumber;
            set => house.HouseNumber = value;
        }

        [DisplayName("Floor")]
        public string EmployeeFloorNumber
        {
            get => apartment.ApartmentFloorNumber;
            set => apartment.ApartmentFloorNumber = value;
        }

        [DisplayName("Apartment")]
        public string EmployeeApartmentNumber
        {
            get => apartment.ApartmentNumber;
            set => apartment.ApartmentNumber = value;
        }

        // CountryID won't be displayed
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int EmployeeCountryID { get => country.CountryID; set => country.CountryID = value; }

        // CityID won't be displayed
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int EmployeeCityID { get => city.CityID; set => city.CityID = value; }

        // StreetID won't be displayed
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int EmployeeStreetID { get => street.StreetID; set => street.StreetID = value; }

        // HouseID won't be displayed
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int EmployeeHouseID { get => house.HouseID; set => house.HouseID = value; }

        // ApartmentID won't be displayed
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int EmployeeApartmentID { get => apartment.ApartmentID; set => apartment.ApartmentID = value; }
    }
}
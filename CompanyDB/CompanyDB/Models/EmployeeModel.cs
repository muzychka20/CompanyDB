using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CompanyDB.Models
{
    public class EmployeeModel
    {
        // Fields 
        private int id;
        private string firstName;
        private string lastName;
        private string position;
        private decimal salary;
        
        // Address
        private string countryName;
        private string cityName;
        private string streetName;
        private string houseNumber;
        private string floorNumber;
        private string apartmentNumber;


        // Properties - Validation
        [DisplayName("Id")]
        public int Id { get => id; set => id = value; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name is required!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "First Name must be between 3 and 50 characters!")]
        public string FirstName { get => firstName; set => firstName = value; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is required!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Last Name must be between 3 and 50 characters!")]
        public string LastName { get => lastName; set => lastName = value; }

        [DisplayName("Position")]
        [Required(ErrorMessage = "Position is required!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Position must be between 3 and 50 characters!")]
        public string Position { get => position; set => position = value; }

        [DisplayName("Salary")]
        [Required(ErrorMessage = "Salary is required!")]
        [RegularExpression(@"^\d{1,16}(\.\d{0,2})?$", ErrorMessage = "Salary must be a valid decimal!")]
        public decimal Salary { get => salary; set => salary = value; }

        [DisplayName("Country")]
        [Required(ErrorMessage = "Country is required!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Country must be between 3 and 50 characters!")]
        public string CountryName { get => countryName; set => countryName = value; }

        [DisplayName("City")]
        [Required(ErrorMessage = "City is required!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "City must be between 3 and 50 characters!")]
        public string CityName { get => cityName; set => cityName = value; }

        [DisplayName("Street")]
        [Required(ErrorMessage = "Street is required!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Street must be between 3 and 50 characters!")]
        public string StreetName { get => streetName; set => streetName = value; }

        [DisplayName("House Number")]
        [Required(ErrorMessage = "House Number is required!")]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "Street must be between 1 and 10 characters!")]
        public string HouseNumber { get => houseNumber; set => houseNumber = value; }

        [DisplayName("Floor Number")]
        [Required(ErrorMessage = "Floor Number is required!")]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "Floor must be between 1 and 10 characters!")]
        public string FloorNumber { get => floorNumber; set => floorNumber = value; }

        [DisplayName("Apartment Number")]
        [Required(ErrorMessage = "Apartment Number is required!")]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "Apartment must be between 1 and 10 characters!")]
        public string ApartmentNumber { get => apartmentNumber; set => apartmentNumber = value; }
    }
}

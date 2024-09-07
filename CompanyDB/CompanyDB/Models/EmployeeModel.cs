using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private int location;

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

        [DisplayName("Location")]
        [Required(ErrorMessage = "Location is required!")]
        public int Location { get => location; set => location = value; }

    }
}

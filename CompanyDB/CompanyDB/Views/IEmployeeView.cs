using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        string Location { get; set; }
        
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

        // Methods
        void SetEmployeeListBindingSource(BindingSource employeeList);
        void Show();
    }
}
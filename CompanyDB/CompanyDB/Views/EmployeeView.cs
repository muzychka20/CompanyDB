using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyDB.Views
{
    public partial class EmployeeView : Form, IEmployeeView
    {
        // Fields      
        private string message;
        private bool isSuccessful;
        private bool isEdit;        

        // Constructor
        public EmployeeView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl.TabPages.Remove(employeeDetailTab);          
            this.Load += delegate { ShowAllEvent?.Invoke(this, EventArgs.Empty); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            exitToolStripMenuItem.Click += delegate { this.Close(); };
            getAllToolStripMenuItem.Click += delegate { ShowAllEvent?.Invoke(this, EventArgs.Empty); };
        }

        // Properties
        public int Id 
        { 
            get => int.Parse(txtId.Text);
            set => txtId.Text = value.ToString();
        }
        public string FirstName 
        {
            get => txtFirstName.Text;
            set => txtFirstName.Text = value;
        }
        public string LastName 
        {
            get => txtLastName.Text;
            set => txtLastName.Text = value;
        }
        public string Position 
        {
            get => txtPosition.Text;
            set => txtPosition.Text = value;
        }
        public float Salary 
        {
            get => float.Parse(txtSalary.Text);
            set => txtSalary.Text = value.ToString();
        }
        public bool IsEdit 
        {
            get => isEdit;
            set => isEdit = value;
        }
        public bool IsSuccessful
        {
            get => isSuccessful;
            set => isSuccessful = value;
        }
        public string Message
        {
            get => message;
            set => message = value;
        }
        int IEmployeeView.Location
        {
            get => int.Parse(txtLocation.Text);
            set => txtLocation.Text = value.ToString();
        }

        // Events        
        public event EventHandler ShowAllEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        // Methods
        public void SetEmployeeListBindingSource(BindingSource employeeList)
        {
            dataGridView.DataSource = employeeList;
        }

        // Singleton pattern (Open a single form instance)
        private static EmployeeView instance;
        public static EmployeeView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new EmployeeView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }
    }
}

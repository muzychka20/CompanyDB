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
        }

        private void AssociateAndRaiseViewEvents()
        {
            // Load
            this.Load += delegate { ShowAllEvent?.Invoke(this, EventArgs.Empty); };

            // Exit
            exitToolStripMenuItem.Click += delegate { this.Close(); };

            // Get all
            getAllToolStripMenuItem.Click += delegate { ShowAllEvent?.Invoke(this, EventArgs.Empty); };

            // Add new
            newToolStripMenuItem.Click += delegate
            {
                employeeToolStripMenuItem.Enabled = false;
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl.TabPages.Remove(employeesListTab);
                tabControl.TabPages.Add(employeeDetailTab);
                employeeDetailTab.Text = "Add new employee";
            };

            // Edit
            editToolStripMenuItem.Click += delegate
            {
                employeeToolStripMenuItem.Enabled = false;
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl.TabPages.Remove(employeesListTab);
                tabControl.TabPages.Add(employeeDetailTab);
                employeeDetailTab.Text = "Edit employee";
            };

            // Delete
            deleteToolStripMenuItem.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected employee?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            // Cancel
            btnCancel.Click += delegate
            {
                tabControl.TabPages.Remove(employeeDetailTab);
                tabControl.TabPages.Add(employeesListTab);
                CancelEvent?.Invoke(this, EventArgs.Empty);
                employeeToolStripMenuItem.Enabled = true;
            };

            // Save changes
            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl.TabPages.Remove(employeeDetailTab);
                    tabControl.TabPages.Add(employeesListTab);
                    employeeToolStripMenuItem.Enabled = true;
                }
                MessageBox.Show(Message);
            };

            // Select country
            comboBoxCountry.SelectedIndexChanged += delegate
            {
                if (comboBoxCountry.SelectedItem != null)
                {
                    if (comboBoxCountry.SelectedItem.ToString() == "Other")
                    {
                        txtCountryName.Visible = true;
                        txtCountryName.Text = string.Empty;
                        labelCountry.Visible = true;
                        labelComboCity.Visible = false;
                        comboBoxCity.DataSource = null;
                        comboBoxCity.Visible = false;
                        labelCity.Visible = true;
                        txtCityName.Visible = true;
                    }
                    else
                    {
                        txtCountryName.Visible = false;
                        labelCountry.Visible = false;
                        labelComboCity.Visible = true;
                        comboBoxCity.Visible = true;
                        labelCity.Visible = false;
                        txtCityName.Visible = false;                        
                        OnChangeCountry?.Invoke();
                    }
                }
            };

            // Select city
            comboBoxCity.SelectedIndexChanged += delegate
            {
                if (comboBoxCity.SelectedItem != null)
                {
                    if (comboBoxCity.SelectedItem.ToString() == "Other")
                    {
                        labelCity.Visible = true;
                        txtCityName.Visible = true;
                    }
                    else
                    {
                        labelCity.Visible = false;
                        txtCityName.Visible = false;
                    }
                }
            };
        }

        // Properties
        public string Id
        {
            get => txtId.Text;
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
        public string Salary
        {
            get => txtSalary.Text;
            set => txtSalary.Text = value.ToString();
        }

        public string CountryName
        {
            get
            {
                if (comboBoxCountry.SelectedItem?.ToString() == "Other")
                {
                    return txtCountryName.Text;
                }
                return comboBoxCountry.SelectedItem?.ToString();
            }
            set
            {
                if (comboBoxCountry.SelectedItem?.ToString() == "Other")
                {
                    comboBoxCountry.SelectedItem = txtCountryName.Text;
                }
                else
                {
                    comboBoxCountry.SelectedItem = value;
                }
            }
        }

        public string CityName
        {
            get
            {
                if (comboBoxCity.SelectedItem?.ToString() == "Other" || comboBoxCountry.SelectedItem?.ToString() == "Other")
                {
                    return txtCityName.Text;
                }
                return comboBoxCity.SelectedItem?.ToString();
            }
            set
            {
                comboBoxCity.SelectedItem = value;
            }
        }

        public string StreetName
        {
            get => txtStreetName.Text;
            set => txtStreetName.Text = value;
        }

        public string HouseNumber
        {
            get => txtHouseNumber.Text;
            set => txtHouseNumber.Text = value;
        }
        public string FloorNumber
        {
            get => txtFloorNumber.Text;
            set => txtFloorNumber.Text = value;
        }

        public string ApartmentNumber
        {
            get => txtApartmentNumber.Text;
            set => txtApartmentNumber.Text = value;
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
        ComboBox IEmployeeView.CountryNameComboBox
        {
            get => comboBoxCountry;
            set => comboBoxCountry = value;
        }

        ComboBox IEmployeeView.CityNameComboBox
        {
            get => comboBoxCity;
            set => comboBoxCity = value;
        }

        // Events        
        public event EventHandler ShowAllEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;        
        public event Action OnChangeCountry;

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

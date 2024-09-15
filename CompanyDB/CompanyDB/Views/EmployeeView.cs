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
            comboBoxCountry.SelectedIndexChanged += (sender, e) =>
            {
                if (comboBoxCountry.SelectedItem != null)
                {
                    OnChangeCountry?.Invoke();
                }
            };

            // Select city
            comboBoxCity.SelectedIndexChanged += (sender, e) =>
            {
                if (comboBoxCity.SelectedItem != null)
                {
                    OnChangeCity?.Invoke();
                }
            };

            // Select street
            comboBoxStreet.SelectedIndexChanged += (sender, e) =>
            {
                if (comboBoxStreet.SelectedItem != null)
                {
                    OnChangeStreet?.Invoke();
                }
            };

            // Select house
            comboBoxHouse.SelectedIndexChanged += (sender, e) =>
            {
                if (comboBoxHouse.SelectedItem != null)
                {
                    OnChangeHouse?.Invoke();
                }
            };

            // Select apartment
            comboBoxApartment.SelectedIndexChanged += (sender, e) =>
            {
                if (comboBoxApartment.SelectedItem != null)
                {
                    OnChangeApartment?.Invoke();
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
        public string ApartmentID { get; set; }
        public string CountryName
        {
            get => comboBoxCountry.SelectedItem?.ToString() ?? string.Empty;
            set
            {
                if (comboBoxCountry.Items.Contains(value))
                    comboBoxCountry.SelectedItem = value;
            }
        }
        public string CityName
        {
            get => comboBoxCity.SelectedItem?.ToString() ?? string.Empty;
            set
            {
                if (comboBoxCity.Items.Contains(value))
                    comboBoxCity.SelectedItem = value;
            }
        }
        public string StreetName
        {
            get => comboBoxStreet.SelectedItem?.ToString() ?? string.Empty;
            set
            {
                if (comboBoxStreet.Items.Contains(value))
                    comboBoxStreet.SelectedItem = value;
            }
        }
        public string HouseNumber
        {
            get => comboBoxHouse.SelectedItem?.ToString() ?? string.Empty;
            set
            {
                if (comboBoxHouse.Items.Contains(value))
                    comboBoxHouse.SelectedItem = value;
            }
        }
        public string ApartmentNumber
        {
            get => comboBoxApartment.SelectedItem?.ToString() ?? string.Empty;
            set
            {
                if (comboBoxApartment.Items.Contains(value))
                    comboBoxApartment.SelectedItem = value;
            }
        }
        public string FloorNumber { get; set; }
        public ComboBox CountryNameComboBox
        {
            get => comboBoxCountry;
            set => comboBoxCountry = value;
        }
        public ComboBox CityNameComboBox
        {
            get => comboBoxCity;
            set => comboBoxCity = value;
        }
        public ComboBox StreetNameComboBox
        {
            get => comboBoxStreet;
            set => comboBoxStreet = value;
        }
        public ComboBox HouseComboBox
        {
            get => comboBoxHouse;
            set => comboBoxHouse = value;
        }
        public ComboBox ApartmentComboBox
        {
            get => comboBoxApartment;
            set => comboBoxApartment = value;
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

        // Events        
        public event EventHandler ShowAllEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event Action OnChangeCountry;
        public event Action OnChangeCity;
        public event Action OnChangeStreet;
        public event Action OnChangeHouse;
        public event Action OnChangeApartment;

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

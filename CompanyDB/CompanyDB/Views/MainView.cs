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
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            btnEmployees.Click += delegate { ShowEmployeeView?.Invoke(this, EventArgs.Empty); };
            btnExit.Click += delegate { this.Close(); };
            this.BackColor = Color.LightBlue; // Вы можете использовать любой цвет по вашему выбору
            this.BackColor = Color.LightSteelBlue;

        }

        public event EventHandler ShowEmployeeView;        
    }
}

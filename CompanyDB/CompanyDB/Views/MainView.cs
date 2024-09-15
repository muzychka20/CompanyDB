using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
namespace CompanyDB.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            btnEmployees.Click += delegate { ShowEmployeeView?.Invoke(this, EventArgs.Empty); };
            btnExit.Click += delegate { this.Close(); };
        }

        public event EventHandler ShowEmployeeView;
    }
}

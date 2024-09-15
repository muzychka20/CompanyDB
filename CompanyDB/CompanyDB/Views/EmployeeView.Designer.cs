namespace CompanyDB.Views
{
    partial class EmployeeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tabControl = new TabControl();
            employeesListTab = new TabPage();
            dataGridView = new DataGridView();
            employeeDetailTab = new TabPage();
            comboBoxApartment = new ComboBox();
            comboBoxHouse = new ComboBox();
            comboBoxStreet = new ComboBox();
            labelComboHouse = new Label();
            labelComboStreet = new Label();
            labelComboCity = new Label();
            comboBoxCity = new ComboBox();
            labelComboCountry = new Label();
            comboBoxCountry = new ComboBox();
            labelApartmentNumber = new Label();
            txtSalary = new NumericUpDown();
            btnCancel = new Button();
            btnSave = new Button();
            txtPosition = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtId = new TextBox();
            salaryLabel = new Label();
            positionLabel = new Label();
            lastNameLabel = new Label();
            firstNameLabel = new Label();
            idLabel = new Label();
            mainMenu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            employeeToolStripMenuItem = new ToolStripMenuItem();
            getAllToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            panel = new Panel();
            tabControl.SuspendLayout();
            employeesListTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            employeeDetailTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtSalary).BeginInit();
            mainMenu.SuspendLayout();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(employeesListTab);
            tabControl.Controls.Add(employeeDetailTab);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 31);
            tabControl.Margin = new Padding(4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1229, 373);
            tabControl.TabIndex = 2;
            // 
            // employeesListTab
            // 
            employeesListTab.Controls.Add(dataGridView);
            employeesListTab.Location = new Point(4, 37);
            employeesListTab.Margin = new Padding(4);
            employeesListTab.Name = "employeesListTab";
            employeesListTab.Padding = new Padding(4);
            employeesListTab.Size = new Size(1221, 332);
            employeesListTab.TabIndex = 0;
            employeesListTab.Text = "Employees list";
            employeesListTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = SystemColors.Control;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkCyan;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Location = new Point(4, 4);
            dataGridView.Margin = new Padding(4);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1213, 324);
            dataGridView.TabIndex = 0;
            // 
            // employeeDetailTab
            // 
            employeeDetailTab.Controls.Add(comboBoxApartment);
            employeeDetailTab.Controls.Add(comboBoxHouse);
            employeeDetailTab.Controls.Add(comboBoxStreet);
            employeeDetailTab.Controls.Add(labelComboHouse);
            employeeDetailTab.Controls.Add(labelComboStreet);
            employeeDetailTab.Controls.Add(labelComboCity);
            employeeDetailTab.Controls.Add(comboBoxCity);
            employeeDetailTab.Controls.Add(labelComboCountry);
            employeeDetailTab.Controls.Add(comboBoxCountry);
            employeeDetailTab.Controls.Add(labelApartmentNumber);
            employeeDetailTab.Controls.Add(txtSalary);
            employeeDetailTab.Controls.Add(btnCancel);
            employeeDetailTab.Controls.Add(btnSave);
            employeeDetailTab.Controls.Add(txtPosition);
            employeeDetailTab.Controls.Add(txtLastName);
            employeeDetailTab.Controls.Add(txtFirstName);
            employeeDetailTab.Controls.Add(txtId);
            employeeDetailTab.Controls.Add(salaryLabel);
            employeeDetailTab.Controls.Add(positionLabel);
            employeeDetailTab.Controls.Add(lastNameLabel);
            employeeDetailTab.Controls.Add(firstNameLabel);
            employeeDetailTab.Controls.Add(idLabel);
            employeeDetailTab.Location = new Point(4, 37);
            employeeDetailTab.Margin = new Padding(4);
            employeeDetailTab.Name = "employeeDetailTab";
            employeeDetailTab.Padding = new Padding(4);
            employeeDetailTab.Size = new Size(1221, 332);
            employeeDetailTab.TabIndex = 1;
            employeeDetailTab.Text = "Employee detail";
            employeeDetailTab.UseVisualStyleBackColor = true;
            // 
            // comboBoxApartment
            // 
            comboBoxApartment.FormattingEnabled = true;
            comboBoxApartment.Location = new Point(100, 251);
            comboBoxApartment.Name = "comboBoxApartment";
            comboBoxApartment.Size = new Size(230, 36);
            comboBoxApartment.TabIndex = 35;
            // 
            // comboBoxHouse
            // 
            comboBoxHouse.FormattingEnabled = true;
            comboBoxHouse.Location = new Point(869, 146);
            comboBoxHouse.Name = "comboBoxHouse";
            comboBoxHouse.Size = new Size(230, 36);
            comboBoxHouse.TabIndex = 33;
            // 
            // comboBoxStreet
            // 
            comboBoxStreet.FormattingEnabled = true;
            comboBoxStreet.Location = new Point(614, 146);
            comboBoxStreet.Name = "comboBoxStreet";
            comboBoxStreet.Size = new Size(230, 36);
            comboBoxStreet.TabIndex = 32;
            // 
            // labelComboHouse
            // 
            labelComboHouse.AutoSize = true;
            labelComboHouse.Location = new Point(869, 114);
            labelComboHouse.Margin = new Padding(4, 0, 4, 0);
            labelComboHouse.Name = "labelComboHouse";
            labelComboHouse.Size = new Size(144, 28);
            labelComboHouse.TabIndex = 31;
            labelComboHouse.Text = "House Number";
            // 
            // labelComboStreet
            // 
            labelComboStreet.AutoSize = true;
            labelComboStreet.Location = new Point(614, 114);
            labelComboStreet.Margin = new Padding(4, 0, 4, 0);
            labelComboStreet.Name = "labelComboStreet";
            labelComboStreet.Size = new Size(63, 28);
            labelComboStreet.TabIndex = 30;
            labelComboStreet.Text = "Street";
            // 
            // labelComboCity
            // 
            labelComboCity.AutoSize = true;
            labelComboCity.Location = new Point(358, 114);
            labelComboCity.Margin = new Padding(4, 0, 4, 0);
            labelComboCity.Name = "labelComboCity";
            labelComboCity.Size = new Size(46, 28);
            labelComboCity.TabIndex = 29;
            labelComboCity.Text = "City";
            // 
            // comboBoxCity
            // 
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Location = new Point(358, 146);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(230, 36);
            comboBoxCity.TabIndex = 28;
            // 
            // labelComboCountry
            // 
            labelComboCountry.AutoSize = true;
            labelComboCountry.Location = new Point(100, 114);
            labelComboCountry.Margin = new Padding(4, 0, 4, 0);
            labelComboCountry.Name = "labelComboCountry";
            labelComboCountry.Size = new Size(82, 28);
            labelComboCountry.TabIndex = 27;
            labelComboCountry.Text = "Country";
            // 
            // comboBoxCountry
            // 
            comboBoxCountry.FormattingEnabled = true;
            comboBoxCountry.Location = new Point(100, 146);
            comboBoxCountry.Name = "comboBoxCountry";
            comboBoxCountry.Size = new Size(230, 36);
            comboBoxCountry.TabIndex = 26;
            // 
            // labelApartmentNumber
            // 
            labelApartmentNumber.AutoSize = true;
            labelApartmentNumber.Location = new Point(100, 215);
            labelApartmentNumber.Margin = new Padding(4, 0, 4, 0);
            labelApartmentNumber.Name = "labelApartmentNumber";
            labelApartmentNumber.Size = new Size(183, 28);
            labelApartmentNumber.TabIndex = 24;
            labelApartmentNumber.Text = "Apartment Number";
            // 
            // txtSalary
            // 
            txtSalary.DecimalPlaces = 2;
            txtSalary.Location = new Point(358, 253);
            txtSalary.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(230, 34);
            txtSalary.TabIndex = 13;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(809, 248);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 39);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(957, 248);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(142, 39);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(869, 62);
            txtPosition.Margin = new Padding(4);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(230, 34);
            txtPosition.TabIndex = 8;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(614, 62);
            txtLastName.Margin = new Padding(4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(230, 34);
            txtLastName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(358, 62);
            txtFirstName.Margin = new Padding(4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(230, 34);
            txtFirstName.TabIndex = 6;
            // 
            // txtId
            // 
            txtId.Location = new Point(100, 62);
            txtId.Margin = new Padding(4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(230, 34);
            txtId.TabIndex = 5;
            txtId.Text = "0";
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new Point(358, 215);
            salaryLabel.Margin = new Padding(4, 0, 4, 0);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new Size(65, 28);
            salaryLabel.TabIndex = 4;
            salaryLabel.Text = "Salary";
            salaryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new Point(869, 29);
            positionLabel.Margin = new Padding(4, 0, 4, 0);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(82, 28);
            positionLabel.TabIndex = 3;
            positionLabel.Text = "Position";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(614, 30);
            lastNameLabel.Margin = new Padding(4, 0, 4, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(103, 28);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(358, 30);
            firstNameLabel.Margin = new Padding(4, 0, 4, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(106, 28);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "First Name";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(100, 30);
            idLabel.Margin = new Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(29, 28);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id";
            // 
            // mainMenu
            // 
            mainMenu.BackColor = SystemColors.Control;
            mainMenu.ImageScalingSize = new Size(20, 20);
            mainMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, employeeToolStripMenuItem });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Padding = new Padding(8, 3, 0, 3);
            mainMenu.Size = new Size(1229, 30);
            mainMenu.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(116, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // employeeToolStripMenuItem
            // 
            employeeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { getAllToolStripMenuItem, newToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem });
            employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            employeeToolStripMenuItem.Size = new Size(95, 24);
            employeeToolStripMenuItem.Text = "Employees";
            // 
            // getAllToolStripMenuItem
            // 
            getAllToolStripMenuItem.Name = "getAllToolStripMenuItem";
            getAllToolStripMenuItem.Size = new Size(137, 26);
            getAllToolStripMenuItem.Text = "Get All";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(137, 26);
            newToolStripMenuItem.Text = "New";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(137, 26);
            editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(137, 26);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // panel
            // 
            panel.BackColor = SystemColors.ActiveCaption;
            panel.Controls.Add(mainMenu);
            panel.Dock = DockStyle.Top;
            panel.Location = new Point(0, 0);
            panel.Margin = new Padding(4);
            panel.Name = "panel";
            panel.Size = new Size(1229, 31);
            panel.TabIndex = 1;
            // 
            // EmployeeView
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 404);
            Controls.Add(tabControl);
            Controls.Add(panel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = mainMenu;
            Margin = new Padding(4);
            Name = "EmployeeView";
            Text = "EmployeeView";
            tabControl.ResumeLayout(false);
            employeesListTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            employeeDetailTab.ResumeLayout(false);
            employeeDetailTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtSalary).EndInit();
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl;
        private TabPage employeesListTab;
        private TabPage employeeDetailTab;
        private DataGridView dataGridView;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtId;
        private Label salaryLabel;
        private Label positionLabel;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private Label idLabel;
        private TextBox txtPosition;
        private Button btnCancel;
        private Button btnSave;
        private NumericUpDown txtSalary;
        private MenuStrip mainMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem employeeToolStripMenuItem;
        private ToolStripMenuItem getAllToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Panel panel;
        private Label labelApartmentNumber;
        private Label labelComboCity;
        private ComboBox comboBoxCity;
        private Label labelComboCountry;
        private ComboBox comboBoxCountry;
        private ComboBox comboBoxStreet;
        private Label labelComboHouse;
        private Label labelComboStreet;
        private ComboBox comboBoxHouse;
        private ComboBox comboBoxApartment;
    }
}
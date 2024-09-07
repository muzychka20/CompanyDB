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
            label1 = new Label();
            txtSalary = new NumericUpDown();
            btnCancel = new Button();
            btnSave = new Button();
            txtLocation = new TextBox();
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
            tabControl.Size = new Size(1522, 768);
            tabControl.TabIndex = 2;
            // 
            // employeesListTab
            // 
            employeesListTab.Controls.Add(dataGridView);
            employeesListTab.Location = new Point(4, 37);
            employeesListTab.Margin = new Padding(4);
            employeesListTab.Name = "employeesListTab";
            employeesListTab.Padding = new Padding(4);
            employeesListTab.Size = new Size(1514, 727);
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
            dataGridView.Size = new Size(1506, 719);
            dataGridView.TabIndex = 0;
            // 
            // employeeDetailTab
            // 
            employeeDetailTab.Controls.Add(label1);
            employeeDetailTab.Controls.Add(txtSalary);
            employeeDetailTab.Controls.Add(btnCancel);
            employeeDetailTab.Controls.Add(btnSave);
            employeeDetailTab.Controls.Add(txtLocation);
            employeeDetailTab.Controls.Add(txtPosition);
            employeeDetailTab.Controls.Add(txtLastName);
            employeeDetailTab.Controls.Add(txtFirstName);
            employeeDetailTab.Controls.Add(txtId);
            employeeDetailTab.Controls.Add(salaryLabel);
            employeeDetailTab.Controls.Add(positionLabel);
            employeeDetailTab.Controls.Add(lastNameLabel);
            employeeDetailTab.Controls.Add(firstNameLabel);
            employeeDetailTab.Controls.Add(idLabel);
            employeeDetailTab.Location = new Point(4, 29);
            employeeDetailTab.Margin = new Padding(4);
            employeeDetailTab.Name = "employeeDetailTab";
            employeeDetailTab.Padding = new Padding(4);
            employeeDetailTab.Size = new Size(1514, 735);
            employeeDetailTab.TabIndex = 1;
            employeeDetailTab.Text = "Employee detail";
            employeeDetailTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(632, 124);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 28);
            label1.TabIndex = 14;
            label1.Text = "Location id";
            // 
            // txtSalary
            // 
            txtSalary.DecimalPlaces = 2;
            txtSalary.Location = new Point(352, 274);
            txtSalary.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(150, 34);
            txtSalary.TabIndex = 13;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(245, 348);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(144, 39);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(66, 348);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(144, 39);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(632, 156);
            txtLocation.Margin = new Padding(4);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(230, 34);
            txtLocation.TabIndex = 10;
            txtLocation.Text = "0";
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(67, 274);
            txtPosition.Margin = new Padding(4);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(230, 34);
            txtPosition.TabIndex = 8;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(352, 156);
            txtLastName.Margin = new Padding(4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(230, 34);
            txtLastName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(67, 156);
            txtFirstName.Margin = new Padding(4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(230, 34);
            txtFirstName.TabIndex = 6;
            // 
            // txtId
            // 
            txtId.Location = new Point(67, 59);
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
            salaryLabel.Location = new Point(352, 241);
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
            positionLabel.Location = new Point(67, 241);
            positionLabel.Margin = new Padding(4, 0, 4, 0);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(82, 28);
            positionLabel.TabIndex = 3;
            positionLabel.Text = "Position";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(352, 124);
            lastNameLabel.Margin = new Padding(4, 0, 4, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(103, 28);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(67, 124);
            firstNameLabel.Margin = new Padding(4, 0, 4, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(106, 28);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "First Name";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(67, 27);
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
            mainMenu.Size = new Size(1522, 30);
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
            panel.Size = new Size(1522, 31);
            panel.TabIndex = 1;
            // 
            // EmployeeView
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1522, 799);
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
        private TextBox txtLocation;
        private Button btnCancel;
        private Button btnSave;
        private NumericUpDown txtSalary;
        private Label label1;
        private MenuStrip mainMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem employeeToolStripMenuItem;
        private ToolStripMenuItem getAllToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Panel panel;
    }
}
namespace CompanyDB.Views
{
    partial class MainView
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
            panelMenu = new Panel();
            btnExit = new Button();
            btnEmployees = new Button();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.ActiveCaption;
            panelMenu.Controls.Add(btnExit);
            panelMenu.Controls.Add(btnEmployees);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(150, 571);
            panelMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(4, 524);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(142, 43);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnEmployees
            // 
            btnEmployees.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmployees.Location = new Point(4, 92);
            btnEmployees.Margin = new Padding(4);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(142, 43);
            btnEmployees.TabIndex = 0;
            btnEmployees.Text = "Employees";
            btnEmployees.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 571);
            Controls.Add(panelMenu);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            Margin = new Padding(4);
            Name = "MainView";
            Text = "MainView";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnEmployees;
        private Button btnExit;
    }
}
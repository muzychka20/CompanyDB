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
            panel1 = new Panel();
            label1 = new Label();
            btnEmployees = new Button();
            btnExit = new Button();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Teal;
            panelMenu.Controls.Add(panel1);
            panelMenu.Controls.Add(btnExit);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(155, 493);
            panelMenu.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnEmployees);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(155, 427);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Teal;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(4, 9);
            label1.Name = "label1";
            label1.Size = new Size(77, 28);
            label1.TabIndex = 1;
            label1.Text = "Models";
            // 
            // btnEmployees
            // 
            btnEmployees.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnEmployees.Cursor = Cursors.Hand;
            btnEmployees.FlatAppearance.BorderSize = 0;
            btnEmployees.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmployees.Location = new Point(4, 41);
            btnEmployees.Margin = new Padding(4);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(147, 43);
            btnEmployees.TabIndex = 0;
            btnEmployees.Text = "Employees";
            btnEmployees.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.IndianRed;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatAppearance.BorderColor = Color.Gray;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.Brown;
            btnExit.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.Control;
            btnExit.Location = new Point(0, 449);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(155, 44);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1342, 493);
            Controls.Add(panelMenu);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            Margin = new Padding(4);
            MinimumSize = new Size(1360, 540);
            Name = "MainView";
            Text = "Main";
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnEmployees;
        private Button btnExit;
        private Panel panel1;
        private Label label1;
    }
}
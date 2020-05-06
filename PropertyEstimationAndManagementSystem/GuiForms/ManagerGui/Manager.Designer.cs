namespace PropertyEstimationAndManagementSystem.GuiForms
{
    partial class Manager
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
            this.TotalEstimatedProfit = new System.Windows.Forms.Button();
            this.CheckProfit = new System.Windows.Forms.Button();
            this.EditEmployee = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EditEmployeePanel = new System.Windows.Forms.Panel();
            this.showUsers = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EmployeePanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.EditEmployeePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TotalEstimatedProfit
            // 
            this.TotalEstimatedProfit.Location = new System.Drawing.Point(33, 304);
            this.TotalEstimatedProfit.Name = "TotalEstimatedProfit";
            this.TotalEstimatedProfit.Size = new System.Drawing.Size(127, 23);
            this.TotalEstimatedProfit.TabIndex = 4;
            this.TotalEstimatedProfit.Text = "Total Estimated Profit";
            this.TotalEstimatedProfit.UseVisualStyleBackColor = true;
            // 
            // CheckProfit
            // 
            this.CheckProfit.Location = new System.Drawing.Point(33, 342);
            this.CheckProfit.Name = "CheckProfit";
            this.CheckProfit.Size = new System.Drawing.Size(119, 23);
            this.CheckProfit.TabIndex = 5;
            this.CheckProfit.Text = "Check Profit";
            this.CheckProfit.UseVisualStyleBackColor = true;
            this.CheckProfit.Click += new System.EventHandler(this.CheckProfit_Click);
            // 
            // EditEmployee
            // 
            this.EditEmployee.FlatAppearance.BorderSize = 0;
            this.EditEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditEmployee.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EditEmployee.Location = new System.Drawing.Point(3, 138);
            this.EditEmployee.Name = "EditEmployee";
            this.EditEmployee.Size = new System.Drawing.Size(110, 23);
            this.EditEmployee.TabIndex = 6;
            this.EditEmployee.Text = "Employees";
            this.EditEmployee.UseVisualStyleBackColor = true;
            this.EditEmployee.Click += new System.EventHandler(this.EditEmployee_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(692, 384);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.EditEmployeePanel);
            this.panel1.Controls.Add(this.EditEmployee);
            this.panel1.Controls.Add(this.CheckProfit);
            this.panel1.Controls.Add(this.TotalEstimatedProfit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 556);
            this.panel1.TabIndex = 7;
            // 
            // EditEmployeePanel
            // 
            this.EditEmployeePanel.Controls.Add(this.showUsers);
            this.EditEmployeePanel.Controls.Add(this.Insert);
            this.EditEmployeePanel.Location = new System.Drawing.Point(0, 167);
            this.EditEmployeePanel.Name = "EditEmployeePanel";
            this.EditEmployeePanel.Size = new System.Drawing.Size(200, 131);
            this.EditEmployeePanel.TabIndex = 7;
            // 
            // showUsers
            // 
            this.showUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.showUsers.FlatAppearance.BorderSize = 0;
            this.showUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showUsers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.showUsers.Location = new System.Drawing.Point(0, 23);
            this.showUsers.Name = "showUsers";
            this.showUsers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.showUsers.Size = new System.Drawing.Size(200, 23);
            this.showUsers.TabIndex = 3;
            this.showUsers.Text = "Show Users";
            this.showUsers.UseVisualStyleBackColor = true;
            this.showUsers.Click += new System.EventHandler(this.showUsers_Click);
            // 
            // Insert
            // 
            this.Insert.Dock = System.Windows.Forms.DockStyle.Top;
            this.Insert.FlatAppearance.BorderSize = 0;
            this.Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Insert.Location = new System.Drawing.Point(0, 0);
            this.Insert.Name = "Insert";
            this.Insert.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Insert.Size = new System.Drawing.Size(200, 23);
            this.Insert.TabIndex = 0;
            this.Insert.Text = "Edit Employee";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(32)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(180, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(814, 42);
            this.panel2.TabIndex = 8;
            // 
            // EmployeePanel
            // 
            this.EmployeePanel.BackColor = System.Drawing.Color.DimGray;
            this.EmployeePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeePanel.Location = new System.Drawing.Point(180, 42);
            this.EmployeePanel.Name = "EmployeePanel";
            this.EmployeePanel.Size = new System.Drawing.Size(814, 514);
            this.EmployeePanel.TabIndex = 9;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(994, 556);
            this.Controls.Add(this.EmployeePanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Manager";
            this.Text = "Manager";
            this.panel1.ResumeLayout(false);
            this.EditEmployeePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button TotalEstimatedProfit;
        private System.Windows.Forms.Button CheckProfit;
        private System.Windows.Forms.Button EditEmployee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel EditEmployeePanel;
        private System.Windows.Forms.Button showUsers;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel EmployeePanel;
    }
}
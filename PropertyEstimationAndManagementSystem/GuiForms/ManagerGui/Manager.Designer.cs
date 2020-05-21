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
            this.ShowProperty = new System.Windows.Forms.Button();
            this.CheckProfit = new System.Windows.Forms.Button();
            this.EditEmployee = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.EditEmployeePanel = new System.Windows.Forms.Panel();
            this.showUsers = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EmployeePanel = new System.Windows.Forms.Panel();
            this.panelProperty = new System.Windows.Forms.Panel();
            this.btnPropertyInfo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.EditEmployeePanel.SuspendLayout();
            this.panelProperty.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowProperty
            // 
            this.ShowProperty.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShowProperty.FlatAppearance.BorderSize = 0;
            this.ShowProperty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowProperty.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ShowProperty.Location = new System.Drawing.Point(0, 0);
            this.ShowProperty.Name = "ShowProperty";
            this.ShowProperty.Size = new System.Drawing.Size(177, 23);
            this.ShowProperty.TabIndex = 4;
            this.ShowProperty.Text = "Show Property";
            this.ShowProperty.UseVisualStyleBackColor = true;
            this.ShowProperty.Click += new System.EventHandler(this.ShowProperty_Click);
            // 
            // CheckProfit
            // 
            this.CheckProfit.FlatAppearance.BorderSize = 0;
            this.CheckProfit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckProfit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CheckProfit.Location = new System.Drawing.Point(33, 328);
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
            this.EditEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditEmployee.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EditEmployee.Location = new System.Drawing.Point(3, 138);
            this.EditEmployee.Name = "EditEmployee";
            this.EditEmployee.Size = new System.Drawing.Size(174, 34);
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
            this.panel1.Controls.Add(this.btnPropertyInfo);
            this.panel1.Controls.Add(this.panelProperty);
            this.panel1.Controls.Add(this.Logout);
            this.panel1.Controls.Add(this.btnImage);
            this.panel1.Controls.Add(this.EditEmployeePanel);
            this.panel1.Controls.Add(this.EditEmployee);
            this.panel1.Controls.Add(this.CheckProfit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 590);
            this.panel1.TabIndex = 7;
            // 
            // Logout
            // 
            this.Logout.FlatAppearance.BorderSize = 0;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Logout.Location = new System.Drawing.Point(57, 357);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(75, 23);
            this.Logout.TabIndex = 9;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // btnImage
            // 
            this.btnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImage.Image = global::PropertyEstimationAndManagementSystem.Properties.Resources.Mnp_LOGO_f;
            this.btnImage.Location = new System.Drawing.Point(0, 0);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(168, 132);
            this.btnImage.TabIndex = 8;
            this.btnImage.UseVisualStyleBackColor = true;
            // 
            // EditEmployeePanel
            // 
            this.EditEmployeePanel.Controls.Add(this.showUsers);
            this.EditEmployeePanel.Controls.Add(this.Insert);
            this.EditEmployeePanel.Location = new System.Drawing.Point(0, 167);
            this.EditEmployeePanel.Name = "EditEmployeePanel";
            this.EditEmployeePanel.Size = new System.Drawing.Size(180, 66);
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
            this.showUsers.Size = new System.Drawing.Size(180, 23);
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
            this.Insert.Size = new System.Drawing.Size(180, 23);
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
            this.panel2.Size = new System.Drawing.Size(805, 42);
            this.panel2.TabIndex = 8;
            // 
            // EmployeePanel
            // 
            this.EmployeePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.EmployeePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeePanel.Location = new System.Drawing.Point(180, 42);
            this.EmployeePanel.Name = "EmployeePanel";
            this.EmployeePanel.Size = new System.Drawing.Size(805, 548);
            this.EmployeePanel.TabIndex = 9;
            // 
            // panelProperty
            // 
            this.panelProperty.Controls.Add(this.ShowProperty);
            this.panelProperty.Location = new System.Drawing.Point(3, 272);
            this.panelProperty.Name = "panelProperty";
            this.panelProperty.Size = new System.Drawing.Size(177, 50);
            this.panelProperty.TabIndex = 10;
            // 
            // btnPropertyInfo
            // 
            this.btnPropertyInfo.FlatAppearance.BorderSize = 0;
            this.btnPropertyInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPropertyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPropertyInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPropertyInfo.Location = new System.Drawing.Point(15, 239);
            this.btnPropertyInfo.Name = "btnPropertyInfo";
            this.btnPropertyInfo.Size = new System.Drawing.Size(159, 27);
            this.btnPropertyInfo.TabIndex = 11;
            this.btnPropertyInfo.Text = "Property Information";
            this.btnPropertyInfo.UseVisualStyleBackColor = true;
            this.btnPropertyInfo.Click += new System.EventHandler(this.btnPropertyInfo_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(985, 590);
            this.Controls.Add(this.EmployeePanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Manager";
            this.Text = "Manager";
            this.panel1.ResumeLayout(false);
            this.EditEmployeePanel.ResumeLayout(false);
            this.panelProperty.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ShowProperty;
        private System.Windows.Forms.Button CheckProfit;
        private System.Windows.Forms.Button EditEmployee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel EditEmployeePanel;
        private System.Windows.Forms.Button showUsers;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel EmployeePanel;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button btnPropertyInfo;
        private System.Windows.Forms.Panel panelProperty;
    }
}
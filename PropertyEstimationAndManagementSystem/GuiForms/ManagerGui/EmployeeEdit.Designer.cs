namespace PropertyEstimationAndManagementSystem.GuiForms
{
    partial class EmployeeEdit
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
            this.label4 = new System.Windows.Forms.Label();
            this.RemoveEmployee = new System.Windows.Forms.Button();
            this.UpdateEmployee = new System.Windows.Forms.Button();
            this.InsertEmployee = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridEmployee = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // RemoveEmployee
            // 
            this.RemoveEmployee.Location = new System.Drawing.Point(424, 72);
            this.RemoveEmployee.Name = "RemoveEmployee";
            this.RemoveEmployee.Size = new System.Drawing.Size(112, 23);
            this.RemoveEmployee.TabIndex = 8;
            this.RemoveEmployee.Text = "Remove Employee";
            this.RemoveEmployee.UseVisualStyleBackColor = true;
            this.RemoveEmployee.Click += new System.EventHandler(this.RemoveEmployee_Click);
            // 
            // UpdateEmployee
            // 
            this.UpdateEmployee.Location = new System.Drawing.Point(265, 72);
            this.UpdateEmployee.Name = "UpdateEmployee";
            this.UpdateEmployee.Size = new System.Drawing.Size(117, 23);
            this.UpdateEmployee.TabIndex = 7;
            this.UpdateEmployee.Text = "Update Employee";
            this.UpdateEmployee.UseVisualStyleBackColor = true;
            this.UpdateEmployee.Click += new System.EventHandler(this.UpdateEmployee_Click);
            // 
            // InsertEmployee
            // 
            this.InsertEmployee.CausesValidation = false;
            this.InsertEmployee.Location = new System.Drawing.Point(111, 72);
            this.InsertEmployee.Name = "InsertEmployee";
            this.InsertEmployee.Size = new System.Drawing.Size(119, 23);
            this.InsertEmployee.TabIndex = 6;
            this.InsertEmployee.Text = "Insert Employee";
            this.InsertEmployee.UseVisualStyleBackColor = true;
            this.InsertEmployee.Click += new System.EventHandler(this.InsertEmployee_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(575, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "View Employee List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridEmployee
            // 
            this.dataGridEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmployee.Location = new System.Drawing.Point(12, 158);
            this.dataGridEmployee.Name = "dataGridEmployee";
            this.dataGridEmployee.Size = new System.Drawing.Size(754, 222);
            this.dataGridEmployee.TabIndex = 17;
            this.dataGridEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEmployee_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(334, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Employee List";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 22);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 24;
            this.Back.Text = "<";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(313, 409);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(147, 23);
            this.btnCreateAccount.TabIndex = 25;
            this.btnCreateAccount.Text = "Create New Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // EmployeeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(778, 444);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridEmployee);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RemoveEmployee);
            this.Controls.Add(this.UpdateEmployee);
            this.Controls.Add(this.InsertEmployee);
            this.Controls.Add(this.label4);
            this.Name = "EmployeeEdit";
            this.Text = "EmployeeEdit";
            this.Load += new System.EventHandler(this.EmployeeEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RemoveEmployee;
        private System.Windows.Forms.Button UpdateEmployee;
        private System.Windows.Forms.Button InsertEmployee;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridEmployee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button btnCreateAccount;
    }
}
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
            this.SuspendLayout();
            // 
            // TotalEstimatedProfit
            // 
            this.TotalEstimatedProfit.Location = new System.Drawing.Point(331, 32);
            this.TotalEstimatedProfit.Name = "TotalEstimatedProfit";
            this.TotalEstimatedProfit.Size = new System.Drawing.Size(127, 23);
            this.TotalEstimatedProfit.TabIndex = 4;
            this.TotalEstimatedProfit.Text = "Total Estimated Profit";
            this.TotalEstimatedProfit.UseVisualStyleBackColor = true;
            // 
            // CheckProfit
            // 
            this.CheckProfit.Location = new System.Drawing.Point(519, 32);
            this.CheckProfit.Name = "CheckProfit";
            this.CheckProfit.Size = new System.Drawing.Size(119, 23);
            this.CheckProfit.TabIndex = 5;
            this.CheckProfit.Text = "Check Profit";
            this.CheckProfit.UseVisualStyleBackColor = true;
            // 
            // EditEmployee
            // 
            this.EditEmployee.Location = new System.Drawing.Point(135, 32);
            this.EditEmployee.Name = "EditEmployee";
            this.EditEmployee.Size = new System.Drawing.Size(120, 23);
            this.EditEmployee.TabIndex = 6;
            this.EditEmployee.Text = "Edit Employee";
            this.EditEmployee.UseVisualStyleBackColor = true;
            this.EditEmployee.Click += new System.EventHandler(this.EditEmployee_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditEmployee);
            this.Controls.Add(this.CheckProfit);
            this.Controls.Add(this.TotalEstimatedProfit);
            this.Name = "Manager";
            this.Text = "Manager";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button TotalEstimatedProfit;
        private System.Windows.Forms.Button CheckProfit;
        private System.Windows.Forms.Button EditEmployee;
    }
}
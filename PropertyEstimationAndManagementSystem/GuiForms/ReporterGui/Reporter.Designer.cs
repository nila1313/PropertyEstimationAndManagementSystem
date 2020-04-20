namespace PropertyEstimationAndManagementSystem.GuiForms
{
    partial class Reporter
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
            this.btnEditReporter = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEditReporter
            // 
            this.btnEditReporter.Location = new System.Drawing.Point(154, 131);
            this.btnEditReporter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditReporter.Name = "btnEditReporter";
            this.btnEditReporter.Size = new System.Drawing.Size(166, 58);
            this.btnEditReporter.TabIndex = 0;
            this.btnEditReporter.Text = "EDIT PROPERTY";
            this.btnEditReporter.UseVisualStyleBackColor = true;
            this.btnEditReporter.Click += new System.EventHandler(this.btnEditReporter_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(493, 307);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Reporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnEditReporter);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Reporter";
            this.Text = "Reporter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditReporter;
        private System.Windows.Forms.Button btnLogout;
    }
}
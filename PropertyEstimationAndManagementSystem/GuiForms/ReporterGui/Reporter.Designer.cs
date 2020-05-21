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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.btnCustomerEdit = new System.Windows.Forms.Button();
            this.panelProperty = new System.Windows.Forms.Panel();
            this.btnAreaPrice = new System.Windows.Forms.Button();
            this.btnEditProperty = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ReporterMainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelCustomer.SuspendLayout();
            this.panelProperty.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditReporter
            // 
            this.btnEditReporter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditReporter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditReporter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditReporter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditReporter.Location = new System.Drawing.Point(0, 0);
            this.btnEditReporter.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditReporter.Name = "btnEditReporter";
            this.btnEditReporter.Size = new System.Drawing.Size(200, 58);
            this.btnEditReporter.TabIndex = 0;
            this.btnEditReporter.Text = "Property";
            this.btnEditReporter.UseVisualStyleBackColor = true;
            this.btnEditReporter.Click += new System.EventHandler(this.btnEditReporter_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(30, 472);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Controls.Add(this.panelCustomer);
            this.panel1.Controls.Add(this.panelProperty);
            this.panel1.Controls.Add(this.btnEditReporter);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 563);
            this.panel1.TabIndex = 2;
            // 
            // btnCustomer
            // 
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCustomer.Location = new System.Drawing.Point(3, 186);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(200, 33);
            this.btnCustomer.TabIndex = 4;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // panelCustomer
            // 
            this.panelCustomer.Controls.Add(this.btnCustomerEdit);
            this.panelCustomer.Location = new System.Drawing.Point(0, 225);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(200, 100);
            this.panelCustomer.TabIndex = 3;
            // 
            // btnCustomerEdit
            // 
            this.btnCustomerEdit.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnCustomerEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomerEdit.FlatAppearance.BorderSize = 0;
            this.btnCustomerEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCustomerEdit.Location = new System.Drawing.Point(0, 0);
            this.btnCustomerEdit.Name = "btnCustomerEdit";
            this.btnCustomerEdit.Size = new System.Drawing.Size(200, 23);
            this.btnCustomerEdit.TabIndex = 5;
            this.btnCustomerEdit.Text = "Edit Customer";
            this.btnCustomerEdit.UseVisualStyleBackColor = false;
            this.btnCustomerEdit.Click += new System.EventHandler(this.btnCustomerEdit_Click);
            // 
            // panelProperty
            // 
            this.panelProperty.Controls.Add(this.btnAreaPrice);
            this.panelProperty.Controls.Add(this.btnEditProperty);
            this.panelProperty.Location = new System.Drawing.Point(0, 58);
            this.panelProperty.Name = "panelProperty";
            this.panelProperty.Size = new System.Drawing.Size(200, 100);
            this.panelProperty.TabIndex = 2;
            // 
            // btnAreaPrice
            // 
            this.btnAreaPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAreaPrice.FlatAppearance.BorderSize = 0;
            this.btnAreaPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAreaPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAreaPrice.Location = new System.Drawing.Point(0, 23);
            this.btnAreaPrice.Name = "btnAreaPrice";
            this.btnAreaPrice.Size = new System.Drawing.Size(200, 23);
            this.btnAreaPrice.TabIndex = 1;
            this.btnAreaPrice.Text = "Area Price";
            this.btnAreaPrice.UseVisualStyleBackColor = true;
            this.btnAreaPrice.Click += new System.EventHandler(this.btnAddDescription_Click);
            // 
            // btnEditProperty
            // 
            this.btnEditProperty.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditProperty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProperty.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditProperty.Location = new System.Drawing.Point(0, 0);
            this.btnEditProperty.Name = "btnEditProperty";
            this.btnEditProperty.Size = new System.Drawing.Size(200, 23);
            this.btnEditProperty.TabIndex = 0;
            this.btnEditProperty.Text = "Edit Property";
            this.btnEditProperty.UseVisualStyleBackColor = true;
            this.btnEditProperty.Click += new System.EventHandler(this.btnEditProperty_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(32)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 58);
            this.panel2.TabIndex = 3;
            // 
            // ReporterMainPanel
            // 
            this.ReporterMainPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ReporterMainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReporterMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReporterMainPanel.Location = new System.Drawing.Point(200, 58);
            this.ReporterMainPanel.Name = "ReporterMainPanel";
            this.ReporterMainPanel.Size = new System.Drawing.Size(689, 505);
            this.ReporterMainPanel.TabIndex = 4;
            // 
            // Reporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 563);
            this.Controls.Add(this.ReporterMainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Reporter";
            this.Text = "Reporter";
            this.panel1.ResumeLayout(false);
            this.panelCustomer.ResumeLayout(false);
            this.panelProperty.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditReporter;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel ReporterMainPanel;
        private System.Windows.Forms.Panel panelProperty;
        private System.Windows.Forms.Button btnAreaPrice;
        private System.Windows.Forms.Button btnEditProperty;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.Button btnCustomerEdit;
    }
}
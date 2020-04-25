namespace PropertyEstimationAndManagementSystem.GuiForms
{
    partial class EditProperty
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
            this.lblPropertyName = new System.Windows.Forms.Label();
            this.txtPropertyName = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtPropertyId = new System.Windows.Forms.TextBox();
            this.lblPropertyId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPropertyName
            // 
            this.lblPropertyName.AutoSize = true;
            this.lblPropertyName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPropertyName.Location = new System.Drawing.Point(24, 71);
            this.lblPropertyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPropertyName.Name = "lblPropertyName";
            this.lblPropertyName.Size = new System.Drawing.Size(77, 13);
            this.lblPropertyName.TabIndex = 0;
            this.lblPropertyName.Text = "Property Name";
            // 
            // txtPropertyName
            // 
            this.txtPropertyName.Location = new System.Drawing.Point(146, 71);
            this.txtPropertyName.Margin = new System.Windows.Forms.Padding(2);
            this.txtPropertyName.Name = "txtPropertyName";
            this.txtPropertyName.Size = new System.Drawing.Size(174, 20);
            this.txtPropertyName.TabIndex = 1;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblArea.Location = new System.Drawing.Point(24, 115);
            this.lblArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(29, 13);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "Area";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(146, 115);
            this.txtArea.Margin = new System.Windows.Forms.Padding(2);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(174, 20);
            this.txtArea.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrice.Location = new System.Drawing.Point(24, 206);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSize.Location = new System.Drawing.Point(24, 162);
            this.lblSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(27, 13);
            this.lblSize.TabIndex = 5;
            this.lblSize.Text = "Size";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(144, 203);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(176, 20);
            this.txtPrice.TabIndex = 6;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(144, 155);
            this.txtSize.Margin = new System.Windows.Forms.Padding(2);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(176, 20);
            this.txtSize.TabIndex = 7;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(51, 312);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(79, 25);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(215, 312);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 25);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtPropertyId
            // 
            this.txtPropertyId.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPropertyId.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPropertyId.Location = new System.Drawing.Point(144, 27);
            this.txtPropertyId.Margin = new System.Windows.Forms.Padding(2);
            this.txtPropertyId.Name = "txtPropertyId";
            this.txtPropertyId.ReadOnly = true;
            this.txtPropertyId.Size = new System.Drawing.Size(176, 20);
            this.txtPropertyId.TabIndex = 11;
            // 
            // lblPropertyId
            // 
            this.lblPropertyId.AutoSize = true;
            this.lblPropertyId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPropertyId.Location = new System.Drawing.Point(24, 27);
            this.lblPropertyId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPropertyId.Name = "lblPropertyId";
            this.lblPropertyId.Size = new System.Drawing.Size(60, 13);
            this.lblPropertyId.TabIndex = 12;
            this.lblPropertyId.Text = "Property ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.comboBoxStatus);
            this.panel1.Controls.Add(this.lblPropertyId);
            this.panel1.Controls.Add(this.lblPropertyName);
            this.panel1.Controls.Add(this.txtPropertyId);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.lblArea);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.txtPropertyName);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtSize);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.txtArea);
            this.panel1.Controls.Add(this.lblSize);
            this.panel1.Location = new System.Drawing.Point(123, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 411);
            this.panel1.TabIndex = 14;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "<";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Available",
            "Sold",
            "Unsold",
            "Booked"});
            this.comboBoxStatus.Location = new System.Drawing.Point(144, 244);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(176, 21);
            this.comboBoxStatus.TabIndex = 13;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStatus.Location = new System.Drawing.Point(24, 245);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 15);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Status";
            // 
            // EditProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(848, 435);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditProperty";
            this.Text = "EditProperty";
            this.Load += new System.EventHandler(this.EditProperty_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPropertyName;
        private System.Windows.Forms.TextBox txtPropertyName;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtPropertyId;
        private System.Windows.Forms.Label lblPropertyId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox comboBoxStatus;
    }
}
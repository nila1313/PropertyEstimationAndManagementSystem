namespace PropertyEstimationAndManagementSystem.GuiForms
{
    partial class HomePage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Users = new System.Windows.Forms.Button();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.Login = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.formPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnImage = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.UserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnImage);
            this.panel1.Controls.Add(this.Users);
            this.panel1.Controls.Add(this.UserPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 556);
            this.panel1.TabIndex = 0;
            // 
            // Users
            // 
            this.Users.FlatAppearance.BorderSize = 0;
            this.Users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Users.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Users.Location = new System.Drawing.Point(0, 159);
            this.Users.Name = "Users";
            this.Users.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Users.Size = new System.Drawing.Size(99, 31);
            this.Users.TabIndex = 1;
            this.Users.Text = "   Users";
            this.Users.UseVisualStyleBackColor = true;
            this.Users.Click += new System.EventHandler(this.Users_Click);
            // 
            // UserPanel
            // 
            this.UserPanel.Controls.Add(this.panel4);
            this.UserPanel.Controls.Add(this.Login);
            this.UserPanel.Location = new System.Drawing.Point(3, 196);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(171, 65);
            this.UserPanel.TabIndex = 0;
            // 
            // Login
            // 
            this.Login.Dock = System.Windows.Forms.DockStyle.Top;
            this.Login.FlatAppearance.BorderSize = 0;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Login.Location = new System.Drawing.Point(0, 0);
            this.Login.Name = "Login";
            this.Login.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Login.Size = new System.Drawing.Size(171, 45);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(171, 490);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 66);
            this.panel2.TabIndex = 1;
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPanel.Location = new System.Drawing.Point(171, 0);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(823, 490);
            this.formPanel.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::PropertyEstimationAndManagementSystem.Properties.Resources.Untitled;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(3, 161);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(27, 28);
            this.panel3.TabIndex = 12;
            // 
            // btnImage
            // 
            this.btnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImage.Image = global::PropertyEstimationAndManagementSystem.Properties.Resources.Mnp_LOGO_f;
            this.btnImage.Location = new System.Drawing.Point(0, 3);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(168, 139);
            this.btnImage.TabIndex = 2;
            this.btnImage.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::PropertyEstimationAndManagementSystem.Properties.Resources.key;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(42, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(27, 22);
            this.panel4.TabIndex = 1;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 556);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.panel1.ResumeLayout(false);
            this.UserPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Users;
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}
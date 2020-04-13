﻿namespace PropertyEstimationAndManagementSystem.GuiForms
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
            this.button3 = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.formPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.UserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
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
            this.Users.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Users.Location = new System.Drawing.Point(0, 97);
            this.Users.Name = "Users";
            this.Users.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Users.Size = new System.Drawing.Size(80, 23);
            this.Users.TabIndex = 1;
            this.Users.Text = "Users";
            this.Users.UseVisualStyleBackColor = true;
            this.Users.Click += new System.EventHandler(this.Users_Click);
            // 
            // UserPanel
            // 
            this.UserPanel.Controls.Add(this.button3);
            this.UserPanel.Controls.Add(this.Login);
            this.UserPanel.Location = new System.Drawing.Point(0, 130);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(171, 56);
            this.UserPanel.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(0, 23);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(171, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.Login.Dock = System.Windows.Forms.DockStyle.Top;
            this.Login.FlatAppearance.BorderSize = 0;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Login.Location = new System.Drawing.Point(0, 0);
            this.Login.Name = "Login";
            this.Login.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Login.Size = new System.Drawing.Size(171, 23);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel formPanel;
    }
}
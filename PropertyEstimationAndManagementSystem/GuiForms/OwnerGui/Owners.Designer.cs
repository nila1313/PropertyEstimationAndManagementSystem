namespace PropertyEstimationAndManagementSystem.GuiForms.OwnerGui
{
    partial class Owners
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
            this.btnFeedBack = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnManager = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.panelTransaction = new System.Windows.Forms.Panel();
            this.btnSaleBuyEstimation = new System.Windows.Forms.Button();
            this.btnTransactionList = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelOwner = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelTransaction.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnFeedBack);
            this.panel1.Controls.Add(this.btnAccount);
            this.panel1.Controls.Add(this.btnManager);
            this.panel1.Controls.Add(this.btnTransaction);
            this.panel1.Controls.Add(this.panelTransaction);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 590);
            this.panel1.TabIndex = 0;
            // 
            // btnFeedBack
            // 
            this.btnFeedBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedBack.Location = new System.Drawing.Point(3, 447);
            this.btnFeedBack.Name = "btnFeedBack";
            this.btnFeedBack.Size = new System.Drawing.Size(194, 35);
            this.btnFeedBack.TabIndex = 3;
            this.btnFeedBack.Text = "Check FeedBack";
            this.btnFeedBack.UseVisualStyleBackColor = true;
            this.btnFeedBack.Click += new System.EventHandler(this.btnFeedBack_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.Location = new System.Drawing.Point(3, 395);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(194, 33);
            this.btnAccount.TabIndex = 2;
            this.btnAccount.Text = "Account";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnManager
            // 
            this.btnManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManager.Location = new System.Drawing.Point(0, 339);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(200, 34);
            this.btnManager.TabIndex = 0;
            this.btnManager.Text = "Manager";
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.FlatAppearance.BorderSize = 0;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.Location = new System.Drawing.Point(0, 156);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(153, 37);
            this.btnTransaction.TabIndex = 1;
            this.btnTransaction.Text = "Transaction";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // panelTransaction
            // 
            this.panelTransaction.Controls.Add(this.btnSaleBuyEstimation);
            this.panelTransaction.Controls.Add(this.btnTransactionList);
            this.panelTransaction.Location = new System.Drawing.Point(3, 199);
            this.panelTransaction.Name = "panelTransaction";
            this.panelTransaction.Size = new System.Drawing.Size(200, 100);
            this.panelTransaction.TabIndex = 0;
            // 
            // btnSaleBuyEstimation
            // 
            this.btnSaleBuyEstimation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaleBuyEstimation.FlatAppearance.BorderSize = 0;
            this.btnSaleBuyEstimation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaleBuyEstimation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaleBuyEstimation.Location = new System.Drawing.Point(0, 32);
            this.btnSaleBuyEstimation.Name = "btnSaleBuyEstimation";
            this.btnSaleBuyEstimation.Size = new System.Drawing.Size(200, 33);
            this.btnSaleBuyEstimation.TabIndex = 0;
            this.btnSaleBuyEstimation.Text = "Buy-Sale Estimation";
            this.btnSaleBuyEstimation.UseVisualStyleBackColor = false;
            this.btnSaleBuyEstimation.Click += new System.EventHandler(this.btnSaleReport_Click);
            // 
            // btnTransactionList
            // 
            this.btnTransactionList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransactionList.FlatAppearance.BorderSize = 0;
            this.btnTransactionList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactionList.Location = new System.Drawing.Point(0, 0);
            this.btnTransactionList.Name = "btnTransactionList";
            this.btnTransactionList.Size = new System.Drawing.Size(200, 32);
            this.btnTransactionList.TabIndex = 0;
            this.btnTransactionList.Text = "Transaction List";
            this.btnTransactionList.UseVisualStyleBackColor = true;
            this.btnTransactionList.Click += new System.EventHandler(this.btnTransactionList_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(23)))), ((int)(((byte)(32)))));
            this.panel3.Controls.Add(this.btnLogout);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(785, 49);
            this.panel3.TabIndex = 1;
            // 
            // panelOwner
            // 
            this.panelOwner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panelOwner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOwner.Location = new System.Drawing.Point(200, 49);
            this.panelOwner.Name = "panelOwner";
            this.panelOwner.Size = new System.Drawing.Size(785, 541);
            this.panelOwner.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::PropertyEstimationAndManagementSystem.Properties.Resources.images;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(731, 7);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(42, 36);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::PropertyEstimationAndManagementSystem.Properties.Resources.Mnp_LOGO_f;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 126);
            this.panel2.TabIndex = 4;
            // 
            // Owners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 590);
            this.Controls.Add(this.panelOwner);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Owners";
            this.Text = "Owners";
           
            this.panel1.ResumeLayout(false);
            this.panelTransaction.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Panel panelTransaction;
        private System.Windows.Forms.Button btnTransactionList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelOwner;
        private System.Windows.Forms.Button btnSaleBuyEstimation;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnFeedBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogout;
    }
}
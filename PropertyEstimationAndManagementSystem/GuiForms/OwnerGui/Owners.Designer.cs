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
            this.btnTransaction = new System.Windows.Forms.Button();
            this.panelTransaction = new System.Windows.Forms.Panel();
            this.btnTransactionList = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelOwner = new System.Windows.Forms.Panel();
            this.btnSaleBuyEstimation = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panelTransaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnTransaction);
            this.panel1.Controls.Add(this.panelTransaction);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 640);
            this.panel1.TabIndex = 0;
            // 
            // btnTransaction
            // 
            this.btnTransaction.FlatAppearance.BorderSize = 0;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Location = new System.Drawing.Point(41, 20);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(75, 23);
            this.btnTransaction.TabIndex = 1;
            this.btnTransaction.Text = "Transaction";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // panelTransaction
            // 
            this.panelTransaction.Controls.Add(this.btnSaleBuyEstimation);
            this.panelTransaction.Controls.Add(this.btnTransactionList);
            this.panelTransaction.Location = new System.Drawing.Point(3, 55);
            this.panelTransaction.Name = "panelTransaction";
            this.panelTransaction.Size = new System.Drawing.Size(200, 100);
            this.panelTransaction.TabIndex = 0;
            // 
            // btnTransactionList
            // 
            this.btnTransactionList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransactionList.FlatAppearance.BorderSize = 0;
            this.btnTransactionList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionList.Location = new System.Drawing.Point(0, 0);
            this.btnTransactionList.Name = "btnTransactionList";
            this.btnTransactionList.Size = new System.Drawing.Size(200, 23);
            this.btnTransactionList.TabIndex = 0;
            this.btnTransactionList.Text = "Transaction List";
            this.btnTransactionList.UseVisualStyleBackColor = true;
            this.btnTransactionList.Click += new System.EventHandler(this.btnTransactionList_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(23)))), ((int)(((byte)(32)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1122, 38);
            this.panel3.TabIndex = 1;
            // 
            // panelOwner
            // 
            this.panelOwner.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelOwner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOwner.Location = new System.Drawing.Point(200, 38);
            this.panelOwner.Name = "panelOwner";
            this.panelOwner.Size = new System.Drawing.Size(1122, 602);
            this.panelOwner.TabIndex = 2;
            // 
            // btnSaleBuyEstimation
            // 
            this.btnSaleBuyEstimation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaleBuyEstimation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaleBuyEstimation.Location = new System.Drawing.Point(0, 23);
            this.btnSaleBuyEstimation.Name = "btnSaleBuyEstimation";
            this.btnSaleBuyEstimation.Size = new System.Drawing.Size(200, 23);
            this.btnSaleBuyEstimation.TabIndex = 0;
            this.btnSaleBuyEstimation.Text = "Buy-Sale Estimation";
            this.btnSaleBuyEstimation.UseVisualStyleBackColor = false;
            this.btnSaleBuyEstimation.Click += new System.EventHandler(this.btnSaleReport_Click);
            // 
            // Owners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 640);
            this.Controls.Add(this.panelOwner);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Owners";
            this.Text = "Owners";
            this.panel1.ResumeLayout(false);
            this.panelTransaction.ResumeLayout(false);
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
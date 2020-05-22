namespace PropertyEstimationAndManagementSystem.GuiForms.Consultant
{
    partial class Payment
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
            this.btnCash = new System.Windows.Forms.RadioButton();
            this.btncheque = new System.Windows.Forms.RadioButton();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtChequeNumber = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblChequeNumber = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnCash
            // 
            this.btnCash.AutoSize = true;
            this.btnCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCash.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCash.Location = new System.Drawing.Point(187, 95);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(64, 24);
            this.btnCash.TabIndex = 6;
            this.btnCash.TabStop = true;
            this.btnCash.Text = "Cash";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.CheckedChanged += new System.EventHandler(this.btnCash_CheckedChanged);
            // 
            // btncheque
            // 
            this.btncheque.AutoSize = true;
            this.btncheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheque.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncheque.Location = new System.Drawing.Point(362, 95);
            this.btncheque.Name = "btncheque";
            this.btncheque.Size = new System.Drawing.Size(83, 24);
            this.btncheque.TabIndex = 5;
            this.btncheque.TabStop = true;
            this.btncheque.Text = "Cheque";
            this.btncheque.UseVisualStyleBackColor = true;
            this.btncheque.CheckedChanged += new System.EventHandler(this.btncheque_CheckedChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Black;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConfirm.Location = new System.Drawing.Point(269, 293);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(99, 38);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtChequeNumber
            // 
            this.txtChequeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChequeNumber.Location = new System.Drawing.Point(318, 215);
            this.txtChequeNumber.Name = "txtChequeNumber";
            this.txtChequeNumber.Size = new System.Drawing.Size(100, 26);
            this.txtChequeNumber.TabIndex = 8;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(318, 159);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 26);
            this.txtAmount.TabIndex = 9;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAmount.Location = new System.Drawing.Point(163, 159);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(65, 20);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "Amount";
            // 
            // lblChequeNumber
            // 
            this.lblChequeNumber.AutoSize = true;
            this.lblChequeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChequeNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblChequeNumber.Location = new System.Drawing.Point(163, 221);
            this.lblChequeNumber.Name = "lblChequeNumber";
            this.lblChequeNumber.Size = new System.Drawing.Size(125, 20);
            this.lblChequeNumber.TabIndex = 11;
            this.lblChequeNumber.Text = "Cheque Number";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::PropertyEstimationAndManagementSystem.Properties.Resources.cash;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(248, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(42, 36);
            this.panel3.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::PropertyEstimationAndManagementSystem.Properties.Resources.cheque;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(441, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(42, 36);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PropertyEstimationAndManagementSystem.Properties.Resources.money1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(230, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(42, 36);
            this.panel1.TabIndex = 12;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(769, 502);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblChequeNumber);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtChequeNumber);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.btncheque);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton btnCash;
        private System.Windows.Forms.RadioButton btncheque;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtChequeNumber;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblChequeNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
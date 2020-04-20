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
            this.SuspendLayout();
            // 
            // btnCash
            // 
            this.btnCash.AutoSize = true;
            this.btnCash.Location = new System.Drawing.Point(187, 95);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(49, 17);
            this.btnCash.TabIndex = 6;
            this.btnCash.TabStop = true;
            this.btnCash.Text = "Cash";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.CheckedChanged += new System.EventHandler(this.btnCash_CheckedChanged);
            // 
            // btncheque
            // 
            this.btncheque.AutoSize = true;
            this.btncheque.Location = new System.Drawing.Point(362, 95);
            this.btncheque.Name = "btncheque";
            this.btncheque.Size = new System.Drawing.Size(62, 17);
            this.btncheque.TabIndex = 5;
            this.btncheque.TabStop = true;
            this.btncheque.Text = "Cheque";
            this.btncheque.UseVisualStyleBackColor = true;
            this.btncheque.CheckedChanged += new System.EventHandler(this.btncheque_CheckedChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(269, 293);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtChequeNumber
            // 
            this.txtChequeNumber.Location = new System.Drawing.Point(253, 214);
            this.txtChequeNumber.Name = "txtChequeNumber";
            this.txtChequeNumber.Size = new System.Drawing.Size(100, 20);
            this.txtChequeNumber.TabIndex = 8;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(253, 156);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 9;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(193, 159);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "Amount";
            // 
            // lblChequeNumber
            // 
            this.lblChequeNumber.AutoSize = true;
            this.lblChequeNumber.Location = new System.Drawing.Point(163, 221);
            this.lblChequeNumber.Name = "lblChequeNumber";
            this.lblChequeNumber.Size = new System.Drawing.Size(84, 13);
            this.lblChequeNumber.TabIndex = 11;
            this.lblChequeNumber.Text = "Cheque Number";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 422);
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
    }
}
namespace PropertyEstimationAndManagementSystem.GuiForms.OwnerGui
{
    partial class Account
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
            this.lblCurrentBalance = new System.Windows.Forms.Label();
            this.lblCurrentBalanceValue = new System.Windows.Forms.Label();
            this.lblSellCurrentProfitPercentValue = new System.Windows.Forms.Label();
            this.lblCurrentSellProfitPercent = new System.Windows.Forms.Label();
            this.txtSellProfitPercent = new System.Windows.Forms.TextBox();
            this.btnSellProfitChange = new System.Windows.Forms.Button();
            this.lblCurrentCompanyNameValue = new System.Windows.Forms.Label();
            this.btnChangeName = new System.Windows.Forms.Button();
            this.txtChangeName = new System.Windows.Forms.TextBox();
            this.lblCurrentCompanyName = new System.Windows.Forms.Label();
            this.btnBuyChangeProperty = new System.Windows.Forms.Button();
            this.txtBuyProfitPercent = new System.Windows.Forms.TextBox();
            this.lblCurrentBuyProfitPercentValue = new System.Windows.Forms.Label();
            this.lblCurrentBuyProfitPercent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCurrentBalance
            // 
            this.lblCurrentBalance.AutoSize = true;
            this.lblCurrentBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBalance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCurrentBalance.Location = new System.Drawing.Point(419, 223);
            this.lblCurrentBalance.Name = "lblCurrentBalance";
            this.lblCurrentBalance.Size = new System.Drawing.Size(124, 20);
            this.lblCurrentBalance.TabIndex = 0;
            this.lblCurrentBalance.Text = "Current Balance";
            // 
            // lblCurrentBalanceValue
            // 
            this.lblCurrentBalanceValue.AutoSize = true;
            this.lblCurrentBalanceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBalanceValue.ForeColor = System.Drawing.Color.Yellow;
            this.lblCurrentBalanceValue.Location = new System.Drawing.Point(428, 274);
            this.lblCurrentBalanceValue.Name = "lblCurrentBalanceValue";
            this.lblCurrentBalanceValue.Size = new System.Drawing.Size(210, 31);
            this.lblCurrentBalanceValue.TabIndex = 1;
            this.lblCurrentBalanceValue.Text = "Current Balance";
            // 
            // lblSellCurrentProfitPercentValue
            // 
            this.lblSellCurrentProfitPercentValue.AutoSize = true;
            this.lblSellCurrentProfitPercentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellCurrentProfitPercentValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblSellCurrentProfitPercentValue.Location = new System.Drawing.Point(425, 58);
            this.lblSellCurrentProfitPercentValue.Name = "lblSellCurrentProfitPercentValue";
            this.lblSellCurrentProfitPercentValue.Size = new System.Drawing.Size(190, 31);
            this.lblSellCurrentProfitPercentValue.TabIndex = 3;
            this.lblSellCurrentProfitPercentValue.Text = "Current Profit";
            // 
            // lblCurrentSellProfitPercent
            // 
            this.lblCurrentSellProfitPercent.AutoSize = true;
            this.lblCurrentSellProfitPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentSellProfitPercent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCurrentSellProfitPercent.Location = new System.Drawing.Point(405, 9);
            this.lblCurrentSellProfitPercent.Name = "lblCurrentSellProfitPercent";
            this.lblCurrentSellProfitPercent.Size = new System.Drawing.Size(192, 20);
            this.lblCurrentSellProfitPercent.TabIndex = 2;
            this.lblCurrentSellProfitPercent.Text = "Current Sell Profit Percent";
            // 
            // txtSellProfitPercent
            // 
            this.txtSellProfitPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellProfitPercent.Location = new System.Drawing.Point(431, 109);
            this.txtSellProfitPercent.Name = "txtSellProfitPercent";
            this.txtSellProfitPercent.Size = new System.Drawing.Size(112, 26);
            this.txtSellProfitPercent.TabIndex = 4;
            // 
            // btnSellProfitChange
            // 
            this.btnSellProfitChange.BackColor = System.Drawing.Color.Black;
            this.btnSellProfitChange.FlatAppearance.BorderSize = 0;
            this.btnSellProfitChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellProfitChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellProfitChange.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSellProfitChange.Location = new System.Drawing.Point(433, 154);
            this.btnSellProfitChange.Name = "btnSellProfitChange";
            this.btnSellProfitChange.Size = new System.Drawing.Size(139, 32);
            this.btnSellProfitChange.TabIndex = 5;
            this.btnSellProfitChange.Text = "Change Sell Profit";
            this.btnSellProfitChange.UseVisualStyleBackColor = false;
            this.btnSellProfitChange.Click += new System.EventHandler(this.btnProfitChange_Click);
            // 
            // lblCurrentCompanyNameValue
            // 
            this.lblCurrentCompanyNameValue.AutoSize = true;
            this.lblCurrentCompanyNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentCompanyNameValue.ForeColor = System.Drawing.Color.Turquoise;
            this.lblCurrentCompanyNameValue.Location = new System.Drawing.Point(55, 58);
            this.lblCurrentCompanyNameValue.Name = "lblCurrentCompanyNameValue";
            this.lblCurrentCompanyNameValue.Size = new System.Drawing.Size(186, 29);
            this.lblCurrentCompanyNameValue.TabIndex = 6;
            this.lblCurrentCompanyNameValue.Text = "Company Name";
            // 
            // btnChangeName
            // 
            this.btnChangeName.BackColor = System.Drawing.Color.Black;
            this.btnChangeName.FlatAppearance.BorderSize = 0;
            this.btnChangeName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChangeName.Location = new System.Drawing.Point(61, 154);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Size = new System.Drawing.Size(148, 32);
            this.btnChangeName.TabIndex = 8;
            this.btnChangeName.Text = "Change Name";
            this.btnChangeName.UseVisualStyleBackColor = false;
            this.btnChangeName.Click += new System.EventHandler(this.btnChangeName_Click);
            // 
            // txtChangeName
            // 
            this.txtChangeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChangeName.Location = new System.Drawing.Point(60, 109);
            this.txtChangeName.Name = "txtChangeName";
            this.txtChangeName.Size = new System.Drawing.Size(110, 26);
            this.txtChangeName.TabIndex = 7;
            // 
            // lblCurrentCompanyName
            // 
            this.lblCurrentCompanyName.AutoSize = true;
            this.lblCurrentCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentCompanyName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCurrentCompanyName.Location = new System.Drawing.Point(32, 9);
            this.lblCurrentCompanyName.Name = "lblCurrentCompanyName";
            this.lblCurrentCompanyName.Size = new System.Drawing.Size(122, 20);
            this.lblCurrentCompanyName.TabIndex = 9;
            this.lblCurrentCompanyName.Text = "Company Name";
            // 
            // btnBuyChangeProperty
            // 
            this.btnBuyChangeProperty.BackColor = System.Drawing.Color.Black;
            this.btnBuyChangeProperty.FlatAppearance.BorderSize = 0;
            this.btnBuyChangeProperty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyChangeProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyChangeProperty.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuyChangeProperty.Location = new System.Drawing.Point(60, 378);
            this.btnBuyChangeProperty.Name = "btnBuyChangeProperty";
            this.btnBuyChangeProperty.Size = new System.Drawing.Size(150, 33);
            this.btnBuyChangeProperty.TabIndex = 13;
            this.btnBuyChangeProperty.Text = "Change Buy Profit";
            this.btnBuyChangeProperty.UseVisualStyleBackColor = false;
            this.btnBuyChangeProperty.Click += new System.EventHandler(this.btnBuyChangeProperty_Click);
            // 
            // txtBuyProfitPercent
            // 
            this.txtBuyProfitPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuyProfitPercent.Location = new System.Drawing.Point(60, 334);
            this.txtBuyProfitPercent.Name = "txtBuyProfitPercent";
            this.txtBuyProfitPercent.Size = new System.Drawing.Size(112, 26);
            this.txtBuyProfitPercent.TabIndex = 12;
            // 
            // lblCurrentBuyProfitPercentValue
            // 
            this.lblCurrentBuyProfitPercentValue.AutoSize = true;
            this.lblCurrentBuyProfitPercentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBuyProfitPercentValue.ForeColor = System.Drawing.Color.Red;
            this.lblCurrentBuyProfitPercentValue.Location = new System.Drawing.Point(51, 274);
            this.lblCurrentBuyProfitPercentValue.Name = "lblCurrentBuyProfitPercentValue";
            this.lblCurrentBuyProfitPercentValue.Size = new System.Drawing.Size(190, 31);
            this.lblCurrentBuyProfitPercentValue.TabIndex = 11;
            this.lblCurrentBuyProfitPercentValue.Text = "Current Profit";
            // 
            // lblCurrentBuyProfitPercent
            // 
            this.lblCurrentBuyProfitPercent.AutoSize = true;
            this.lblCurrentBuyProfitPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBuyProfitPercent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCurrentBuyProfitPercent.Location = new System.Drawing.Point(32, 238);
            this.lblCurrentBuyProfitPercent.Name = "lblCurrentBuyProfitPercent";
            this.lblCurrentBuyProfitPercent.Size = new System.Drawing.Size(193, 20);
            this.lblCurrentBuyProfitPercent.TabIndex = 10;
            this.lblCurrentBuyProfitPercent.Text = "Current Buy Profit Percent";
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(769, 502);
            this.Controls.Add(this.btnBuyChangeProperty);
            this.Controls.Add(this.txtBuyProfitPercent);
            this.Controls.Add(this.lblCurrentBuyProfitPercentValue);
            this.Controls.Add(this.lblCurrentBuyProfitPercent);
            this.Controls.Add(this.lblCurrentCompanyName);
            this.Controls.Add(this.btnChangeName);
            this.Controls.Add(this.txtChangeName);
            this.Controls.Add(this.lblCurrentCompanyNameValue);
            this.Controls.Add(this.btnSellProfitChange);
            this.Controls.Add(this.txtSellProfitPercent);
            this.Controls.Add(this.lblSellCurrentProfitPercentValue);
            this.Controls.Add(this.lblCurrentSellProfitPercent);
            this.Controls.Add(this.lblCurrentBalanceValue);
            this.Controls.Add(this.lblCurrentBalance);
            this.Name = "Account";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentBalance;
        private System.Windows.Forms.Label lblCurrentBalanceValue;
        private System.Windows.Forms.Label lblSellCurrentProfitPercentValue;
        private System.Windows.Forms.Label lblCurrentSellProfitPercent;
        private System.Windows.Forms.TextBox txtSellProfitPercent;
        private System.Windows.Forms.Button btnSellProfitChange;
        private System.Windows.Forms.Label lblCurrentCompanyNameValue;
        private System.Windows.Forms.Button btnChangeName;
        private System.Windows.Forms.TextBox txtChangeName;
        private System.Windows.Forms.Label lblCurrentCompanyName;
        private System.Windows.Forms.Button btnBuyChangeProperty;
        private System.Windows.Forms.TextBox txtBuyProfitPercent;
        private System.Windows.Forms.Label lblCurrentBuyProfitPercentValue;
        private System.Windows.Forms.Label lblCurrentBuyProfitPercent;
    }
}
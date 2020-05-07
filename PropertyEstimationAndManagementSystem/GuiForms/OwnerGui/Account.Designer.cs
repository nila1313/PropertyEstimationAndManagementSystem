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
            this.lblCurrentBalance.Location = new System.Drawing.Point(304, 72);
            this.lblCurrentBalance.Name = "lblCurrentBalance";
            this.lblCurrentBalance.Size = new System.Drawing.Size(83, 13);
            this.lblCurrentBalance.TabIndex = 0;
            this.lblCurrentBalance.Text = "Current Balance";
            // 
            // lblCurrentBalanceValue
            // 
            this.lblCurrentBalanceValue.AutoSize = true;
            this.lblCurrentBalanceValue.Location = new System.Drawing.Point(304, 122);
            this.lblCurrentBalanceValue.Name = "lblCurrentBalanceValue";
            this.lblCurrentBalanceValue.Size = new System.Drawing.Size(83, 13);
            this.lblCurrentBalanceValue.TabIndex = 1;
            this.lblCurrentBalanceValue.Text = "Current Balance";
            // 
            // lblSellCurrentProfitPercentValue
            // 
            this.lblSellCurrentProfitPercentValue.AutoSize = true;
            this.lblSellCurrentProfitPercentValue.Location = new System.Drawing.Point(485, 122);
            this.lblSellCurrentProfitPercentValue.Name = "lblSellCurrentProfitPercentValue";
            this.lblSellCurrentProfitPercentValue.Size = new System.Drawing.Size(68, 13);
            this.lblSellCurrentProfitPercentValue.TabIndex = 3;
            this.lblSellCurrentProfitPercentValue.Text = "Current Profit";
            // 
            // lblCurrentSellProfitPercent
            // 
            this.lblCurrentSellProfitPercent.AutoSize = true;
            this.lblCurrentSellProfitPercent.Location = new System.Drawing.Point(467, 59);
            this.lblCurrentSellProfitPercent.Name = "lblCurrentSellProfitPercent";
            this.lblCurrentSellProfitPercent.Size = new System.Drawing.Size(128, 13);
            this.lblCurrentSellProfitPercent.TabIndex = 2;
            this.lblCurrentSellProfitPercent.Text = "Current Sell Profit Percent";
            // 
            // txtSellProfitPercent
            // 
            this.txtSellProfitPercent.Location = new System.Drawing.Point(470, 189);
            this.txtSellProfitPercent.Name = "txtSellProfitPercent";
            this.txtSellProfitPercent.Size = new System.Drawing.Size(112, 20);
            this.txtSellProfitPercent.TabIndex = 4;
            // 
            // btnSellProfitChange
            // 
            this.btnSellProfitChange.Location = new System.Drawing.Point(472, 245);
            this.btnSellProfitChange.Name = "btnSellProfitChange";
            this.btnSellProfitChange.Size = new System.Drawing.Size(110, 23);
            this.btnSellProfitChange.TabIndex = 5;
            this.btnSellProfitChange.Text = "Change Sell Profit";
            this.btnSellProfitChange.UseVisualStyleBackColor = true;
            this.btnSellProfitChange.Click += new System.EventHandler(this.btnProfitChange_Click);
            // 
            // lblCurrentCompanyNameValue
            // 
            this.lblCurrentCompanyNameValue.AutoSize = true;
            this.lblCurrentCompanyNameValue.Location = new System.Drawing.Point(109, 122);
            this.lblCurrentCompanyNameValue.Name = "lblCurrentCompanyNameValue";
            this.lblCurrentCompanyNameValue.Size = new System.Drawing.Size(82, 13);
            this.lblCurrentCompanyNameValue.TabIndex = 6;
            this.lblCurrentCompanyNameValue.Text = "Company Name";
            // 
            // btnChangeName
            // 
            this.btnChangeName.Location = new System.Drawing.Point(102, 245);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Size = new System.Drawing.Size(110, 23);
            this.btnChangeName.TabIndex = 8;
            this.btnChangeName.Text = "Change Name";
            this.btnChangeName.UseVisualStyleBackColor = true;
            this.btnChangeName.Click += new System.EventHandler(this.btnChangeName_Click);
            // 
            // txtChangeName
            // 
            this.txtChangeName.Location = new System.Drawing.Point(102, 189);
            this.txtChangeName.Name = "txtChangeName";
            this.txtChangeName.Size = new System.Drawing.Size(110, 20);
            this.txtChangeName.TabIndex = 7;
            // 
            // lblCurrentCompanyName
            // 
            this.lblCurrentCompanyName.AutoSize = true;
            this.lblCurrentCompanyName.Location = new System.Drawing.Point(109, 59);
            this.lblCurrentCompanyName.Name = "lblCurrentCompanyName";
            this.lblCurrentCompanyName.Size = new System.Drawing.Size(82, 13);
            this.lblCurrentCompanyName.TabIndex = 9;
            this.lblCurrentCompanyName.Text = "Company Name";
            // 
            // btnBuyChangeProperty
            // 
            this.btnBuyChangeProperty.Location = new System.Drawing.Point(309, 355);
            this.btnBuyChangeProperty.Name = "btnBuyChangeProperty";
            this.btnBuyChangeProperty.Size = new System.Drawing.Size(110, 23);
            this.btnBuyChangeProperty.TabIndex = 13;
            this.btnBuyChangeProperty.Text = "Change Buy Profit";
            this.btnBuyChangeProperty.UseVisualStyleBackColor = true;
            this.btnBuyChangeProperty.Click += new System.EventHandler(this.btnBuyChangeProperty_Click);
            // 
            // txtBuyProfitPercent
            // 
            this.txtBuyProfitPercent.Location = new System.Drawing.Point(307, 299);
            this.txtBuyProfitPercent.Name = "txtBuyProfitPercent";
            this.txtBuyProfitPercent.Size = new System.Drawing.Size(112, 20);
            this.txtBuyProfitPercent.TabIndex = 12;
            // 
            // lblCurrentBuyProfitPercentValue
            // 
            this.lblCurrentBuyProfitPercentValue.AutoSize = true;
            this.lblCurrentBuyProfitPercentValue.Location = new System.Drawing.Point(319, 255);
            this.lblCurrentBuyProfitPercentValue.Name = "lblCurrentBuyProfitPercentValue";
            this.lblCurrentBuyProfitPercentValue.Size = new System.Drawing.Size(68, 13);
            this.lblCurrentBuyProfitPercentValue.TabIndex = 11;
            this.lblCurrentBuyProfitPercentValue.Text = "Current Profit";
            // 
            // lblCurrentBuyProfitPercent
            // 
            this.lblCurrentBuyProfitPercent.AutoSize = true;
            this.lblCurrentBuyProfitPercent.Location = new System.Drawing.Point(304, 224);
            this.lblCurrentBuyProfitPercent.Name = "lblCurrentBuyProfitPercent";
            this.lblCurrentBuyProfitPercent.Size = new System.Drawing.Size(129, 13);
            this.lblCurrentBuyProfitPercent.TabIndex = 10;
            this.lblCurrentBuyProfitPercent.Text = "Current Buy Profit Percent";
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
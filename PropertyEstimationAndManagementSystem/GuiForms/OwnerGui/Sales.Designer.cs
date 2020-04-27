namespace PropertyEstimationAndManagementSystem.GuiForms.OwnerGui
{
    partial class Sales
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
            this.lblSaleEstimationTomorrow = new System.Windows.Forms.Label();
            this.lblSaleEstimationTomorrowValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSaleEstimationTomorrow
            // 
            this.lblSaleEstimationTomorrow.AutoSize = true;
            this.lblSaleEstimationTomorrow.Location = new System.Drawing.Point(24, 30);
            this.lblSaleEstimationTomorrow.Name = "lblSaleEstimationTomorrow";
            this.lblSaleEstimationTomorrow.Size = new System.Drawing.Size(127, 13);
            this.lblSaleEstimationTomorrow.TabIndex = 0;
            this.lblSaleEstimationTomorrow.Text = "Estimated Sale Tomorrow";
            // 
            // lblSaleEstimationTomorrowValue
            // 
            this.lblSaleEstimationTomorrowValue.AutoSize = true;
            this.lblSaleEstimationTomorrowValue.Location = new System.Drawing.Point(185, 30);
            this.lblSaleEstimationTomorrowValue.Name = "lblSaleEstimationTomorrowValue";
            this.lblSaleEstimationTomorrowValue.Size = new System.Drawing.Size(127, 13);
            this.lblSaleEstimationTomorrowValue.TabIndex = 1;
            this.lblSaleEstimationTomorrowValue.Text = "Estimated Sale Tomorrow";
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSaleEstimationTomorrowValue);
            this.Controls.Add(this.lblSaleEstimationTomorrow);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaleEstimationTomorrow;
        private System.Windows.Forms.Label lblSaleEstimationTomorrowValue;
    }
}
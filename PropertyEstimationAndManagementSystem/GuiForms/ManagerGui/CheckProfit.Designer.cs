namespace PropertyEstimationAndManagementSystem.GuiForms.ManagerGui
{
    partial class CheckProfit
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TotalTransaction = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TotalProfit = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TotalSalary = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.NetProfit = new System.Windows.Forms.Label();
            this.Profit = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TotalTransaction);
            this.panel1.Location = new System.Drawing.Point(45, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 78);
            this.panel1.TabIndex = 0;
            // 
            // TotalTransaction
            // 
            this.TotalTransaction.AutoSize = true;
            this.TotalTransaction.Location = new System.Drawing.Point(44, 35);
            this.TotalTransaction.Name = "TotalTransaction";
            this.TotalTransaction.Size = new System.Drawing.Size(90, 13);
            this.TotalTransaction.TabIndex = 0;
            this.TotalTransaction.Text = "Total Transaction";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TotalProfit);
            this.panel2.Location = new System.Drawing.Point(284, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 78);
            this.panel2.TabIndex = 1;
            // 
            // TotalProfit
            // 
            this.TotalProfit.AutoSize = true;
            this.TotalProfit.Location = new System.Drawing.Point(49, 35);
            this.TotalProfit.Name = "TotalProfit";
            this.TotalProfit.Size = new System.Drawing.Size(58, 13);
            this.TotalProfit.TabIndex = 0;
            this.TotalProfit.Text = "Total Profit";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TotalSalary);
            this.panel3.Location = new System.Drawing.Point(45, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 60);
            this.panel3.TabIndex = 2;
            // 
            // TotalSalary
            // 
            this.TotalSalary.AutoSize = true;
            this.TotalSalary.Location = new System.Drawing.Point(43, 24);
            this.TotalSalary.Name = "TotalSalary";
            this.TotalSalary.Size = new System.Drawing.Size(63, 13);
            this.TotalSalary.TabIndex = 0;
            this.TotalSalary.Text = "Total Salary";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.NetProfit);
            this.panel4.Location = new System.Drawing.Point(284, 160);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(148, 69);
            this.panel4.TabIndex = 3;
            // 
            // NetProfit
            // 
            this.NetProfit.AutoSize = true;
            this.NetProfit.Location = new System.Drawing.Point(49, 24);
            this.NetProfit.Name = "NetProfit";
            this.NetProfit.Size = new System.Drawing.Size(51, 13);
            this.NetProfit.TabIndex = 0;
            this.NetProfit.Text = "Net Profit";
            // 
            // Profit
            // 
            chartArea2.Name = "ChartArea1";
            this.Profit.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Profit.Legends.Add(legend2);
            this.Profit.Location = new System.Drawing.Point(476, 54);
            this.Profit.Name = "Profit";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.Profit.Series.Add(series2);
            this.Profit.Size = new System.Drawing.Size(300, 300);
            this.Profit.TabIndex = 4;
            // 
            // CheckProfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 407);
            this.Controls.Add(this.Profit);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CheckProfit";
            this.Text = "CheckProfit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TotalTransaction;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TotalProfit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label TotalSalary;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label NetProfit;
        private System.Windows.Forms.DataVisualization.Charting.Chart Profit;
    }
}
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblSaleEstimationTomorrow = new System.Windows.Forms.Label();
            this.lblSaleEstimationTomorrowValue = new System.Windows.Forms.Label();
            this.lblEstimatedBuyTomorrow = new System.Windows.Forms.Label();
            this.lblEstimatedBuyTomorrowValue = new System.Windows.Forms.Label();
            this.lblTotalSaleToday = new System.Windows.Forms.Label();
            this.lblTotalSaleTodayValue = new System.Windows.Forms.Label();
            this.lblTotalBuyToday = new System.Windows.Forms.Label();
            this.lblTotalBuyTodayValue = new System.Windows.Forms.Label();
            this.chartBuySell = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartBuySell)).BeginInit();
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
            // lblEstimatedBuyTomorrow
            // 
            this.lblEstimatedBuyTomorrow.AutoSize = true;
            this.lblEstimatedBuyTomorrow.Location = new System.Drawing.Point(24, 84);
            this.lblEstimatedBuyTomorrow.Name = "lblEstimatedBuyTomorrow";
            this.lblEstimatedBuyTomorrow.Size = new System.Drawing.Size(124, 13);
            this.lblEstimatedBuyTomorrow.TabIndex = 2;
            this.lblEstimatedBuyTomorrow.Text = "Estimated Buy Tomorrow";
            // 
            // lblEstimatedBuyTomorrowValue
            // 
            this.lblEstimatedBuyTomorrowValue.AutoSize = true;
            this.lblEstimatedBuyTomorrowValue.Location = new System.Drawing.Point(188, 84);
            this.lblEstimatedBuyTomorrowValue.Name = "lblEstimatedBuyTomorrowValue";
            this.lblEstimatedBuyTomorrowValue.Size = new System.Drawing.Size(124, 13);
            this.lblEstimatedBuyTomorrowValue.TabIndex = 3;
            this.lblEstimatedBuyTomorrowValue.Text = "Estimated Buy Tomorrow";
            // 
            // lblTotalSaleToday
            // 
            this.lblTotalSaleToday.AutoSize = true;
            this.lblTotalSaleToday.Location = new System.Drawing.Point(435, 30);
            this.lblTotalSaleToday.Name = "lblTotalSaleToday";
            this.lblTotalSaleToday.Size = new System.Drawing.Size(88, 13);
            this.lblTotalSaleToday.TabIndex = 4;
            this.lblTotalSaleToday.Text = "Total Sale Today";
            // 
            // lblTotalSaleTodayValue
            // 
            this.lblTotalSaleTodayValue.AutoSize = true;
            this.lblTotalSaleTodayValue.Location = new System.Drawing.Point(630, 30);
            this.lblTotalSaleTodayValue.Name = "lblTotalSaleTodayValue";
            this.lblTotalSaleTodayValue.Size = new System.Drawing.Size(88, 13);
            this.lblTotalSaleTodayValue.TabIndex = 5;
            this.lblTotalSaleTodayValue.Text = "Total Sale Today";
            // 
            // lblTotalBuyToday
            // 
            this.lblTotalBuyToday.AutoSize = true;
            this.lblTotalBuyToday.Location = new System.Drawing.Point(435, 84);
            this.lblTotalBuyToday.Name = "lblTotalBuyToday";
            this.lblTotalBuyToday.Size = new System.Drawing.Size(85, 13);
            this.lblTotalBuyToday.TabIndex = 6;
            this.lblTotalBuyToday.Text = "Total Buy Today";
            // 
            // lblTotalBuyTodayValue
            // 
            this.lblTotalBuyTodayValue.AutoSize = true;
            this.lblTotalBuyTodayValue.Location = new System.Drawing.Point(630, 84);
            this.lblTotalBuyTodayValue.Name = "lblTotalBuyTodayValue";
            this.lblTotalBuyTodayValue.Size = new System.Drawing.Size(88, 13);
            this.lblTotalBuyTodayValue.TabIndex = 7;
            this.lblTotalBuyTodayValue.Text = "Total Sale Today";
            // 
            // chartBuySell
            // 
            chartArea1.Name = "ChartArea1";
            this.chartBuySell.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartBuySell.Legends.Add(legend1);
            this.chartBuySell.Location = new System.Drawing.Point(148, 146);
            this.chartBuySell.Name = "chartBuySell";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "s1";
            this.chartBuySell.Series.Add(series1);
            this.chartBuySell.Size = new System.Drawing.Size(452, 292);
            this.chartBuySell.TabIndex = 8;
            this.chartBuySell.Text = "Buy-Sale";
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartBuySell);
            this.Controls.Add(this.lblTotalBuyTodayValue);
            this.Controls.Add(this.lblTotalBuyToday);
            this.Controls.Add(this.lblTotalSaleTodayValue);
            this.Controls.Add(this.lblTotalSaleToday);
            this.Controls.Add(this.lblEstimatedBuyTomorrowValue);
            this.Controls.Add(this.lblEstimatedBuyTomorrow);
            this.Controls.Add(this.lblSaleEstimationTomorrowValue);
            this.Controls.Add(this.lblSaleEstimationTomorrow);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartBuySell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaleEstimationTomorrow;
        private System.Windows.Forms.Label lblSaleEstimationTomorrowValue;
        private System.Windows.Forms.Label lblEstimatedBuyTomorrow;
        private System.Windows.Forms.Label lblEstimatedBuyTomorrowValue;
        private System.Windows.Forms.Label lblTotalSaleToday;
        private System.Windows.Forms.Label lblTotalSaleTodayValue;
        private System.Windows.Forms.Label lblTotalBuyToday;
        private System.Windows.Forms.Label lblTotalBuyTodayValue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBuySell;
    }
}
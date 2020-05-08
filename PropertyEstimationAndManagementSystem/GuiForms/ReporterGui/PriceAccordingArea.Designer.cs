﻿namespace PropertyEstimationAndManagementSystem.GuiForms.Consultant
{
    partial class PriceAccordingArea
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
            this.dataGridArea = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblPriceAccordingArea = new System.Windows.Forms.Label();
            this.lblAreaName = new System.Windows.Forms.Label();
            this.txtAreaName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chartArea = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartArea)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridArea
            // 
            this.dataGridArea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridArea.Location = new System.Drawing.Point(33, 143);
            this.dataGridArea.Name = "dataGridArea";
            this.dataGridArea.RowHeadersWidth = 51;
            this.dataGridArea.Size = new System.Drawing.Size(342, 301);
            this.dataGridArea.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(44, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblPriceAccordingArea
            // 
            this.lblPriceAccordingArea.AutoSize = true;
            this.lblPriceAccordingArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceAccordingArea.Location = new System.Drawing.Point(28, 56);
            this.lblPriceAccordingArea.Name = "lblPriceAccordingArea";
            this.lblPriceAccordingArea.Size = new System.Drawing.Size(214, 25);
            this.lblPriceAccordingArea.TabIndex = 3;
            this.lblPriceAccordingArea.Text = "Price According Area";
            // 
            // lblAreaName
            // 
            this.lblAreaName.AutoSize = true;
            this.lblAreaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaName.Location = new System.Drawing.Point(29, 87);
            this.lblAreaName.Name = "lblAreaName";
            this.lblAreaName.Size = new System.Drawing.Size(89, 20);
            this.lblAreaName.TabIndex = 4;
            this.lblAreaName.Text = "Area Name";
            // 
            // txtAreaName
            // 
            this.txtAreaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAreaName.Location = new System.Drawing.Point(124, 84);
            this.txtAreaName.Name = "txtAreaName";
            this.txtAreaName.Size = new System.Drawing.Size(162, 26);
            this.txtAreaName.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::PropertyEstimationAndManagementSystem.Properties.Resources.download1;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(292, 77);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(39, 33);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // chartArea
            // 
            chartArea1.Name = "ChartArea1";
            this.chartArea.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartArea.Legends.Add(legend1);
            this.chartArea.Location = new System.Drawing.Point(412, 133);
            this.chartArea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartArea.Name = "chartArea";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "s1";
            series1.YValuesPerPoint = 3;
            this.chartArea.Series.Add(series1);
            this.chartArea.Size = new System.Drawing.Size(262, 254);
            this.chartArea.TabIndex = 7;
            this.chartArea.Text = "chartBar";
            // 
            // PriceAccordingArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(767, 492);
            this.Controls.Add(this.chartArea);
            this.Controls.Add(this.txtAreaName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblAreaName);
            this.Controls.Add(this.lblPriceAccordingArea);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridArea);
            this.Name = "PriceAccordingArea";
            this.Text = "PriceAccordingArea";
            this.Load += new System.EventHandler(this.PriceAccordingArea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridArea;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPriceAccordingArea;
        private System.Windows.Forms.Label lblAreaName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtAreaName;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartArea;
    }
}
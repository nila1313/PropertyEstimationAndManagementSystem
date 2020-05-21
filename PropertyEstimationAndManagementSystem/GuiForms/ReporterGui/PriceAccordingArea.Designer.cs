namespace PropertyEstimationAndManagementSystem.GuiForms.Consultant
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
            this.chartArea = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartArea)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridArea
            // 
            this.dataGridArea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridArea.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.dataGridArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridArea.Location = new System.Drawing.Point(33, 190);
            this.dataGridArea.Name = "dataGridArea";
            this.dataGridArea.RowHeadersWidth = 51;
            this.dataGridArea.Size = new System.Drawing.Size(342, 254);
            this.dataGridArea.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(55, 41);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblPriceAccordingArea
            // 
            this.lblPriceAccordingArea.AutoSize = true;
            this.lblPriceAccordingArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceAccordingArea.Location = new System.Drawing.Point(275, 48);
            this.lblPriceAccordingArea.Name = "lblPriceAccordingArea";
            this.lblPriceAccordingArea.Size = new System.Drawing.Size(239, 29);
            this.lblPriceAccordingArea.TabIndex = 3;
            this.lblPriceAccordingArea.Text = "Price According Area";
            // 
            // lblAreaName
            // 
            this.lblAreaName.AutoSize = true;
            this.lblAreaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaName.Location = new System.Drawing.Point(42, 97);
            this.lblAreaName.Name = "lblAreaName";
            this.lblAreaName.Size = new System.Drawing.Size(222, 24);
            this.lblAreaName.TabIndex = 4;
            this.lblAreaName.Text = "Search for Area by Name";
            // 
            // txtAreaName
            // 
            this.txtAreaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAreaName.Location = new System.Drawing.Point(46, 143);
            this.txtAreaName.Name = "txtAreaName";
            this.txtAreaName.Size = new System.Drawing.Size(162, 26);
            this.txtAreaName.TabIndex = 6;
            // 
            // chartArea
            // 
            chartArea1.Name = "ChartArea1";
            this.chartArea.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartArea.Legends.Add(legend1);
            this.chartArea.Location = new System.Drawing.Point(419, 190);
            this.chartArea.Margin = new System.Windows.Forms.Padding(2);
            this.chartArea.Name = "chartArea";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "s1";
            series1.YValuesPerPoint = 3;
            this.chartArea.Series.Add(series1);
            this.chartArea.Size = new System.Drawing.Size(321, 254);
            this.chartArea.TabIndex = 7;
            this.chartArea.Text = "chartBar";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::PropertyEstimationAndManagementSystem.Properties.Resources.search_log_f;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(229, 139);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(44, 36);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // PriceAccordingArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(767, 492);
            this.Controls.Add(this.chartArea);
            this.Controls.Add(this.txtAreaName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblAreaName);
            this.Controls.Add(this.lblPriceAccordingArea);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridArea);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
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
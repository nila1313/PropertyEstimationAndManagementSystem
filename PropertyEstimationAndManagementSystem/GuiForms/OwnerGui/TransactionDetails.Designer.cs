namespace PropertyEstimationAndManagementSystem.GuiForms.OwnerGui
{
    partial class TransactionDetails
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
            this.btnToday = new System.Windows.Forms.Button();
            this.btnThisWeek = new System.Windows.Forms.Button();
            this.lblProperty = new System.Windows.Forms.Label();
            this.btnThisYear = new System.Windows.Forms.Button();
            this.radioButtonSold = new System.Windows.Forms.RadioButton();
            this.radioButtonBought = new System.Windows.Forms.RadioButton();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(148, 471);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(75, 23);
            this.btnToday.TabIndex = 0;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnThisWeek
            // 
            this.btnThisWeek.Location = new System.Drawing.Point(542, 471);
            this.btnThisWeek.Name = "btnThisWeek";
            this.btnThisWeek.Size = new System.Drawing.Size(75, 23);
            this.btnThisWeek.TabIndex = 1;
            this.btnThisWeek.Text = "This Week";
            this.btnThisWeek.UseVisualStyleBackColor = true;
            this.btnThisWeek.Click += new System.EventHandler(this.btnThisWeek_Click);
            // 
            // lblProperty
            // 
            this.lblProperty.AutoSize = true;
            this.lblProperty.Location = new System.Drawing.Point(393, 42);
            this.lblProperty.Name = "lblProperty";
            this.lblProperty.Size = new System.Drawing.Size(83, 13);
            this.lblProperty.TabIndex = 4;
            this.lblProperty.Text = "Property Bought";
            // 
            // btnThisYear
            // 
            this.btnThisYear.Location = new System.Drawing.Point(926, 471);
            this.btnThisYear.Name = "btnThisYear";
            this.btnThisYear.Size = new System.Drawing.Size(75, 23);
            this.btnThisYear.TabIndex = 6;
            this.btnThisYear.Text = "This Year";
            this.btnThisYear.UseVisualStyleBackColor = true;
            this.btnThisYear.Click += new System.EventHandler(this.btnThisYear_Click);
            // 
            // radioButtonSold
            // 
            this.radioButtonSold.AutoSize = true;
            this.radioButtonSold.Location = new System.Drawing.Point(196, 40);
            this.radioButtonSold.Name = "radioButtonSold";
            this.radioButtonSold.Size = new System.Drawing.Size(88, 17);
            this.radioButtonSold.TabIndex = 11;
            this.radioButtonSold.TabStop = true;
            this.radioButtonSold.Text = "Property Sold";
            this.radioButtonSold.UseVisualStyleBackColor = true;
            this.radioButtonSold.CheckedChanged += new System.EventHandler(this.radioButtonSold_CheckedChanged);
            // 
            // radioButtonBought
            // 
            this.radioButtonBought.AutoSize = true;
            this.radioButtonBought.Location = new System.Drawing.Point(46, 40);
            this.radioButtonBought.Name = "radioButtonBought";
            this.radioButtonBought.Size = new System.Drawing.Size(101, 17);
            this.radioButtonBought.TabIndex = 10;
            this.radioButtonBought.TabStop = true;
            this.radioButtonBought.Text = "Property Bought";
            this.radioButtonBought.UseVisualStyleBackColor = true;
            this.radioButtonBought.CheckedChanged += new System.EventHandler(this.radioButtonBought_CheckedChanged);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToOrderColumns = true;
            this.dataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(32)))));
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.PropertyId,
            this.EmployeeID,
            this.Amount,
            this.Date,
            this.Type,
            this.Trade});
            this.dataGrid.Location = new System.Drawing.Point(12, 89);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(1082, 356);
            this.dataGrid.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1041, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(53, 44);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Seach";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(835, 36);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 7;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerId";
            this.CustomerID.HeaderText = "Customer ID";
            this.CustomerID.Name = "CustomerID";
            // 
            // PropertyId
            // 
            this.PropertyId.DataPropertyName = "PropertyId";
            this.PropertyId.HeaderText = "Property ID";
            this.PropertyId.Name = "PropertyId";
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeId";
            this.EmployeeID.HeaderText = "Employee ID";
            this.EmployeeID.Name = "EmployeeID";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.Width = 120;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "TransactionDateTime";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Width = 150;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "TransactionType";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.Width = 120;
            // 
            // Trade
            // 
            this.Trade.DataPropertyName = "Trade";
            this.Trade.HeaderText = "Trade Type";
            this.Trade.Name = "Trade";
            this.Trade.Width = 150;
            // 
            // TransactionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1106, 563);
            this.Controls.Add(this.btnThisYear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btnThisWeek);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.radioButtonSold);
            this.Controls.Add(this.lblProperty);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.radioButtonBought);
            this.Name = "TransactionDetails";
            this.Text = "Transaction Details";
            this.Load += new System.EventHandler(this.TransactionDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnThisWeek;
        private System.Windows.Forms.Label lblProperty;
        private System.Windows.Forms.Button btnThisYear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.RadioButton radioButtonSold;
        private System.Windows.Forms.RadioButton radioButtonBought;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trade;
    }
}
namespace PropertyEstimationAndManagementSystem.GuiForms.Consultant
{
    partial class Search
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
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.BtnSell = new System.Windows.Forms.Button();
            this.dataGridProperty = new System.Windows.Forms.DataGridView();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.btnPropertySearch = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProperty)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(27, 70);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 0;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(289, 70);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 20);
            this.txtSize.TabIndex = 1;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(152, 70);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 2;
            // 
            // BtnSell
            // 
            this.BtnSell.Location = new System.Drawing.Point(373, 169);
            this.BtnSell.Name = "BtnSell";
            this.BtnSell.Size = new System.Drawing.Size(75, 23);
            this.BtnSell.TabIndex = 4;
            this.BtnSell.Text = "Sell";
            this.BtnSell.UseVisualStyleBackColor = true;
            this.BtnSell.Click += new System.EventHandler(this.BtnSell_Click);
            // 
            // dataGridProperty
            // 
            this.dataGridProperty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProperty.Location = new System.Drawing.Point(54, 169);
            this.dataGridProperty.Name = "dataGridProperty";
            this.dataGridProperty.Size = new System.Drawing.Size(300, 159);
            this.dataGridProperty.TabIndex = 5;
            this.dataGridProperty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProperty_CellClick);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(190, 45);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(29, 13);
            this.lblArea.TabIndex = 7;
            this.lblArea.Text = "Area";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(51, 45);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(319, 45);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(27, 13);
            this.lblSize.TabIndex = 9;
            this.lblSize.Text = "Size";
            // 
            // btnPropertySearch
            // 
            this.btnPropertySearch.Location = new System.Drawing.Point(373, 198);
            this.btnPropertySearch.Name = "btnPropertySearch";
            this.btnPropertySearch.Size = new System.Drawing.Size(75, 23);
            this.btnPropertySearch.TabIndex = 12;
            this.btnPropertySearch.Text = "Search";
            this.btnPropertySearch.UseVisualStyleBackColor = true;
            this.btnPropertySearch.Click += new System.EventHandler(this.btnPropertySearch_Click);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(373, 227);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(75, 23);
            this.btnBook.TabIndex = 13;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(-2, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = ">";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 492);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnPropertySearch);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.dataGridProperty);
            this.Controls.Add(this.BtnSell);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtPrice);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProperty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button BtnSell;
        private System.Windows.Forms.DataGridView dataGridProperty;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Button btnPropertySearch;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnBack;
    }
}
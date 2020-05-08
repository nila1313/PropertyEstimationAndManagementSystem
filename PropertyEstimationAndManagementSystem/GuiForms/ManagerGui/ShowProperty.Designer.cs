namespace PropertyEstimationAndManagementSystem.GuiForms.ManagerGui
{
    partial class ShowProperty
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
            this.dataGridProperty = new System.Windows.Forms.DataGridView();
            this.lblShowProperty = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProperty)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridProperty
            // 
            this.dataGridProperty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProperty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProperty.Location = new System.Drawing.Point(12, 64);
            this.dataGridProperty.Name = "dataGridProperty";
            this.dataGridProperty.Size = new System.Drawing.Size(776, 326);
            this.dataGridProperty.TabIndex = 0;
            this.dataGridProperty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProperty_CellClick);
            // 
            // lblShowProperty
            // 
            this.lblShowProperty.AutoSize = true;
            this.lblShowProperty.Location = new System.Drawing.Point(25, 31);
            this.lblShowProperty.Name = "lblShowProperty";
            this.lblShowProperty.Size = new System.Drawing.Size(90, 13);
            this.lblShowProperty.TabIndex = 1;
            this.lblShowProperty.Text = "Show All Property";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(526, 31);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(181, 20);
            this.txtPrice.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(713, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "button1";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(121, 28);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(181, 20);
            this.txtArea.TabIndex = 4;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(329, 31);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(181, 20);
            this.txtSize.TabIndex = 5;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(348, 415);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 23);
            this.btnShowAll.TabIndex = 6;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // ShowProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblShowProperty);
            this.Controls.Add(this.dataGridProperty);
            this.Name = "ShowProperty";
            this.Text = "ShowProperty";
            this.Load += new System.EventHandler(this.ShowProperty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProperty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProperty;
        private System.Windows.Forms.Label lblShowProperty;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Button btnShowAll;
    }
}
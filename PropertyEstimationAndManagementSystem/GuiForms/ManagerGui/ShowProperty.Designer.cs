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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProperty)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridProperty
            // 
            this.dataGridProperty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProperty.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.dataGridProperty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProperty.Location = new System.Drawing.Point(215, 64);
            this.dataGridProperty.Name = "dataGridProperty";
            this.dataGridProperty.Size = new System.Drawing.Size(573, 326);
            this.dataGridProperty.TabIndex = 0;
            this.dataGridProperty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProperty_CellClick);
            // 
            // lblShowProperty
            // 
            this.lblShowProperty.AutoSize = true;
            this.lblShowProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowProperty.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblShowProperty.Location = new System.Drawing.Point(416, 28);
            this.lblShowProperty.Name = "lblShowProperty";
            this.lblShowProperty.Size = new System.Drawing.Size(133, 20);
            this.lblShowProperty.TabIndex = 1;
            this.lblShowProperty.Text = "Show All Property";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPrice.Location = new System.Drawing.Point(28, 206);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(181, 20);
            this.txtPrice.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(139, 59);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(57, 20);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtArea
            // 
            this.txtArea.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtArea.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtArea.Location = new System.Drawing.Point(28, 80);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(181, 20);
            this.txtArea.TabIndex = 4;
            // 
            // txtSize
            // 
            this.txtSize.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtSize.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSize.Location = new System.Drawing.Point(28, 143);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(181, 20);
            this.txtSize.TabIndex = 5;
            // 
            // btnShowAll
            // 
            this.btnShowAll.FlatAppearance.BorderSize = 0;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnShowAll.Location = new System.Drawing.Point(420, 396);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 23);
            this.btnShowAll.TabIndex = 6;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(26, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search By Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(26, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Search By Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(25, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Search by Area";
            // 
            // ShowProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
namespace PropertyEstimationAndManagementSystem.GuiForms.Consultant
{
    partial class UnsoldPropertyList
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
            this.dataGridPropertyList = new System.Windows.Forms.DataGridView();
            this.lblPropertyList = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPropertyList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPropertyList
            // 
            this.dataGridPropertyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPropertyList.Location = new System.Drawing.Point(84, 98);
            this.dataGridPropertyList.Name = "dataGridPropertyList";
            this.dataGridPropertyList.Size = new System.Drawing.Size(425, 182);
            this.dataGridPropertyList.TabIndex = 0;
            this.dataGridPropertyList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPropertyList_CellClick);
            // 
            // lblPropertyList
            // 
            this.lblPropertyList.AutoSize = true;
            this.lblPropertyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropertyList.Location = new System.Drawing.Point(98, 49);
            this.lblPropertyList.Name = "lblPropertyList";
            this.lblPropertyList.Size = new System.Drawing.Size(128, 20);
            this.lblPropertyList.TabIndex = 1;
            this.lblPropertyList.Text = "List of Properties";
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(111, 305);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 23);
            this.btnBuy.TabIndex = 2;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // UnsoldPropertyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.lblPropertyList);
            this.Controls.Add(this.dataGridPropertyList);
            this.Name = "UnsoldPropertyList";
            this.Text = "UnsoldPropertyList";
            this.Load += new System.EventHandler(this.UnsoldPropertyList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPropertyList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPropertyList;
        private System.Windows.Forms.Label lblPropertyList;
        private System.Windows.Forms.Button btnBuy;
    }
}
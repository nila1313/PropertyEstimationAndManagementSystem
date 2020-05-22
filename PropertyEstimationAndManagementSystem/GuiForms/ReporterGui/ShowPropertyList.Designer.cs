namespace PropertyEstimationAndManagementSystem.GuiForms.ReporterGui
{
    partial class ShowPropertyList
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
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDescription = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPropertyList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPropertyList
            // 
            this.dataGridPropertyList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.dataGridPropertyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPropertyList.Location = new System.Drawing.Point(34, 112);
            this.dataGridPropertyList.Name = "dataGridPropertyList";
            this.dataGridPropertyList.Size = new System.Drawing.Size(419, 271);
            this.dataGridPropertyList.TabIndex = 0;
            this.dataGridPropertyList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPropertyList_CellClick);
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.BackColor = System.Drawing.Color.Black;
            this.btnCreateNew.FlatAppearance.BorderSize = 0;
            this.btnCreateNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNew.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCreateNew.Location = new System.Drawing.Point(514, 112);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(111, 28);
            this.btnCreateNew.TabIndex = 1;
            this.btnCreateNew.Text = "Create New";
            this.btnCreateNew.UseVisualStyleBackColor = false;
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(514, 194);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 28);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Black;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRemove.Location = new System.Drawing.Point(514, 271);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(111, 28);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnDescription
            // 
            this.btnDescription.BackColor = System.Drawing.Color.Black;
            this.btnDescription.FlatAppearance.BorderSize = 0;
            this.btnDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDescription.Location = new System.Drawing.Point(514, 350);
            this.btnDescription.Name = "btnDescription";
            this.btnDescription.Size = new System.Drawing.Size(111, 33);
            this.btnDescription.TabIndex = 4;
            this.btnDescription.Text = "Description";
            this.btnDescription.UseVisualStyleBackColor = false;
            this.btnDescription.Click += new System.EventHandler(this.btnDescription_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(179, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Property List";
            // 
            // ShowPropertyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(769, 502);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDescription);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreateNew);
            this.Controls.Add(this.dataGridPropertyList);
            this.Name = "ShowPropertyList";
            this.Text = "ShowPropertyList";
            this.Load += new System.EventHandler(this.ShowPropertyList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPropertyList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPropertyList;
        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDescription;
        private System.Windows.Forms.Label label1;
    }
}
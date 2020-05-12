namespace PropertyEstimationAndManagementSystem.GuiForms.OwnerGui
{
    partial class CheckFeedBack
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
            this.dataGridShowFeedBack = new System.Windows.Forms.DataGridView();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDescriptionValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShowFeedBack)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridShowFeedBack
            // 
            this.dataGridShowFeedBack.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridShowFeedBack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridShowFeedBack.Location = new System.Drawing.Point(59, 47);
            this.dataGridShowFeedBack.Name = "dataGridShowFeedBack";
            this.dataGridShowFeedBack.Size = new System.Drawing.Size(338, 199);
            this.dataGridShowFeedBack.TabIndex = 0;
            this.dataGridShowFeedBack.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridShowFeedBack_CellClick);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(56, 279);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // lblDescriptionValue
            // 
            this.lblDescriptionValue.AutoSize = true;
            this.lblDescriptionValue.Location = new System.Drawing.Point(56, 322);
            this.lblDescriptionValue.Name = "lblDescriptionValue";
            this.lblDescriptionValue.Size = new System.Drawing.Size(35, 13);
            this.lblDescriptionValue.TabIndex = 2;
            this.lblDescriptionValue.Text = "label1";
            // 
            // CheckFeedBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDescriptionValue);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.dataGridShowFeedBack);
            this.Name = "CheckFeedBack";
            this.Text = "CheckFeedBack";
            this.Load += new System.EventHandler(this.CheckFeedBack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShowFeedBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridShowFeedBack;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDescriptionValue;
    }
}
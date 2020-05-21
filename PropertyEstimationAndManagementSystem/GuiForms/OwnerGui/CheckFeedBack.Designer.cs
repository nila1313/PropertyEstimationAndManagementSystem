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
            this.dataGridShowFeedBack.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(32)))));
            this.dataGridShowFeedBack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridShowFeedBack.Location = new System.Drawing.Point(49, 50);
            this.dataGridShowFeedBack.Name = "dataGridShowFeedBack";
            this.dataGridShowFeedBack.Size = new System.Drawing.Size(642, 167);
            this.dataGridShowFeedBack.TabIndex = 0;
            this.dataGridShowFeedBack.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridShowFeedBack_CellClick);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDescription.Location = new System.Drawing.Point(44, 239);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(135, 29);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // lblDescriptionValue
            // 
            this.lblDescriptionValue.AutoSize = true;
            this.lblDescriptionValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionValue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDescriptionValue.Location = new System.Drawing.Point(45, 282);
            this.lblDescriptionValue.Name = "lblDescriptionValue";
            this.lblDescriptionValue.Size = new System.Drawing.Size(51, 20);
            this.lblDescriptionValue.TabIndex = 2;
            this.lblDescriptionValue.Text = "label1";
            // 
            // CheckFeedBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(769, 502);
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
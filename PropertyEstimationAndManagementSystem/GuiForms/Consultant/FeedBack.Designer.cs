namespace PropertyEstimationAndManagementSystem.GuiForms.Consultant
{
    partial class FeedBack
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
            this.richtxtDescription = new System.Windows.Forms.RichTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richtxtDescription
            // 
            this.richtxtDescription.Location = new System.Drawing.Point(93, 82);
            this.richtxtDescription.Name = "richtxtDescription";
            this.richtxtDescription.Size = new System.Drawing.Size(365, 197);
            this.richtxtDescription.TabIndex = 0;
            this.richtxtDescription.Text = "";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(89, 45);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(318, 24);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Please let us know your Feedback!!!!";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(115, 359);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(99, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "*Please do not cross 150 words";
            // 
            // FeedBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.richtxtDescription);
            this.Name = "FeedBack";
            this.Text = "FeedBack";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richtxtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
    }
}
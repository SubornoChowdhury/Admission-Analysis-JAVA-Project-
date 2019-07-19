namespace Project1_RestaurentManagementSystemPRO
{
    partial class Combo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblcombo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblcombo
            // 
            this.lblcombo.AutoSize = true;
            this.lblcombo.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcombo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcombo.Location = new System.Drawing.Point(4, 0);
            this.lblcombo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcombo.Name = "lblcombo";
            this.lblcombo.Size = new System.Drawing.Size(109, 40);
            this.lblcombo.TabIndex = 3;
            this.lblcombo.Text = "Combo";
            // 
            // Combo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblcombo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Combo";
            this.Size = new System.Drawing.Size(783, 512);
            this.Load += new System.EventHandler(this.Combo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcombo;
    }
}

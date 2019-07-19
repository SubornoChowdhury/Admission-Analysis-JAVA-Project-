namespace Project1_RestaurentManagementSystemPRO
{
    partial class Pasta
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
            this.lblPasta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPasta
            // 
            this.lblPasta.AutoSize = true;
            this.lblPasta.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasta.ForeColor = System.Drawing.Color.Tomato;
            this.lblPasta.Location = new System.Drawing.Point(3, 0);
            this.lblPasta.Name = "lblPasta";
            this.lblPasta.Size = new System.Drawing.Size(87, 31);
            this.lblPasta.TabIndex = 1;
            this.lblPasta.Text = "Pastas";
            // 
            // Pasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPasta);
            this.Name = "Pasta";
            this.Size = new System.Drawing.Size(608, 420);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPasta;
    }
}

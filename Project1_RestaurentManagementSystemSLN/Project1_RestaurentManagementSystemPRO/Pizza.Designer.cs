namespace Project1_RestaurentManagementSystemPRO
{
    partial class Pizza
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
            this.lblPizza = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPizza
            // 
            this.lblPizza.AutoSize = true;
            this.lblPizza.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizza.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblPizza.Location = new System.Drawing.Point(3, 0);
            this.lblPizza.Name = "lblPizza";
            this.lblPizza.Size = new System.Drawing.Size(82, 31);
            this.lblPizza.TabIndex = 0;
            this.lblPizza.Text = "Pizzas";
            // 
            // Pizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPizza);
            this.Name = "Pizza";
            this.Size = new System.Drawing.Size(596, 417);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPizza;
    }
}

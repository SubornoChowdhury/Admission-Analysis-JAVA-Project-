namespace Project1_RestaurentManagementSystemPRO
{
    partial class Switch
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Switch));
            this.pctboxSwitch = new System.Windows.Forms.PictureBox();
            this.pnlchoose = new System.Windows.Forms.Panel();
            this.btnTakeAway = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.timerSwitch = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctboxSwitch)).BeginInit();
            this.pnlchoose.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctboxSwitch
            // 
            this.pctboxSwitch.Image = ((System.Drawing.Image)(resources.GetObject("pctboxSwitch.Image")));
            this.pctboxSwitch.Location = new System.Drawing.Point(0, 0);
            this.pctboxSwitch.Name = "pctboxSwitch";
            this.pctboxSwitch.Size = new System.Drawing.Size(791, 448);
            this.pctboxSwitch.TabIndex = 0;
            this.pctboxSwitch.TabStop = false;
            // 
            // pnlchoose
            // 
            this.pnlchoose.Controls.Add(this.btnTakeAway);
            this.pnlchoose.Controls.Add(this.btnOrder);
            this.pnlchoose.Controls.Add(this.pctboxSwitch);
            this.pnlchoose.Location = new System.Drawing.Point(1, 1);
            this.pnlchoose.Name = "pnlchoose";
            this.pnlchoose.Size = new System.Drawing.Size(793, 448);
            this.pnlchoose.TabIndex = 0;
            // 
            // btnTakeAway
            // 
            this.btnTakeAway.BackColor = System.Drawing.Color.Orange;
            this.btnTakeAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeAway.Location = new System.Drawing.Point(55, 277);
            this.btnTakeAway.Name = "btnTakeAway";
            this.btnTakeAway.Size = new System.Drawing.Size(109, 55);
            this.btnTakeAway.TabIndex = 2;
            this.btnTakeAway.Text = "Take Away";
            this.btnTakeAway.UseVisualStyleBackColor = false;
            this.btnTakeAway.Click += new System.EventHandler(this.btnTakeAway_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Orange;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(55, 209);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(109, 48);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Order Now";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // timerSwitch
            // 
            this.timerSwitch.Enabled = true;
            this.timerSwitch.Interval = 2000;
            this.timerSwitch.Tick += new System.EventHandler(this.timerSwitch_Tick);
            // 
            // Switch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.pnlchoose);
            this.Name = "Switch";
            this.Text = "Switch";
            ((System.ComponentModel.ISupportInitialize)(this.pctboxSwitch)).EndInit();
            this.pnlchoose.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctboxSwitch;
        private System.Windows.Forms.Panel pnlchoose;
        private System.Windows.Forms.Button btnTakeAway;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Timer timerSwitch;
    }
}
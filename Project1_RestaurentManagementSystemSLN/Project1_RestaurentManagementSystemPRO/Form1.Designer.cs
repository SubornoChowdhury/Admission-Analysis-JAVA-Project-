namespace Project1_RestaurentManagementSystemPRO
{
    partial class Frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmlogin));
            this.pnlhome = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.lblloginid = new System.Windows.Forms.Label();
            this.lblhomequotes = new System.Windows.Forms.Label();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.slidepctboxhome = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlhome.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slidepctboxhome)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlhome
            // 
            this.pnlhome.Controls.Add(this.panel1);
            this.pnlhome.Controls.Add(this.slidepctboxhome);
            this.pnlhome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlhome.Location = new System.Drawing.Point(0, 0);
            this.pnlhome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlhome.Name = "pnlhome";
            this.pnlhome.Size = new System.Drawing.Size(1035, 693);
            this.pnlhome.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbstatus);
            this.panel1.Controls.Add(this.btnlogin);
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.lblpass);
            this.panel1.Controls.Add(this.lblloginid);
            this.panel1.Controls.Add(this.lblhomequotes);
            this.panel1.Controls.Add(this.lblwelcome);
            this.panel1.Location = new System.Drawing.Point(127, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 693);
            this.panel1.TabIndex = 6;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(87, 479);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(132, 48);
            this.btnlogin.TabIndex = 7;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(86, 407);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(132, 22);
            this.txtpass.TabIndex = 6;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(86, 363);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(132, 22);
            this.txtid.TabIndex = 5;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblpass.Location = new System.Drawing.Point(28, 410);
            this.lblpass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(39, 17);
            this.lblpass.TabIndex = 4;
            this.lblpass.Text = "Pass";
            // 
            // lblloginid
            // 
            this.lblloginid.AutoSize = true;
            this.lblloginid.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblloginid.Location = new System.Drawing.Point(44, 366);
            this.lblloginid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblloginid.Name = "lblloginid";
            this.lblloginid.Size = new System.Drawing.Size(21, 17);
            this.lblloginid.TabIndex = 3;
            this.lblloginid.Text = "ID";
            // 
            // lblhomequotes
            // 
            this.lblhomequotes.AutoSize = true;
            this.lblhomequotes.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhomequotes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblhomequotes.Location = new System.Drawing.Point(13, 172);
            this.lblhomequotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhomequotes.Name = "lblhomequotes";
            this.lblhomequotes.Size = new System.Drawing.Size(275, 130);
            this.lblhomequotes.TabIndex = 2;
            this.lblhomequotes.Text = "\"Great customer services \r\ndoesn\'t mean the customer\r\n is always right,It means t" +
    "he \r\ncustomer is always honored\"\r\n  \r\n";
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblwelcome.Location = new System.Drawing.Point(81, 103);
            this.lblwelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(120, 28);
            this.lblwelcome.TabIndex = 1;
            this.lblwelcome.Text = "Welcome!";
            // 
            // slidepctboxhome
            // 
            this.slidepctboxhome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slidepctboxhome.Image = ((System.Drawing.Image)(resources.GetObject("slidepctboxhome.Image")));
            this.slidepctboxhome.Location = new System.Drawing.Point(0, 0);
            this.slidepctboxhome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.slidepctboxhome.Name = "slidepctboxhome";
            this.slidepctboxhome.Size = new System.Drawing.Size(1035, 693);
            this.slidepctboxhome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.slidepctboxhome.TabIndex = 5;
            this.slidepctboxhome.TabStop = false;
            this.slidepctboxhome.Click += new System.EventHandler(this.slidepctboxhome_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cmbstatus
            // 
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Items.AddRange(new object[] {
            "manager",
            "employee"});
            this.cmbstatus.Location = new System.Drawing.Point(86, 319);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(132, 24);
            this.cmbstatus.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "occupation";
            // 
            // Frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 693);
            this.Controls.Add(this.pnlhome);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frmlogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlhome.ResumeLayout(false);
            this.pnlhome.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slidepctboxhome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlhome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox slidepctboxhome;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblhomequotes;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lblloginid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbstatus;
    }
}


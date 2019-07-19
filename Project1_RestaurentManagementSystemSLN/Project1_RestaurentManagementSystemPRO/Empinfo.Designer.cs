namespace Project1_RestaurentManagementSystemPRO
{
    partial class Empinfo
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
            this.txtempid = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnnew = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnorder = new System.Windows.Forms.Button();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtempid
            // 
            this.txtempid.Location = new System.Drawing.Point(345, 47);
            this.txtempid.Name = "txtempid";
            this.txtempid.Size = new System.Drawing.Size(178, 22);
            this.txtempid.TabIndex = 3;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(345, 76);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(178, 22);
            this.txtpass.TabIndex = 4;
            // 
            // cmbstatus
            // 
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Items.AddRange(new object[] {
            "Employee",
            "Manager"});
            this.cmbstatus.Location = new System.Drawing.Point(345, 103);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(183, 24);
            this.cmbstatus.TabIndex = 5;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userid,
            this.password,
            this.status});
            this.dgv1.Location = new System.Drawing.Point(0, 186);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(569, 265);
            this.dgv1.TabIndex = 6;
            this.dgv1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv1_CellMouseClick);
          //  this.dgv1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv1_CellMouseDoubleClick);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(643, 120);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(643, 91);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 8;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(643, 62);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 7;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "EmpId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Status";
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(643, 33);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(75, 23);
            this.btnnew.TabIndex = 13;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Search";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(230, 153);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(298, 22);
            this.txtsearch.TabIndex = 15;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // btnorder
            // 
            this.btnorder.Location = new System.Drawing.Point(681, 304);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(100, 37);
            this.btnorder.TabIndex = 16;
            this.btnorder.Text = "Takeorder";
            this.btnorder.UseVisualStyleBackColor = true;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // userid
            // 
            this.userid.HeaderText = "Emp_id";
            this.userid.Name = "userid";
            this.userid.ReadOnly = true;
            this.userid.Width = 175;
            // 
            // password
            // 
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Width = 150;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 175;
            // 
            // Empinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnorder);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.cmbstatus);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtempid);
            this.Name = "Empinfo";
            this.Text = "Empinfo";
            this.Load += new System.EventHandler(this.Empinfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtempid;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.ComboBox cmbstatus;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}
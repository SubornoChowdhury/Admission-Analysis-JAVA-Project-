using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1_RestaurentManagementSystemPRO
{
    public partial class Empinfo : Form
    {
        DataAccess da = new DataAccess();
        public Empinfo()
        {
            InitializeComponent();
        }

        private void Empinfo_Load(object sender, EventArgs e)
        {
            try { 
                this.ActiveControl = txtempid;
                txtempid.Focus();
                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                MessageBox.Show(ex.Message);
            }
        }
        //-------------------new-------------------------
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtempid.Clear();
            txtpass.Clear();


            txtempid.Focus();

        }
        //---------------------insert------------------
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = new repo().insertemp(this.txtempid.Text, this.txtpass.Text, this.cmbstatus.Text);

                // DataSet ds = new DataSet();
                da.ExecuteUpdateQuery(sql);
                MessageBox.Show("insertion done");
                display();
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
        }


        //-------------------update----------------------------------------
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                string sql = new repo().updateemp(this.txtempid.Text, this.txtpass.Text, this.cmbstatus.Text);

                // DataSet ds = new DataSet();
                da.ExecuteUpdateQuery(sql);
                MessageBox.Show("Information updated");
                display();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);

            }


        }

        //------------------------------delete-----------------------------------
        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = new repo().deleteEnp(this.txtempid.Text);

                // DataSet ds = new DataSet();
                da.ExecuteUpdateQuery(sql);
                MessageBox.Show("Deletion completed");

                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                MessageBox.Show(ex.Message);
            }
        }
        private void display()
        {
            string sql = new repo().selectAll(); //;
            DataSet ds = new DataSet();
            ds = da.ExecuteQuery(sql);
            dgv1.Rows.Clear();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                int n = dgv1.Rows.Add();
                dgv1.Rows[n].Cells[0].Value = item[0].ToString();
                dgv1.Rows[n].Cells[1].Value = item[1].ToString();
                dgv1.Rows[n].Cells[2].Value = item[2].ToString();
                // dgv1.Rows[n].Cells[3].Value = item[3].ToString();
            }
        }

     /*   private void dgv1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtempid.Text = dgv1.SelectedRows[0].Cells[0].Value.ToString();
            txtpass.Text = dgv1.SelectedRows[0].Cells[1].Value.ToString();
            cmbstatus.Text = dgv1.SelectedRows[0].Cells[2].Value.ToString();
            // txtwork.Text = dgv1.SelectedRows[0].Cells[3].Value.ToString();

        }
        */

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

            string sql = new repo().searchall(this.txtsearch.Text);
            DataSet ds = new DataSet();
            ds = da.ExecuteQuery(sql);
            dgv1.Rows.Clear();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                int n = dgv1.Rows.Add();
                dgv1.Rows[n].Cells[0].Value = item[0].ToString();
                dgv1.Rows[n].Cells[1].Value = item[1].ToString();
                dgv1.Rows[n].Cells[2].Value = item[2].ToString();
                // dgv1.Rows[n].Cells[3].Value = item[3].ToString();
            }






        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Dine d = new Dine();
            d.Visible = true;
           
        }

        private void dgv1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtempid.Text = dgv1.SelectedRows[0].Cells[0].Value.ToString();
            txtpass.Text = dgv1.SelectedRows[0].Cells[1].Value.ToString();
            cmbstatus.Text = dgv1.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}

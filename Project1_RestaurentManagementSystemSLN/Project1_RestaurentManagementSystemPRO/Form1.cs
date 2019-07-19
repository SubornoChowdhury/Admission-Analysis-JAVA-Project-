using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Sql;
using System.Data.SqlClient;
//using System.Data;

namespace Project1_RestaurentManagementSystemPRO
{
    public partial class Frmlogin : Form
    {
       

        List<string> image;
        //SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\refe.mdf;Integrated Security=True;Connect Timeout=30");
        public Frmlogin()
        {
            InitializeComponent();
            image = new List<string>
            {
                "Image\\01.jpg",
                "@C:\\Users\\Suborno Chowdhury\\Desktop\\Project for C#\\Project1_RestaurentManagementSystemSLN\\Project1_RestaurentManagementSystemPRO\\bin\\Debug\\Image\\02.jpg"
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      //  private DataSet DB(string sql)
       // {
       //     SqlCommand sqlcom = new SqlCommand(sql, this.sqlcon);
         //   SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
           // DataSet ds = new DataSet();
            //sda.Fill(ds);

//            return ds;

  //      }

        private void DBConnect()
        {
            string ConnectString = "datasource=localhost; username=root; password=; database=TestC#";
            MySqlConnection DB = new MySqlConnection(ConnectString);
            try
            {
                DB.Open();
                MessageBox.Show("Connected");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnect();
        }

        private int imageNumber = 0;
        private void LoadNextImage()
        {
            if (imageNumber == 1)
            {
                imageNumber = 0;
            }
            //slidepctboxhome.ImageLocation = string.Format(@"0{0}.jpg", imageNumber);            
            Image imag = Image.FromFile(image[imageNumber]);
            slidepctboxhome.Image = imag;
            imageNumber++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //LoadNextImage();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
           

            string sql = new repo().login(this.txtid.Text, this.txtpass.Text,this.cmbstatus.Text); 
            //DataSet ds = DB(sql);
            // SqlCommand sqlcom = new SqlCommand(sql, this.sqlcon);
            //SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            DataAccess da = new DataAccess();
            ds = da.ExecuteQuery(sql);

            
            if (ds.Tables[0].Rows.Count == 1)
            {
                if (cmbstatus.Text == "manager")
                {
                    MessageBox.Show("verified for manager");
                    Empinfo em = new Empinfo();
                    em.Visible = true;
                }
                else
                {
                    MessageBox.Show("verified for employee");
                    Switch S = new Switch();
                    S.Visible = true;
                    // S.Show();
                }
            }

            else
                MessageBox.Show("not verified");


        }

        private void slidepctboxhome_Click(object sender, EventArgs e)
        {

        }
    }
}

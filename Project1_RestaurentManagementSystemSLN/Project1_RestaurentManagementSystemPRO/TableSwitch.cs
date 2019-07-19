using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
namespace Project1_RestaurentManagementSystemPRO
{
    public partial class TableSwitch : Form
    {
        //  SqlConnection Sqlcon;

        // Button[] btn = new Button[4];

        //Sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Downloads\restaurant\restaurant.mdf;Integrated Security=True;Connect Timeout=30");
        // SqlDataReader dr;

        int[] tableStat;
        DataAccess da = new DataAccess();
        bool book = true;
        bool tooglelight = true;
        Timer t = new Timer();
        Switch mn = new Switch();
        DataSet ds = new DataSet();

        public TableSwitch()
        {
            
            tableStat = new int[4];
           // cn();


            InitializeComponent();
          
           // SqlCommand cmd = new SqlCommand(q, Sqlcon);
           // this.dr = cmd.ExecuteReader();
            try
            {
               // Sqlcon.Open();
                //MessageBox.Show("yes");

                /* while (dr.Read())
                {
                    int i = 0;
                    string st = dr["tableStatus"].ToString();
                    MessageBox.Show(i+"\t"+st);
                    btChange(st, i);

                    i++;
                }
               */ 
               // Sqlcon.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }

            // initialStat();
        }
        /*  private void cn()
          {
              this.Sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Downloads\restaurant\restaurant.mdf;Integrated Security=True;Connect Timeout=30");

          }*/

        private void TableSwitch_Load(object sender, EventArgs e)
        {

            //t.Interval = 1000;
            //t.Tick += new EventHandler(t_Tick);
            //=======================================
            try
            {
                string q = "select * from table1";
                ds = da.ExecuteQuery(q);

                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    if (item[0].ToString() == "1" && item[1].ToString() == "1")
                    {
                        btntable1.Text = "Booked";
                        btntable1.BackColor = Color.Red;
                    }
                    if (item[0].ToString() == "2" && item[1].ToString() == "1")
                    {
                        btntable2.Text = "Booked";
                        btntable2.BackColor = Color.Red;
                    }
                    if (item[0].ToString() == "3" && item[1].ToString() == "1")
                    {
                        btntable2.Text = "Booked";
                        btntable2.BackColor = Color.Red;
                    }
                    if (item[0].ToString() == "4" && item[1].ToString() == "1")
                    {
                        btntable2.Text = "Booked";
                        btntable2.BackColor = Color.Red;
                    }


                }



                    //int n = dgv1.Rows.Add();
                    // dgv1.Rows[n].Cells[0].Value = item[0].ToString();
                    // dgv1.Rows[n].Cells[1].Value = item[1].ToString();
                    // dgv1.Rows[n].Cells[2].Value = item[2].ToString();
                    // dgv1.Rows[n].Cells[3].Value = item[3].ToString();
                

                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    if (item[0].ToString() == "1" && item[1].ToString() == "0")
                    {
                        btntable1.Text = "Book";
                        btntable1.BackColor = Color.LightSkyBlue;
                    }
                    if (item[0].ToString() == "2" && item[1].ToString() == "0")
                    {
                        btntable2.Text = "Book";
                        btntable2.BackColor = Color.LightSkyBlue;
                    }
                    if (item[0].ToString() == "3" && item[1].ToString() == "0")
                    {
                        btntable3.Text = "Book";
                        btntable3.BackColor = Color.LightSkyBlue;
                    }
                    if (item[0].ToString() == "4" && item[1].ToString() == "0")
                    {
                        btntable4.Text = "Book";
                        btntable4.BackColor = Color.LightSkyBlue;
                    }


                }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.StackTrace);}

        }

        //Button Color Changing
        //private void t_Tick(object sender, EventArgs e)
        //{
        //    if (tooglelight)
        //    {

        //      //  circularBtnTable2.BackColor = Color.Orange;
        //        tooglelight = false;
        //    }
        //    else
        //    {

        //        circularBtnTable2.BackColor = Color.Red;
        //        tooglelight = true;
        //    }
        //}

        //Tables


        /*  private void circularBtnTable2_Click(object sender, EventArgs e)
          {
              if (book)
              {
                  circularBtnTable2.Text = "Table_Free";
                  t.Start();
                  book = false;
              }
              else
              {
                  circularBtnTable2.Text = "Reserved";
                  circularBtnTable2.BackColor = Color.Red;
                  t.Stop();
                  book = true;
              }
          }
          */

        /* private void chkboxbook1_CheckedChanged(object sender, EventArgs e)
         {
             if (chkboxbook1.Checked == true)
             {
                 btnTable01.Enabled = false;
             }
             else
             {
                 btnTable01.Enabled = true;
             }
         }

     */
        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            mn.Visible = true;
        }

        private void TablePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btntable01_Click(object sender, EventArgs e)
        {

        }

       

        //private void initialStat()
        //{
        //    for(int i=0;i<4;i++)
        //    {
        //        if(tableStat[i]==1)
        //        {
        //            //button1.Text = "Booked";
        //            MessageBox.Show(tableStat[i].ToString());
        //        }
        //        else
        //        {
        //            //btntable01.Text = "Book";
        //            MessageBox.Show(tableStat[i].ToString());
        //        }
        //    }
        //}
        void btChange( int x, string s)
        {
            if (x == 0 && s == "1")
            {
                btntable1.Text = "Booked";
                btntable1.BackColor = Color.Red;
                
            }
            else if (x == 0 && s == "0")
            {
               btntable1.Text = "Book";
               btntable1.BackColor = Color.LightSkyBlue;
               
            }
            else if (x == 1 && s == "1")
            {
                btntable2.Text = "Booked";
                btntable2.BackColor = Color.Red;
            }
            else if (x == 1 && s == "0")
            {
                btntable2.Text = "Book";
                btntable2.BackColor = Color.LightSkyBlue;
            }
            else if (x == 2 && s == "1")
            {
                btntable3.Text = "Booked";
                btntable3.BackColor = Color.Red;
            }

            else if (x == 2 && s == "0")
            {
                btntable3.Text = "Book";
                btntable3.BackColor = Color.LightSkyBlue;
            }
            else if (x == 3 && s == "1")
            {
                btntable4.Text = "Booked";
                btntable4.BackColor = Color.Red;
            }

            else if (x == 3 && s == "0")
            {
                btntable4.Text = "Book";
                btntable4.BackColor = Color.LightSkyBlue;
            }
        }








        private void update(int tableid, int tablestatus)
        {

            try
            {
                string sql = "update table1 set tableStatus ='" + tablestatus+ "' where tableId ='" + tableid + "'  ";

                // DataSet ds = new DataSet();
              int u =  da.ExecuteUpdateQuery(sql);
                MessageBox.Show("Information updated");
                //display();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);

            }

        }

            private void btntable1_Click(object sender, EventArgs e)
        {
            try
            {
                if (btntable1.Text == "Book")
                {
                    btntable1.Text = "Booked";
                    btntable1.BackColor = Color.Red;
                    update(1, 1);

                    Dine d = new Dine();
                    d.Visible = true;
                }
                else
                {
                    btntable1.Text = "Book";
                    btntable1.BackColor = Color.LightSkyBlue;
                    update(1, 0);


                }
            }
            catch(Exception ex)
            { MessageBox.Show(ex.StackTrace); }
        }

        private void btntable2_Click(object sender, EventArgs e)
        {
            if (btntable2.Text == "Book")
            {
                btntable2.Text = "Booked";
                btntable2.BackColor = Color.Red;

                update(2, 1);

                Dine d = new Dine();
                d.Visible = true;
            }
            else
            {
                btntable2.Text = "Book";
                btntable2.BackColor = Color.LightSkyBlue;
                update(2, 0);

            }
        }

      


            
          


        


        private void btntable3_Click(object sender, EventArgs e)
        {
            if (btntable3.Text == "Book")
            {
                btntable3.Text = "Booked";
                btntable3.BackColor = Color.Red;

                update(3, 1);

                Dine d = new Dine();
                d.Visible = true;

            }
            else
            {
                btntable3.Text = "Book";
                btntable3.BackColor = Color.LightSkyBlue;
                update(3, 0);

            }
        }

        private void btntable4_Click(object sender, EventArgs e)
        {
            if (btntable4.Text == "Book")
            {
                btntable4.Text = "Booked";
                btntable4.BackColor = Color.Red;
                update(4, 1);

                Dine d = new Dine();
                d.Visible = true;
            }
            else
            {
                btntable4.Text = "Book";
                btntable4.BackColor = Color.LightSkyBlue;
                update(4, 0);

            }
        }

        private void btntakeorder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dine d = new Dine();
            d.Visible = true;

        }
    }
 }


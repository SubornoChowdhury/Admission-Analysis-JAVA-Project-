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
    public partial class Dine : MetroFramework.Forms.MetroForm
    {
        double[] itemcost = new double[15];
        double itax, itotal; double isubtotal = 0;


        public Dine()
        {
            InitializeComponent();
        }

        private void Choose2_Load(object sender, EventArgs e)
        {

        }

        private void pizza1_Load(object sender, EventArgs e)
        {

        }

        private void metroButtonclose_Click(object sender, EventArgs e)
        {
            DialogResult iexit;

            iexit = MessageBox.Show("confirm if you want to exit", "POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iexit == DialogResult.Yes)
            { Application.Exit(); }



            //Dine c = new Dine();
            //this.Close();
            //c.Close();

        }



        //--------------------------------------
        private void resetTextBox()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is NumericUpDown)
                        (control as NumericUpDown).Text = "0";
                    else
                        func(control.Controls);

            };
            func(Controls);

        }
        //------------------------------------
        private void btnReset_Click(object sender, EventArgs e)
        {
            resetTextBox();
            lblrsubtotal.Text = "";
            lblrvat.Text = "";
            lblrtotal.Text = "";
            txtreceipt.Clear();


        }

        private void changecolor(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.LightBlue;
        }

        private void colorchange(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.FromKnownColor(KnownColor.Control);
            //  b.BackColor = Color.White;
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog1.ShowDialog();
            }

            catch (Exception ex)
            { MessageBox.Show (ex.Message);}
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawString(txtreceipt.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(0, 0));

            }

            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btntotal_Click(object sender, EventArgs e)
        {
            txtreceipt.ResetText();

            try
            {

                double tax_rate = 0.15;

                itemcost[0] = Convert.ToDouble(nudBchickenDelight.Text) * Convert.ToDouble(lblChickenDelightPrice.Text.Substring(6, 3));
                itemcost[1] = Convert.ToDouble(nudBeefburger.Text) * Convert.ToDouble(lblbeefburgerPrice.Text.Substring(6, 3));
                itemcost[2] = Convert.ToDouble(nudBsteak.Text) * Convert.ToDouble(lblbeefsteakburgerPrice.Text.Substring(6, 3));

                itemcost[3] = Convert.ToDouble(nudalpino.Text) * Convert.ToDouble(lblAlpinopizzaPrice.Text.Substring(6, 3));
                itemcost[4] = Convert.ToDouble(nudcrust.Text) * Convert.ToDouble(lblcrustpizzaPrice.Text.Substring(6, 3));
                itemcost[5] = Convert.ToDouble(nudhawaii.Text) * Convert.ToDouble(lblhawaiipizzaPrice.Text.Substring(6, 4));

                itemcost[6] = Convert.ToDouble(nuddoughy.Text) * Convert.ToDouble(lbldoughypastaPrice.Text.Substring(6, 3));
                itemcost[7] = Convert.ToDouble(nudspaghetti.Text) * Convert.ToDouble(lblspaghettipastaPrice.Text.Substring(6, 3));
                itemcost[8] = Convert.ToDouble(nudsweet.Text) * Convert.ToDouble(lblsweettangyPrice.Text.Substring(6, 3));

                itemcost[9] = Convert.ToDouble(nudlatte.Text) * Convert.ToDouble(lbllattePrice.Text.Substring(6, 3));
                itemcost[10] = Convert.ToDouble(nudcheese.Text) * Convert.ToDouble(lblCheeseCakePrice.Text.Substring(6, 3));
                itemcost[11] = Convert.ToDouble(nudcappuccino.Text) * Convert.ToDouble(lblCappuccinoPrice.Text.Substring(6, 3));

                itemcost[12] = Convert.ToDouble(nudcombo1.Text) * Convert.ToDouble(lblCombo01Price.Text.Substring(6, 3));
                itemcost[13] = Convert.ToDouble(nudcombo2.Text) * Convert.ToDouble(lblCombo02Price.Text.Substring(6, 3));
                // itemcost[8] = Convert.ToDouble(nudsweet.Text) * Convert.ToDouble(lblsweettangyPrice.Text.Substring(6, 3));

                  for (int i = 0; i < itemcost.Length; i++)
                  {
                      isubtotal += itemcost[i];

                  }
                  
              //  isubtotal = itemcost[0];
                lblrsubtotal.Text = isubtotal.ToString();

                itax = isubtotal * tax_rate;
                lblrvat.Text = itax.ToString();


                itotal = isubtotal + itax;
                lblrtotal.Text = itotal.ToString();

                lblrvat.Text = string.Format(itax + " tk");
                //lblrsubtotal.Text = string.Format ("{")
                lblrsubtotal.Text = (isubtotal + " tk");
                lblrtotal.Text = (itotal + " tk");

                txtreceipt.AppendText("\t\t\t" + "Restaurant" + Environment.NewLine);
                txtreceipt.AppendText("\t\t\t" + "location " + Environment.NewLine);
                txtreceipt.AppendText("\t\t\t" + " city" + Environment.NewLine);
                txtreceipt.AppendText( Environment.NewLine);
                txtreceipt.AppendText("Name" + "\t\t" + "QTY" +"\t"+"price"+ Environment.NewLine);
                txtreceipt.AppendText("-------------------------------------------------------------" + Environment.NewLine);
                //txtreceipt.AppendText("Name" + "\t\t"+ "QTY" + Environment.NewLine);

                //==========================================================================================================================================================

                if ( Convert.ToDouble(nudBchickenDelight.Text) > 0 )
                    txtreceipt.AppendText(lblChickenDelight.Text + "\t" + nudBchickenDelight.Text + "\t" + itemcost[0].ToString() + " tk" +Environment.NewLine);

                if (Convert.ToDouble(nudBeefburger.Text) > 0)
                    txtreceipt.AppendText(lblJuicybeefburger.Text + "\t" + nudBeefburger.Text + "\t" + itemcost[1].ToString() + " tk" + Environment.NewLine);

                if (Convert.ToDouble(nudBsteak.Text) > 0)
                    txtreceipt.AppendText(lblbeefsteakB.Text + "\t" + nudBsteak.Text + "\t" + itemcost[2].ToString() + " tk" + Environment.NewLine);


//----------------------------------------------------------------------------------------------------------------------------------------------
                if (Convert.ToDouble(nudalpino.Text) > 0)
                    txtreceipt.AppendText(lblalpinoP.Text + "\t" + nudalpino.Text + "\t" + itemcost[3].ToString() + " tk" + Environment.NewLine);

                if (Convert.ToDouble(nudcrust.Text) > 0)
                    txtreceipt.AppendText(lblCrustPizza.Text + "\t" + nudcrust.Text + "\t" + itemcost[4].ToString() + " tk" + Environment.NewLine);

                if (Convert.ToDouble(nudhawaii.Text) > 0)
                    txtreceipt.AppendText(lblHawaiianpizza.Text + "\t" + nudhawaii.Text + "\t" + itemcost[5].ToString() + " tk" + Environment.NewLine);

 //-----------------------------------------------------------------------------------------------------------------------------------------------------


                if (Convert.ToDouble(nuddoughy.Text) > 0)
                    txtreceipt.AppendText(lbldoughypasta.Text + "\t" + nuddoughy.Text + "\t" + itemcost[6].ToString() + " tk" + Environment.NewLine);

                if (Convert.ToDouble(nudspaghetti.Text) > 0)
                    txtreceipt.AppendText(lblspaghetti.Text + "\t" + nudspaghetti.Text + "\t" + itemcost[7].ToString() + " tk" + Environment.NewLine);

                if (Convert.ToDouble(nudsweet.Text) > 0)
                    txtreceipt.AppendText(lblspaghetti.Text + "\t" +nudsweet.Text + "\t" + itemcost[8].ToString() + " tk" + Environment.NewLine);

                //-----------------------------------------------------------------------------------------------------------------------------------------------------

                if (Convert.ToDouble(nudlatte.Text) > 0)
                    txtreceipt.AppendText(lbllatte.Text + "\t" + nudlatte.Text + "\t" + itemcost[9].ToString() + " tk" + Environment.NewLine);

                if (Convert.ToDouble(nudcheese.Text) > 0)
                    txtreceipt.AppendText(lblCheeseCake.Text + "\t" + nudcheese.Text + "\t" + itemcost[10].ToString() + " tk" + Environment.NewLine);

                if (Convert.ToDouble (nudcappuccino.Text) > 0)
                    txtreceipt.AppendText(lblcappuccino.Text + "\t" + nudcappuccino.Text + "\t" + itemcost[11].ToString() + " tk" + Environment.NewLine);

//---------------------------------------------------------------------------------------------------------------------------------------------------------------

                if (Convert.ToDouble(nudcombo1.Text) > 0)
                    txtreceipt.AppendText(lblCombo1.Text + "\t" + nudcombo1.Text + "\t" + itemcost[12].ToString() + " tk" + Environment.NewLine);

                if (Convert.ToDouble (nudcombo2.Text) > 0)
                    txtreceipt.AppendText(lblcombo2.Text + "\t" + nudcombo2.Text + "\t" + itemcost[13].ToString() + " tk" + Environment.NewLine);

                //================================================================================================================================================              

                txtreceipt.AppendText("-------------------------------------------------------------" + Environment.NewLine);
                txtreceipt.AppendText("Subtotal" + "\t\t\t" + lblrsubtotal.Text + Environment.NewLine);
                txtreceipt.AppendText("VAT" + "\t\t\t" + lblrvat.Text + Environment.NewLine);
                txtreceipt.AppendText("Total" + "\t\t\t" + lblrtotal.Text + Environment.NewLine);
                txtreceipt.AppendText("-------------------------------------------------------------" + Environment.NewLine);
                txtreceipt.AppendText("\t" + " Thank you for dining with us" + Environment.NewLine);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}

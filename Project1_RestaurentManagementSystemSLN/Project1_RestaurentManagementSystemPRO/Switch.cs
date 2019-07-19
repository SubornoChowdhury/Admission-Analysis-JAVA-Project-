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
    public partial class Switch : Form
    {
        List<string> image;
        public Switch()
        {
            
            InitializeComponent();
            image = new List<string>
            {
                "Image\\01.jpg","Image\\02.jpg","Image\\03.jpg","Image\\04.jpg","Image\\05.jpg",
                "@C:\\Users\\Suborno Chowdhury\\Desktop\\Project for C#\\Project1_RestaurentManagementSystemSLN\\Project1_RestaurentManagementSystemPRO\\bin\\Debug\\Image\\02.jpg"
            };
        }

       
        private int imageNumber = 0;
        private void LoadNextImage()
        {
            if (imageNumber == 5)
            {
                imageNumber = 0;
            }
            //slidepctboxhome.ImageLocation = string.Format(@"0{0}.jpg", imageNumber);            
            Image imag = Image.FromFile(image[imageNumber]);
            pctboxSwitch.Image = imag;
            imageNumber++;
        }

        private void timerSwitch_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }
        //--------------------------------------------------------------
        private void btnOrder_Click(object sender, EventArgs e)
        {
            TableSwitch t = new TableSwitch();
            t.Show();
        }
        //----------------------------------------------------------
        private void btnTakeAway_Click(object sender, EventArgs e)
        {
            
            Dine c = new Dine();
            c.Visible = (true);
        }
    }
}

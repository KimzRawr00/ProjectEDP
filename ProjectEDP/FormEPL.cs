using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEDP
{
    public partial class FormEPL : Form
    {
        public FormEPL()
        {
            InitializeComponent();
        }

        private void panelHero_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblEPL_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
       
        private void cmbStadium_SelectedIndexChanged(object sender, EventArgs e)
        {
            string imagePath = "";

            switch (cmbStadium.Text)
            {
                case "Anfield":
                    imagePath = @"C:\Users\hakim\OneDrive\Documents\gambar\Anfield.jpg";
                    break;

                case "St James' Park":
                    imagePath = @"C:\Users\hakim\OneDrive\Documents\gambar\stjamespark.jpg";
                    break;

                case "Selhurst Park":
                    imagePath = @"C:\Users\hakim\OneDrive\Documents\gambar\selhurst.jpg";
                    break;

                case "Villa Park":
                    imagePath = @"C:\Users\hakim\OneDrive\Documents\gambar\villa.jpg";
                    break;

                case "Old Trafford":
                    imagePath = @"C:\Users\hakim\OneDrive\Documents\gambar\Oldtrafford.jpg";
                    break;

                case "Tottenham Hotspur Stadium":
                    imagePath = @"C:\Users\hakim\OneDrive\Documents\gambar\totenhamjpg.jpg";
                    break;

                case "Stamford Bridge":
                    imagePath = @"C:\Users\hakim\OneDrive\Documents\gambar\stamford.jpg";
                    break;

                case "Emirates Stadium":
                    imagePath = @"C:\Users\hakim\OneDrive\Documents\gambar\emirates.jpg";
                    break;

                case "Etihad Stadium":
                    imagePath = @"C:\Users\hakim\OneDrive\Documents\gambar\etihad.jpg";
                    break;

                case "Molineux Stadium":
                    imagePath = @"C:\Users\hakim\OneDrive\Documents\gambar\hill.jpg";
                    break;
            }

            if (File.Exists(imagePath))
            {
                picStadium.Image = Image.FromFile(imagePath);
                picStadium.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Gambar tidak dijumpai:\n" + imagePath);
            }

        }

        private void FormEPL_Load(object sender, EventArgs e)
        {

        }

        private void picStadium_Click(object sender, EventArgs e)
        {

        }
    }
}

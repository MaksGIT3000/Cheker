using MaksProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainWindow
{
    public partial class Tovar : Form
    {
        public static Bitmap mm { get; set; }
        public Tovar()
        {
            InitializeComponent();
        }

        private void Escape_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                var the = new Thread(openlate);
                the.SetApartmentState(ApartmentState.STA);
                the.Start();
            }
            catch
            {
                this.Close();
                var the = new Thread(openlate);
                the.SetApartmentState(ApartmentState.STA);
                the.Start();
            }
        }
        public void openlate()
        {

            Application.Run(new MainForm());

        }

        private void Tovar_Load(object sender, EventArgs e)
        {

        }
        private void NewTovar_click(object sender, EventArgs e)
        {
            Program.name = nameTovar.Text;
            Program.description = DescriptionTovar.Text;
            Program.price = int.Parse(priceTxt.Text);

            try
            {
                this.Close();
                var the = new Thread(openlate);
                the.SetApartmentState(ApartmentState.STA);
                the.Start();
            }
            catch
            {
                this.Close();
                var the = new Thread(openlate);
                the.SetApartmentState(ApartmentState.STA);
                the.Start();
            }


        }

        private void Change_avatar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Images (*.jpg; *.jpeg; *.gif; *.bmp; *.ico; *.png) | *.jpg; *.jpeg; *.gif; *.bmp; *.ico; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap myImage = new Bitmap(openFileDialog1.FileName);
                if (myImage.Size.Height > pictureBox1.Size.Height & myImage.Size.Width > pictureBox1.Size.Width)
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox1.Image = (Image)myImage;
                    ImageList imageList = new ImageList();
                    imageList.Images.Add(myImage);
                    mm = myImage;

                }
                else
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    pictureBox1.Image = (Image)myImage;
                    mm = myImage;
                }
            }
        }


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Tovarlabel_Click(object sender, EventArgs e)
        {

        }
    }
}

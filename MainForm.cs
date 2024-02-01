using mainWindow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MaksProject
{
    public partial class MainForm : Form
    {
        public static Bitmap m {  get; set; }
        public MainForm()
        {
            InitializeComponent();
            listView.SmallImageList = imageList1;
            checkNew();
            LoadItems();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            var thread1 = new Thread(openChangeTovar);
            thread1.SetApartmentState(ApartmentState.STA);
            thread1.Start();
            /*
             * ListViewItem lvi = new ListViewItem();
            lvi.Text = Program.name;
            lvi.ImageIndex = 0;
            listView.Items.Add(lvi);*/
        }
        private void LoadItems()
        {
            if (Program.name != null)
            {
                ListViewItem lvi = new ListViewItem();

                lvi.Text = Program.name;
                lvi.ImageIndex = 1;
                listView.Items.Add(lvi);
            }
            else
            {
                Console.WriteLine("Error 202");
            }
            /*
            ListViewItem lvi = new ListViewItem();
            
            lvi.Text = Program.name;
            lvi.ImageIndex = 0;
            listView.Items.Add(lvi); */


        }
        public void openChangeTovar()
        {
            Application.Run(new Tovar());
        }
        private void checkNew()
        {
            /*if (Tovar.mm != null)
            {
                m = Tovar.mm;
                 = m;
            }
            else
            {
               
            }*/
        }
        
    }
}

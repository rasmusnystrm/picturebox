using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picturebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile(@"c:\monke.png");
            openFileDialog1.ShowDialog();
            string filePath = openFileDialog1.FileName;
            pictureBox1.Image = Image.FromFile(filePath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"c:\monke.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Image.FromFile(@"c:\monke.png");
        }
    }
}

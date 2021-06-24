using System;
using System.Windows.Forms;

namespace HeadFirst.Proxy.VirtualProxy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void buttonTestImageProxy_Click(object sender, EventArgs e)
        {
            this.pictureBox.Image = new ImageProxy().Image;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

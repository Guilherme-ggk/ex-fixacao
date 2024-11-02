using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTempo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeladeLoginEstilizada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text.Equals("Guilherme") && textBox2.Text.Equals("30755"))
                {
                    var Menu = new Pagina();

                    Menu.Show();

                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("invalid user or password!",
                        "Message",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    textBox1.Focus();
                    textBox2.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("invalid user or password!",
                        ex.Message,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

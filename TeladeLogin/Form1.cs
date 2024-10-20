using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeladeLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(TxtUsuario.Text.Equals("Guilherme") && TxtSenha.Text.Equals("123"))
                {
                    // vai para a aréa restrita
                    var menu = new AreaRestrita();
                    menu.Show();

                    this.Visible = false;


                }
                else
                {
                    MessageBox.Show("usúario ou senha inválidos", "Desculpe",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    TxtUsuario.Focus();
                    TxtSenha.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Desculpe.", ex.Message,
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            }
        }
    }
}

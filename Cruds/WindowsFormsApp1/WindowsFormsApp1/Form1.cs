using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Form frm11;
        public Form1()
        {
            InitializeComponent();
        
        }

        public void Formshow(Form Frm)
        {
            ButtonClose();
            frm11 = Frm;
            Frm.TopLevel = false;
            PanelForm.Controls.Add(Frm);
            Frm.BringToFront();
            Frm.Show();
            
        }

        public void ButtonActive(Button frm11)
        {
            foreach(Control ctrl in PanelPrincipal.Controls)
                ctrl.ForeColor = Color.Black;

            frm11.ForeColor = Color.Black;
        }

        public void ButtonClose()
        {
           if(frm11 != null)
                frm11.Close();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            ButtonActive(BtnHome);
            ButtonClose();  
        }

        private void BtnDados_Click(object sender, EventArgs e)
        {
            ButtonActive(BtnDados);
            Formshow(new FrmDados());
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

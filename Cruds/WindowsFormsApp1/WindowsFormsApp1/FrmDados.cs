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
    public partial class FrmDados : Form
    {
        public FrmDados()
        {
            InitializeComponent();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmCadastro())
            {
                frm.ShowDialog();
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(DgvLivros.Rows[DgvLivros.CurrentCell.RowIndex].Cells["id"].Value);
            using (var frm = new FrmCadastro())
            {
                frm.ShowDialog();
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(DgvLivros.Rows[DgvLivros.CurrentCell.RowIndex].Cells["id"].Value);
            using (var frm = new FrmCadastro())
            {
                frm.ShowDialog();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}

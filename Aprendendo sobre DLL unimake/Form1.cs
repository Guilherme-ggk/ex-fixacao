using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unimake.Security.Platform;

namespace Aprendendo_sobre_DLL_unimake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNconsultaSuutatus_Click(object sender, EventArgs e)
        {

        }

        private void BTNconsultaSituação_Click(object sender, EventArgs e)
        {

        }

        //  Caminho para o certificado digital

        private static string PathCertificadoDigital { get; set; } = "@D:projeto/dll/certificado";

        // senha do certificado digital
        private static string SenhaCertificadoDigital { get; set; } = "123456789";


        // field pasta para os certificados digitais

        private static X509Certificate2 CertificadoSelecionadoField;

        public static X509Certificate2 CertificadoSelecionado
        {
            get
            {
                if (CertificadoSelecionado == null)
                {
                    CertificadoSelecionadoField = new CertificadoDigital().CarregarCertificadoDigitalA1(PathCertificadoDigital, SenhaCertificadoDigital);

                }
                return CertificadoSelecionadoField;

            }
            private set => throw new Exception("Não é possivel carregar!");
        }

    }
}

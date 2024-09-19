using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace Leitor_de_QRcode
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

        private void button1_Click(object sender, EventArgs e)
        {
            GerarQRcode(pictureBox1);
        }
        static void GerarQRcode(PictureBox pictureBox1)
        {
            Url generator = new Url("https://www.linkedin.com/public-profile/settings?trk=d_flagship3_profile_self_view_public_profile");

            string payload = generator.ToString();

            QRCodeGenerator QRCODER = new QRCodeGenerator();
            QRCodeData qrcoderDATAR = QRCODER.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
            QRCode qrcod = new QRCode(qrcoderDATAR);
            pictureBox1.Image = qrcod.GetGraphic(4);
            
        }
    }
}

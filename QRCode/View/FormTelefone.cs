using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QRCoder.PayloadGenerator;

namespace QRCodeApplication.View
{
    public partial class FormTelefone : Form
    {
        public FormTelefone()
        {
            InitializeComponent();
        }

        private void btnQRCodeApplicationApplication_Click(object sender, EventArgs e)
        {
            GerarQRCodeApplicationApplication();
        }

        private void GerarQRCodeApplicationApplication()
        {
            string telefone = txbTelefone.Text;

            if (telefone != "")
            {
                PhoneNumber generator = new PhoneNumber(telefone);

                string payload = generator.ToString();
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                picQRCodeApplicationApplication.Image = qrCode.GetGraphic(20);
                MessageBox.Show("QR Code gerado com sucesso!");
            }

            else
            {
                MessageBox.Show("Por favor, preencha todos os campos!");
            }
        }
    }
}

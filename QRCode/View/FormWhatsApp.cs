using QRCodeApplicationApplication;
using QRCodeApplication;
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
using QRCoder;

namespace QRCodeApplicationApplicationApplication.View
{
    public partial class FormWhatsApp : Form
    {
        public FormWhatsApp()
        {
            InitializeComponent();
        }

        #region Ação do botão Gerar QR Code
        private void btnQRCodeApplicationApplicationApplication_Click(object sender, EventArgs e)
        {
            pictureFundoBranco.Hide();
            GerarQRCodeApplicationApplicationApplication();
        }
        #endregion

        #region Método para gerar o QR Code
        private void GerarQRCodeApplicationApplicationApplication()
        {
            string telefone = txbTelefone.Text;
            string texto = txtbTexto.Text;

            if (telefone != "" && texto != "")
            {
                WhatsAppMessage generator = new WhatsAppMessage(telefone, texto);
                string payload = generator.ToString();
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
                QRCoder.QRCode qrCode = new QRCoder.QRCode(qrCodeData);
                picQRCodeApplicationApplicationApplication.Image = qrCode.GetGraphic(20);
                MessageBox.Show("QR Code gerado com sucesso!");
            }

            else
            {
                pictureFundoBranco.Show();
                MessageBox.Show("Por favor, preencha todos os campos!");
            }
        }
        #endregion
    }
}

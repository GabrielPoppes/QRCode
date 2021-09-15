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
using QRCodeApplication;

namespace QRCodeApplication.View
{
    public partial class FormSite : Form
    {
        public FormSite()
        {
            InitializeComponent();
        }

        #region Ação do botão Gerar QR Code
        private void btnQRCodeApplicationApplication_Click(object sender, EventArgs e) // Botão Gerar QR Code
        {
            pictureFundoBranco.Hide();
            GerarQRCodeApplicationApplication();
        }
        #endregion

        #region Método para gerar o QR Code
        private void GerarQRCodeApplicationApplication()
        {
            string site = txbSite.Text;

            if (site != "")
            {
                Url generator = new Url(site);

                string payload = generator.ToString();
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
                QRCoder.QRCode qrCode = new QRCoder.QRCode(qrCodeData);
                picQRCodeApplicationApplication.Image = qrCode.GetGraphic(20);
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

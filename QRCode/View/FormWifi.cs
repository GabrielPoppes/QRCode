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
    public partial class FormWifi : Form
    {
        public FormWifi()
        {
            InitializeComponent();
        }

        #region Evento para senha digitada sair com asterisco (*)
        private void txtbSenhaRede_TextChanged(object sender, EventArgs e)
        {
            txtbSenhaRede.PasswordChar = '*';
        }
        #endregion

        private void GerarQRCode()
        {
            string nomeWifi = txtbNomeRede.Text;
            string senhaWifi = txtbSenhaRede.Text;

            if (nomeWifi != "" && senhaWifi != "")
            {

                WiFi generator = new PayloadGenerator.WiFi(nomeWifi, senhaWifi, PayloadGenerator.WiFi.Authentication.WPA);

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

        private void btnQRCodeApplicationApplication_Click(object sender, EventArgs e)
        {
            GerarQRCode();
        }
    }
}

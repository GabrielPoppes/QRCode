using QRCodeApplication;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QRCoder.PayloadGenerator;

namespace QRCodeApplicationApplication.View
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

        #region Ação do botão Gerar QR Code
        private void btnQRCodeApplicationApplicationApplication_Click(object sender, EventArgs e)
        {
            pictureFundoBranco.Hide();
            GerarQRCodeApplication();
        }
        #endregion

        #region Método para gerar o QR Code
        private void GerarQRCodeApplication()
        {
            string nomeWifi = txtbNomeRede.Text;
            string senhaWifi = txtbSenhaRede.Text;

            if (nomeWifi != "" && senhaWifi != "")
            {
                WiFi generator = new PayloadGenerator.WiFi(nomeWifi, senhaWifi, PayloadGenerator.WiFi.Authentication.WPA);

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

        #region Evento quando clica no botão Imprimir
        private void btnImprimir_Click(object sender, EventArgs e) // Botão Imprimir
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += myPrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }
        #endregion

        #region Método para imprimir
        private void myPrintPage(object sender, PrintPageEventArgs e) // Método imprimir
        {
            Bitmap bm = new Bitmap(picQRCodeApplicationApplicationApplication.Width, picQRCodeApplicationApplicationApplication.Height);
            picQRCodeApplicationApplicationApplication.DrawToBitmap(bm, new Rectangle(0, 0, picQRCodeApplicationApplicationApplication.Width, picQRCodeApplicationApplicationApplication.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }
        #endregion 
    }
}

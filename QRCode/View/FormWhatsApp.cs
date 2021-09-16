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
using System.Drawing.Printing;

namespace QRCodeApplicationApplicationApplication.View
{
    public partial class FormWhatsApp : Form
    {
        public FormWhatsApp()
        {
            InitializeComponent();
            HideErrorNotification(); // Esconder notificação de erro
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

                btnImprimir.Enabled = true;
                HideErrorNotification();
            }

            else
            {
                btnImprimir.Enabled = false;
                pictureFundoBranco.Show();
                ShowErrorNotification();
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

        #region Escondendo notificação de erro
        private void HideErrorNotification()
        {
            lblErrorNotification.Hide();
            panelErrorNotification.Hide();
        }
        #endregion

        #region Exibindo notificação de erro
        private void ShowErrorNotification()
        {
            lblErrorNotification.Show();
            panelErrorNotification.Show();
        }
        #endregion

        #region Botão Close para fechar a notificação de erro
        private void pictureCloseError_Click_1(object sender, EventArgs e)
        {
            HideErrorNotification();
        }
        #endregion
    }
}


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
using QRCodeApplicationApplication;
using System.Security.Policy;
using QRCoder;
using System.Drawing.Printing;

namespace QRCodeApplicationApplication.View
{
    public partial class FormSite : Form
    {
        public FormSite()
        {
            InitializeComponent();
        }

        #region Ação do botão Gerar QR Code
        private void btnQRCodeApplicationApplicationApplication_Click(object sender, EventArgs e) // Botão Gerar QR Code
        {
            pictureFundoBranco.Hide();
            GerarQRCodeApplicationApplicationApplication();
        }
        #endregion

        #region Método para gerar o QR Code
        private void GerarQRCodeApplicationApplicationApplication()
        {
            string site = txbSite.Text;

            if (site != "")
            {
                System.Security.Policy.Url generator = new System.Security.Policy.Url(site);

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

        private void btnImprimir_Click(object sender, EventArgs e)
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

        private void myPrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(picQRCodeApplicationApplicationApplication.Width, picQRCodeApplicationApplicationApplication.Height);
            picQRCodeApplicationApplicationApplication.DrawToBitmap(bm, new Rectangle(0, 0, picQRCodeApplicationApplicationApplication.Width, picQRCodeApplicationApplicationApplication.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }
    }
}

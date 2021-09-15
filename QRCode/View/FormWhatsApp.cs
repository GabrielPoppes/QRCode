﻿using QRCodeApplication;
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

namespace QRCodeApplicationApplication.View
{
    public partial class FormWhatsApp : Form
    {
        public FormWhatsApp()
        {
            InitializeComponent();
        }

        #region Ação do botão Gerar QR Code
        private void btnQRCodeApplicationApplication_Click(object sender, EventArgs e)
        {
            GerarQRCodeApplicationApplication();
        }
        #endregion

        #region Método para gerar o QR Code
        private void GerarQRCodeApplicationApplication()
        {
            string telefone = txbTelefone.Text;
            string texto = txtbTexto.Text;

            if (telefone != "" && texto != "")
            {
                WhatsAppMessage generator = new WhatsAppMessage(telefone, texto);
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
        #endregion
    }
}

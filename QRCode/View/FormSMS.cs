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
    public partial class FormSMS : Form
    {
        public FormSMS()
        {
            InitializeComponent();
        }

        private void btnQRCodeApplication_Click(object sender, EventArgs e)
        {
            GerarQRCodeApplication();
        }

        private void GerarQRCodeApplication()
        {
            string telefone = txbTelefone.Text;

            if (telefone != "")
            {
                SMS generator = new SMS(telefone);
                string payload = generator.ToString();
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                picQRCodeApplication.Image = qrCode.GetGraphic(20);
                MessageBox.Show("QR Code gerado com sucesso!");
            }

            else
            {
                MessageBox.Show("Por favor, preencha todos os campos!");
            }
        }
    }
}
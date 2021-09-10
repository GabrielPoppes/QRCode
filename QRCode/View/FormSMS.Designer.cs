
namespace QRCodeApplication.View
{
    partial class FormSMS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picQRCode = new System.Windows.Forms.PictureBox();
            this.btnQrCode = new System.Windows.Forms.Button();
            this.txbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txbMensagem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // picQRCode
            // 
            this.picQRCode.Location = new System.Drawing.Point(441, 66);
            this.picQRCode.Name = "picQRCode";
            this.picQRCode.Size = new System.Drawing.Size(253, 241);
            this.picQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQRCode.TabIndex = 0;
            this.picQRCode.TabStop = false;
            // 
            // btnQrCode
            // 
            this.btnQrCode.Location = new System.Drawing.Point(184, 264);
            this.btnQrCode.Name = "btnQrCode";
            this.btnQrCode.Size = new System.Drawing.Size(211, 43);
            this.btnQrCode.TabIndex = 1;
            this.btnQrCode.Text = "GERAR QR CODE";
            this.btnQrCode.UseVisualStyleBackColor = true;
            this.btnQrCode.Click += new System.EventHandler(this.btnQrCode_Click);
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(184, 171);
            this.txbTelefone.Mask = "(99) 00000-0000";
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(211, 20);
            this.txbTelefone.TabIndex = 2;
            // 
            // txbMensagem
            // 
            this.txbMensagem.Location = new System.Drawing.Point(184, 225);
            this.txbMensagem.Name = "txbMensagem";
            this.txbMensagem.Size = new System.Drawing.Size(211, 20);
            this.txbMensagem.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Celular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mensagem";
            // 
            // FormSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 468);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbMensagem);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.btnQrCode);
            this.Controls.Add(this.picQRCode);
            this.Name = "FormSMS";
            this.Text = "FormSMS";
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picQRCode;
        private System.Windows.Forms.Button btnQrCode;
        private System.Windows.Forms.MaskedTextBox txbTelefone;
        private System.Windows.Forms.TextBox txbMensagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
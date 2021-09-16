
namespace QRCodeApplicationApplicationApplication.View
{
    partial class FormWhatsApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnQRCodeApplicationApplicationApplication = new System.Windows.Forms.Button();
            this.picQRCodeApplicationApplicationApplication = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbTexto = new System.Windows.Forms.TextBox();
            this.pictureFundoBranco = new System.Windows.Forms.PictureBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.pictureCloseError = new System.Windows.Forms.PictureBox();
            this.lblErrorNotification = new System.Windows.Forms.Label();
            this.panelErrorNotification = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCodeApplicationApplicationApplication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFundoBranco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCloseError)).BeginInit();
            this.panelErrorNotification.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(318, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Celular";
            // 
            // txbTelefone
            // 
            this.txbTelefone.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTelefone.Location = new System.Drawing.Point(385, 401);
            this.txbTelefone.Mask = "(99) 00000-0000";
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(211, 25);
            this.txbTelefone.TabIndex = 7;
            // 
            // btnQRCodeApplicationApplicationApplication
            // 
            this.btnQRCodeApplicationApplicationApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(112)))), ((int)(((byte)(137)))));
            this.btnQRCodeApplicationApplicationApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQRCodeApplicationApplicationApplication.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQRCodeApplicationApplicationApplication.Location = new System.Drawing.Point(321, 467);
            this.btnQRCodeApplicationApplicationApplication.Name = "btnQRCodeApplicationApplicationApplication";
            this.btnQRCodeApplicationApplicationApplication.Size = new System.Drawing.Size(134, 28);
            this.btnQRCodeApplicationApplicationApplication.TabIndex = 6;
            this.btnQRCodeApplicationApplicationApplication.Text = "GERAR QR CODE";
            this.btnQRCodeApplicationApplicationApplication.UseVisualStyleBackColor = false;
            this.btnQRCodeApplicationApplicationApplication.Click += new System.EventHandler(this.btnQRCodeApplicationApplicationApplication_Click);
            // 
            // picQRCodeApplicationApplicationApplication
            // 
            this.picQRCodeApplicationApplicationApplication.Location = new System.Drawing.Point(321, 106);
            this.picQRCodeApplicationApplicationApplication.Name = "picQRCodeApplicationApplicationApplication";
            this.picQRCodeApplicationApplicationApplication.Size = new System.Drawing.Size(275, 275);
            this.picQRCodeApplicationApplicationApplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQRCodeApplicationApplicationApplication.TabIndex = 5;
            this.picQRCodeApplicationApplicationApplication.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(318, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Texto";
            // 
            // txtbTexto
            // 
            this.txtbTexto.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTexto.Location = new System.Drawing.Point(385, 432);
            this.txtbTexto.Name = "txtbTexto";
            this.txtbTexto.Size = new System.Drawing.Size(211, 25);
            this.txtbTexto.TabIndex = 11;
            // 
            // pictureFundoBranco
            // 
            this.pictureFundoBranco.Image = global::QRCode.Properties.Resources.fundobranco;
            this.pictureFundoBranco.Location = new System.Drawing.Point(321, 106);
            this.pictureFundoBranco.Name = "pictureFundoBranco";
            this.pictureFundoBranco.Size = new System.Drawing.Size(275, 275);
            this.pictureFundoBranco.TabIndex = 12;
            this.pictureFundoBranco.TabStop = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(112)))), ((int)(((byte)(137)))));
            this.btnImprimir.Enabled = false;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(462, 467);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(134, 28);
            this.btnImprimir.TabIndex = 17;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // pictureCloseError
            // 
            this.pictureCloseError.Image = global::QRCode.Properties.Resources.closeIco48x48;
            this.pictureCloseError.Location = new System.Drawing.Point(876, 18);
            this.pictureCloseError.Name = "pictureCloseError";
            this.pictureCloseError.Size = new System.Drawing.Size(20, 20);
            this.pictureCloseError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCloseError.TabIndex = 20;
            this.pictureCloseError.TabStop = false;
            this.pictureCloseError.Click += new System.EventHandler(this.pictureCloseError_Click_1);
            // 
            // lblErrorNotification
            // 
            this.lblErrorNotification.AutoSize = true;
            this.lblErrorNotification.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNotification.ForeColor = System.Drawing.Color.White;
            this.lblErrorNotification.Location = new System.Drawing.Point(287, 19);
            this.lblErrorNotification.Name = "lblErrorNotification";
            this.lblErrorNotification.Size = new System.Drawing.Size(368, 17);
            this.lblErrorNotification.TabIndex = 19;
            this.lblErrorNotification.Text = "Por favor, preencha todos os campos para gerar o QR Code!";
            // 
            // panelErrorNotification
            // 
            this.panelErrorNotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelErrorNotification.Controls.Add(this.pictureCloseError);
            this.panelErrorNotification.Controls.Add(this.lblErrorNotification);
            this.panelErrorNotification.Location = new System.Drawing.Point(-5, 0);
            this.panelErrorNotification.Name = "panelErrorNotification";
            this.panelErrorNotification.Size = new System.Drawing.Size(956, 54);
            this.panelErrorNotification.TabIndex = 19;
            // 
            // FormWhatsApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(65)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(946, 568);
            this.Controls.Add(this.panelErrorNotification);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.pictureFundoBranco);
            this.Controls.Add(this.txtbTexto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.btnQRCodeApplicationApplicationApplication);
            this.Controls.Add(this.picQRCodeApplicationApplicationApplication);
            this.Name = "FormWhatsApp";
            this.Text = "FormWhatsApp";
            ((System.ComponentModel.ISupportInitialize)(this.picQRCodeApplicationApplicationApplication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFundoBranco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCloseError)).EndInit();
            this.panelErrorNotification.ResumeLayout(false);
            this.panelErrorNotification.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txbTelefone;
        private System.Windows.Forms.Button btnQRCodeApplicationApplicationApplication;
        private System.Windows.Forms.PictureBox picQRCodeApplicationApplicationApplication;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbTexto;
        private System.Windows.Forms.PictureBox pictureFundoBranco;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.PictureBox pictureCloseError;
        private System.Windows.Forms.Label lblErrorNotification;
        private System.Windows.Forms.Panel panelErrorNotification;
    }
}
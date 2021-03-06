
namespace QRCodeApplicationApplication.View
{
    partial class FormWifi
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
            this.btnQRCodeApplicationApplicationApplication = new System.Windows.Forms.Button();
            this.txtbNomeRede = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbSenhaRede = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.panelErrorNotification = new System.Windows.Forms.Panel();
            this.lblErrorNotification = new System.Windows.Forms.Label();
            this.pictureCloseError = new System.Windows.Forms.PictureBox();
            this.pictureFundoBranco = new System.Windows.Forms.PictureBox();
            this.picQRCodeApplicationApplicationApplication = new System.Windows.Forms.PictureBox();
            this.panelErrorNotification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCloseError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFundoBranco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCodeApplicationApplicationApplication)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(318, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome da rede";
            // 
            // btnQRCodeApplicationApplicationApplication
            // 
            this.btnQRCodeApplicationApplicationApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(112)))), ((int)(((byte)(137)))));
            this.btnQRCodeApplicationApplicationApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQRCodeApplicationApplicationApplication.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQRCodeApplicationApplicationApplication.Location = new System.Drawing.Point(321, 470);
            this.btnQRCodeApplicationApplicationApplication.Name = "btnQRCodeApplicationApplicationApplication";
            this.btnQRCodeApplicationApplicationApplication.Size = new System.Drawing.Size(134, 28);
            this.btnQRCodeApplicationApplicationApplication.TabIndex = 6;
            this.btnQRCodeApplicationApplicationApplication.Text = "GERAR QR CODE";
            this.btnQRCodeApplicationApplicationApplication.UseVisualStyleBackColor = false;
            this.btnQRCodeApplicationApplicationApplication.Click += new System.EventHandler(this.btnQRCodeApplicationApplicationApplication_Click);
            // 
            // txtbNomeRede
            // 
            this.txtbNomeRede.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNomeRede.Location = new System.Drawing.Point(418, 401);
            this.txtbNomeRede.Name = "txtbNomeRede";
            this.txtbNomeRede.Size = new System.Drawing.Size(178, 25);
            this.txtbNomeRede.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(318, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Senha da rede";
            // 
            // txtbSenhaRede
            // 
            this.txtbSenhaRede.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSenhaRede.Location = new System.Drawing.Point(418, 435);
            this.txtbSenhaRede.Name = "txtbSenhaRede";
            this.txtbSenhaRede.Size = new System.Drawing.Size(179, 25);
            this.txtbSenhaRede.TabIndex = 11;
            this.txtbSenhaRede.TextChanged += new System.EventHandler(this.txtbSenhaRede_TextChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(112)))), ((int)(((byte)(137)))));
            this.btnImprimir.Enabled = false;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(462, 470);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(134, 28);
            this.btnImprimir.TabIndex = 17;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // panelErrorNotification
            // 
            this.panelErrorNotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelErrorNotification.Controls.Add(this.pictureCloseError);
            this.panelErrorNotification.Controls.Add(this.lblErrorNotification);
            this.panelErrorNotification.Location = new System.Drawing.Point(-8, 0);
            this.panelErrorNotification.Name = "panelErrorNotification";
            this.panelErrorNotification.Size = new System.Drawing.Size(956, 54);
            this.panelErrorNotification.TabIndex = 18;
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
            // pictureCloseError
            // 
            this.pictureCloseError.Image = global::QRCode.Properties.Resources.closeIco48x48;
            this.pictureCloseError.Location = new System.Drawing.Point(876, 18);
            this.pictureCloseError.Name = "pictureCloseError";
            this.pictureCloseError.Size = new System.Drawing.Size(20, 20);
            this.pictureCloseError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCloseError.TabIndex = 20;
            this.pictureCloseError.TabStop = false;
            this.pictureCloseError.Click += new System.EventHandler(this.pictureCloseError_Click);
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
            // picQRCodeApplicationApplicationApplication
            // 
            this.picQRCodeApplicationApplicationApplication.Location = new System.Drawing.Point(321, 106);
            this.picQRCodeApplicationApplicationApplication.Name = "picQRCodeApplicationApplicationApplication";
            this.picQRCodeApplicationApplicationApplication.Size = new System.Drawing.Size(275, 275);
            this.picQRCodeApplicationApplicationApplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQRCodeApplicationApplicationApplication.TabIndex = 5;
            this.picQRCodeApplicationApplicationApplication.TabStop = false;
            // 
            // FormWifi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(65)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(946, 568);
            this.Controls.Add(this.panelErrorNotification);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.pictureFundoBranco);
            this.Controls.Add(this.txtbSenhaRede);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbNomeRede);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQRCodeApplicationApplicationApplication);
            this.Controls.Add(this.picQRCodeApplicationApplicationApplication);
            this.Name = "FormWifi";
            this.Text = "FormWifi";
            this.panelErrorNotification.ResumeLayout(false);
            this.panelErrorNotification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCloseError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFundoBranco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCodeApplicationApplicationApplication)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQRCodeApplicationApplicationApplication;
        private System.Windows.Forms.PictureBox picQRCodeApplicationApplicationApplication;
        private System.Windows.Forms.TextBox txtbNomeRede;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbSenhaRede;
        private System.Windows.Forms.PictureBox pictureFundoBranco;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Panel panelErrorNotification;
        private System.Windows.Forms.Label lblErrorNotification;
        private System.Windows.Forms.PictureBox pictureCloseError;
    }
}
﻿
namespace QRCodeApplicationApplication.View
{
    partial class FormSite
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
            this.picQRCodeApplicationApplicationApplication = new System.Windows.Forms.PictureBox();
            this.txbSite = new System.Windows.Forms.TextBox();
            this.pictureFundoBranco = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCodeApplicationApplicationApplication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFundoBranco)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(305, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Site";
            // 
            // btnQRCodeApplicationApplicationApplication
            // 
            this.btnQRCodeApplicationApplicationApplication.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQRCodeApplicationApplicationApplication.Location = new System.Drawing.Point(372, 378);
            this.btnQRCodeApplicationApplicationApplication.Name = "btnQRCodeApplicationApplicationApplication";
            this.btnQRCodeApplicationApplicationApplication.Size = new System.Drawing.Size(211, 43);
            this.btnQRCodeApplicationApplicationApplication.TabIndex = 10;
            this.btnQRCodeApplicationApplicationApplication.Text = "GERAR QR CODE";
            this.btnQRCodeApplicationApplicationApplication.UseVisualStyleBackColor = true;
            this.btnQRCodeApplicationApplicationApplication.Click += new System.EventHandler(this.btnQRCodeApplicationApplicationApplication_Click);
            // 
            // picQRCodeApplicationApplicationApplication
            // 
            this.picQRCodeApplicationApplicationApplication.Location = new System.Drawing.Point(308, 48);
            this.picQRCodeApplicationApplicationApplication.Name = "picQRCodeApplicationApplicationApplication";
            this.picQRCodeApplicationApplicationApplication.Size = new System.Drawing.Size(275, 275);
            this.picQRCodeApplicationApplicationApplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQRCodeApplicationApplicationApplication.TabIndex = 9;
            this.picQRCodeApplicationApplicationApplication.TabStop = false;
            // 
            // txbSite
            // 
            this.txbSite.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSite.Location = new System.Drawing.Point(372, 343);
            this.txbSite.Name = "txbSite";
            this.txbSite.Size = new System.Drawing.Size(211, 25);
            this.txbSite.TabIndex = 13;
            // 
            // pictureFundoBranco
            // 
            this.pictureFundoBranco.Image = global::QRCode.Properties.Resources.fundobranco;
            this.pictureFundoBranco.Location = new System.Drawing.Point(308, 48);
            this.pictureFundoBranco.Name = "pictureFundoBranco";
            this.pictureFundoBranco.Size = new System.Drawing.Size(275, 275);
            this.pictureFundoBranco.TabIndex = 14;
            this.pictureFundoBranco.TabStop = false;
            // 
            // FormSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(65)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(889, 468);
            this.Controls.Add(this.pictureFundoBranco);
            this.Controls.Add(this.txbSite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQRCodeApplicationApplicationApplication);
            this.Controls.Add(this.picQRCodeApplicationApplicationApplication);
            this.Name = "FormSite";
            this.Text = "FormSite";
            ((System.ComponentModel.ISupportInitialize)(this.picQRCodeApplicationApplicationApplication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFundoBranco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQRCodeApplicationApplicationApplication;
        private System.Windows.Forms.PictureBox picQRCodeApplicationApplicationApplication;
        private System.Windows.Forms.TextBox txbSite;
        private System.Windows.Forms.PictureBox pictureFundoBranco;
    }
}
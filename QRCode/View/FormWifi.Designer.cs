﻿
namespace QRCodeApplication.View
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
            this.txbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnQRCodeApplicationApplication = new System.Windows.Forms.Button();
            this.picQRCodeApplicationApplication = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCodeApplicationApplication)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(261, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Celular";
            // 
            // txbTelefone
            // 
            this.txbTelefone.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTelefone.Location = new System.Drawing.Point(328, 331);
            this.txbTelefone.Mask = "(99) 00000-0000";
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(211, 25);
            this.txbTelefone.TabIndex = 7;
            // 
            // btnQRCodeApplicationApplication
            // 
            this.btnQRCodeApplicationApplication.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQRCodeApplicationApplication.Location = new System.Drawing.Point(328, 369);
            this.btnQRCodeApplicationApplication.Name = "btnQRCodeApplicationApplication";
            this.btnQRCodeApplicationApplication.Size = new System.Drawing.Size(211, 43);
            this.btnQRCodeApplicationApplication.TabIndex = 6;
            this.btnQRCodeApplicationApplication.Text = "GERAR QR CODE";
            this.btnQRCodeApplicationApplication.UseVisualStyleBackColor = true;
            // 
            // picQRCodeApplicationApplication
            // 
            this.picQRCodeApplicationApplication.Location = new System.Drawing.Point(264, 39);
            this.picQRCodeApplicationApplication.Name = "picQRCodeApplicationApplication";
            this.picQRCodeApplicationApplication.Size = new System.Drawing.Size(275, 275);
            this.picQRCodeApplicationApplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQRCodeApplicationApplication.TabIndex = 5;
            this.picQRCodeApplicationApplication.TabStop = false;
            // 
            // FormWifi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 468);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.btnQRCodeApplicationApplication);
            this.Controls.Add(this.picQRCodeApplicationApplication);
            this.Name = "FormWifi";
            this.Text = "FormWifi";
            ((System.ComponentModel.ISupportInitialize)(this.picQRCodeApplicationApplication)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txbTelefone;
        private System.Windows.Forms.Button btnQRCodeApplicationApplication;
        private System.Windows.Forms.PictureBox picQRCodeApplicationApplication;
    }
}

namespace QRCodeApplicationApplication.View
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
            this.picQRCodeApplication = new System.Windows.Forms.PictureBox();
            this.btnQRCodeApplication = new System.Windows.Forms.Button();
            this.txbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCodeApplication)).BeginInit();
            this.SuspendLayout();
            // 
            // picQRCodeApplication
            // 
            this.picQRCodeApplication.Location = new System.Drawing.Point(256, 48);
            this.picQRCodeApplication.Name = "picQRCodeApplication";
            this.picQRCodeApplication.Size = new System.Drawing.Size(275, 275);
            this.picQRCodeApplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQRCodeApplication.TabIndex = 0;
            this.picQRCodeApplication.TabStop = false;
            // 
            // btnQRCodeApplication
            // 
            this.btnQRCodeApplication.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQRCodeApplication.Location = new System.Drawing.Point(320, 378);
            this.btnQRCodeApplication.Name = "btnQRCodeApplication";
            this.btnQRCodeApplication.Size = new System.Drawing.Size(211, 43);
            this.btnQRCodeApplication.TabIndex = 1;
            this.btnQRCodeApplication.Text = "GERAR QR CODE";
            this.btnQRCodeApplication.UseVisualStyleBackColor = true;
            this.btnQRCodeApplication.Click += new System.EventHandler(this.btnQRCodeApplication_Click);
            // 
            // txbTelefone
            // 
            this.txbTelefone.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTelefone.Location = new System.Drawing.Point(320, 340);
            this.txbTelefone.Mask = "(99) 00000-0000";
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(211, 25);
            this.txbTelefone.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(253, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Celular";
            // 
            // FormSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(65)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(889, 468);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.btnQRCodeApplication);
            this.Controls.Add(this.picQRCodeApplication);
            this.Name = "FormSMS";
            this.Text = "FormSMS";
            ((System.ComponentModel.ISupportInitialize)(this.picQRCodeApplication)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picQRCodeApplication;
        private System.Windows.Forms.Button btnQRCodeApplication;
        private System.Windows.Forms.MaskedTextBox txbTelefone;
        private System.Windows.Forms.Label label1;
    }
}

namespace QRCodeApplicationApplicationApplication
{
    partial class Loading
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelProgressBarLeft = new System.Windows.Forms.Panel();
            this.panelProgressBarRight = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.pictureBox1);
            this.panelCenter.Controls.Add(this.label2);
            this.panelCenter.Controls.Add(this.label1);
            this.panelCenter.Controls.Add(this.panelProgressBarLeft);
            this.panelCenter.Controls.Add(this.panelProgressBarRight);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(800, 450);
            this.panelCenter.TabIndex = 0;
            this.panelCenter.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCenter_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(294, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Copyright - Gabriel Poppes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(336, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "LOADING";
            // 
            // panelProgressBarLeft
            // 
            this.panelProgressBarLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(109)))), ((int)(((byte)(137)))));
            this.panelProgressBarLeft.Location = new System.Drawing.Point(0, 422);
            this.panelProgressBarLeft.Name = "panelProgressBarLeft";
            this.panelProgressBarLeft.Size = new System.Drawing.Size(38, 28);
            this.panelProgressBarLeft.TabIndex = 1;
            // 
            // panelProgressBarRight
            // 
            this.panelProgressBarRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.panelProgressBarRight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelProgressBarRight.Location = new System.Drawing.Point(0, 422);
            this.panelProgressBarRight.Name = "panelProgressBarRight";
            this.panelProgressBarRight.Size = new System.Drawing.Size(800, 28);
            this.panelProgressBarRight.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::QRCode.Properties.Resources.QRCODE_LOAD;
            this.pictureBox1.Location = new System.Drawing.Point(108, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 156);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCenter);
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelCenter.ResumeLayout(false);
            this.panelCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Panel panelProgressBarLeft;
        private System.Windows.Forms.Panel panelProgressBarRight;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


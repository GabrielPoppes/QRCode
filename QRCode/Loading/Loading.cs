using QRCodeApplicationApplicationApplicationApplication.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeApplicationApplicationApplicationApplication
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        #region Método para deixar o background degrade
        private void SetBackColorDegrade(object sender, PaintEventArgs e) // Método para deixar o plano de fundo do elemento em tom degrade
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);

            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(6, 13, 19), Color.FromArgb(0, 51, 102), 45);

            graphics.FillRectangle(br, gradient_rect);
        }
        #endregion

        #region Panel principal: alterando a cor
        private void panelCenter_Paint(object sender, PaintEventArgs e) // Panel principal
        {
            SetBackColorDegrade(sender, e);
        }
        #endregion

        #region Codificação do tempo do loading no evento timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            panelProgressBarLeft.Width += 3; // panelProgressBarLeft é a barra menor (left)
            if(panelProgressBarLeft.Width >= 799)
            {
                timer1.Stop();
                Inicio formInicio = new Inicio();
                formInicio.Show();
                this.Hide();
            }
        }
        #endregion
    }
}

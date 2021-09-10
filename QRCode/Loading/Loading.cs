using QRCode.View;
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

namespace QRCode
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void SetBackColorDegrade(object sender, PaintEventArgs e) // Método para deixar o plano de fundo do elemento em tom degrade
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);

            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(0, 102, 102), Color.FromArgb(255, 255, 255), 45);

            graphics.FillRectangle(br, gradient_rect);
        }

        private void panelCenter_Paint(object sender, PaintEventArgs e) // Panel principal
        {
            SetBackColorDegrade(sender, e);
        }

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
    }
}

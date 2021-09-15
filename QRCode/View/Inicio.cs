using QRCodeApplication.View;
using QRCodeApplicationApplication.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeApplicationApplication.View
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void CustomizeDesign() // Método para esconder os SUB Menus na inicialização do app
        {
            panelQRCodeApplication.Visible = false;
        }

        #region EsconderSubMenu
        private void HideSubMenu() // Esconder Sub Menu
        {
            if (panelQRCodeApplication.Visible == true)
                panelQRCodeApplication.Visible = false;
        }
        #endregion

        #region MostrarSubMenu
        private void ShowSubMenu(Panel subMenu) // Abrir Sub Menu
        {
            if(subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        #endregion

        private Form activeForm = null;
        private void openChildForm(Form childForm) // Método para abrir form dentro da Panel principal da tela Inicio
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnQRCodeApplication_Click(object sender, EventArgs e) // Evento clique no botão btnQRCodeApplication
        {
            ShowSubMenu(panelQRCodeApplication);
        }

        #region Botão SMS
        private void btnSMS_Click(object sender, EventArgs e)
        {
            openChildForm(new FormSMS());
            HideSubMenu();
        }
        #endregion

        #region Botão WhatsApp
        private void btnWhatsApp_Click(object sender, EventArgs e)
        {
            openChildForm(new FormWhatsApp());
            HideSubMenu();
        }
        #endregion
    }
}

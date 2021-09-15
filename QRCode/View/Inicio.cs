using QRCodeApplicationApplication.View;
using QRCodeApplicationApplicationApplication.View;
using QRCodeApplicationApplicationApplicationApplication.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeApplicationApplicationApplicationApplication.View
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        #region Método para abrir as telas dentro do Panel principal!
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
        #endregion

        #region EsconderSubMenu
        private void HideSubMenu() // Esconder Sub Menu
        {
            if (panelQRCodeApplicationApplicationApplication.Visible == true)
                panelQRCodeApplicationApplicationApplication.Visible = false;
        }

        private void CustomizeDesign() // Método para esconder os SUB Menus na inicialização do app
        {
            panelQRCodeApplicationApplicationApplication.Visible = false;
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

        #region Botão QR Code (MENU lateral)
        private void btnQRCodeApplicationApplicationApplication_Click_1(object sender, EventArgs e) // Evento clique no botão btnQRCodeApplicationApplicationApplication
        {
            ShowSubMenu(panelQRCodeApplicationApplicationApplication);
        }
        #endregion

        #region Botão SMS (MENU lateral)
        private void btnSMS_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FormSMS());
            HideSubMenu();
        }
        #endregion 

        #region Botão WhatsApp (MENU lateral)
        private void btnWhatsApp_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FormWhatsApp());
            HideSubMenu();
        }
        #endregion

        #region Botão Wi fi (MENU lateral)
        private void btnWifi_Click(object sender, EventArgs e)
        {
            openChildForm(new FormWifi());
            HideSubMenu();
        }
        #endregion

        #region Botão Telefone (MENU lateral)
        private void btnTelefone_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FormTelefone());
            HideSubMenu();
        }
        #endregion

        #region Botão Site (MENU lateral)
        private void btnSite_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FormSite());
            HideSubMenu();
        }
        #endregion

        #region Botão Inicio (MENU lateral)
        private void btnInicio_Click(object sender, EventArgs e)
        {
            openChildForm(new QRCodeApplication.View.FormAdvertising());
            HideSubMenu();
        }
        #endregion
    }
}

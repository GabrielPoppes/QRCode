﻿using QRCodeApplication.View;
using QRCodeApplicationApplication.View;
using QRCodeApplicationApplicationApplication.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeApplicationApplicationApplication.View
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            CustomizeDesign();
        }

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

        #region EsconderSubMenu
        private void HideSubMenu() // Esconder Sub Menu
        {
            if (panelQRCodeApplicationApplication.Visible == true)
                panelQRCodeApplicationApplication.Visible = false;
        }

        private void CustomizeDesign() // Método para esconder os SUB Menus na inicialização do app
        {
            panelQRCodeApplicationApplication.Visible = false;
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
        private void btnQRCodeApplicationApplication_Click(object sender, EventArgs e) // Evento clique no botão btnQRCodeApplicationApplication
        {
            ShowSubMenu(panelQRCodeApplicationApplication);
        }
        #endregion

        #region Botão SMS (MENU lateral)
        private void btnSMS_Click(object sender, EventArgs e)
        {
            openChildForm(new FormSMS());
            HideSubMenu();
        }
        #endregion 

        #region Botão WhatsApp (MENU lateral)
        private void btnWhatsApp_Click(object sender, EventArgs e)
        {
            openChildForm(new FormWhatsApp());
            HideSubMenu();
        }
        #endregion

        #region Botão Wi fi (MENU lateral)
        private void btnWiFi_Click(object sender, EventArgs e)
        {
            openChildForm(new FormWifi());
            HideSubMenu();
        }
        #endregion

        #region Botão Telefone (MENU lateral)
        private void btnTelefone_Click(object sender, EventArgs e)
        {
            openChildForm(new FormTelefone());
            HideSubMenu();
        }
        #endregion

        #region Botão Site (MENU lateral)
        private void btnSite_Click(object sender, EventArgs e)
        {
            openChildForm(new FormSite());
            HideSubMenu();
        }
        #endregion
    }
}

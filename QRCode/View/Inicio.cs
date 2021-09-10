﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeApplication.View
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
            panelQRCode.Visible = false;
        }

        #region EsconderSubMenu
        private void HideSubMenu() // Esconder Sub Menu
        {
            if (panelQRCode.Visible == true)
                panelQRCode.Visible = false;
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
        private void openChildForm(Form childForm)
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

        private void btnQRCode_Click(object sender, EventArgs e) // Evento clique no botão btnQRCode
        {
            ShowSubMenu(panelQRCode);
        }

        private void btnSMS_Click(object sender, EventArgs e)
        {
            openChildForm(new FormSMS());
            HideSubMenu();
        }
    }
}

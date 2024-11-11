﻿using InterfazdeUsuario.models;
using InterfazdeUsuario.Service;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;



namespace InterfazdeUsuario.Formularios
{
    public partial class FrmLogin : MetroFramework.Forms.MetroForm
    {

        LoginService loginService = new LoginService();
        Admin admin;

        public FrmLogin()
        {
            InitializeComponent();
            
        }

        public void AparienciaForm()
        {
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Style = MetroFramework.MetroColorStyle.Default;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = tbUser.Text;
            string password = TbPassword.Text;
            //this.Close();

            if (loginService.Authenticate(user, password))
            {
                
                FrmAdmin admin = new FrmAdmin();
                admin.ShowDialog();

                

            }
            else
            {

                string checkUser = loginService.GetUser();
                string checkPassword = loginService.Getpassword();
                if(checkUser != null && user != checkUser )
                {
                    MetroMessageBox.Show(this,"Usuario Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(checkPassword != null && password != checkPassword)
                {
                    MetroMessageBox.Show(this, "Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MetroMessageBox.Show(this, "Usuario y contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                   
            }
        }
    }
}

using InterfazdeUsuario.Formularios;
using Spire.Additions.Xps.Schema;
using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using InterfazdeUsuario.Service;

namespace InterfazdeUsuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //imagenDelForm();
            this.Text =string.Empty;
            this.DoubleBuffered = true;
            //el maxomizado de la pantalal igual al area de trabajo
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            //ManualDeAyuda();
        }

        

        private void btnAbout_Click(object sender, EventArgs e)
        {

            FrmAbout frm = new FrmAbout();
            frm.Show();
           
        }

        

        private void btnAyuda_Click_1(object sender, EventArgs e)
        {
            MnualDeAyuda ayuda = new MnualDeAyuda();
            ayuda.ManualDeAyuda();


        }

        private void btnAbout_Click_1(object sender, EventArgs e)
        {
            FrmAbout frm = new FrmAbout();
            frm.Show();
        }

        private void btnMiembros_MouseHover(object sender, EventArgs e)
        {
            btnMiembros.BackColor = Color.LightGray;
        }

        private void btnMiembros_MouseLeave(object sender, EventArgs e)
        {
            btnMiembros.BackColor = Color.FromArgb(18, 27, 31);
        }

        private void btnAdministrador_MouseHover(object sender, EventArgs e)
        {
            btnAdministrador.BackColor = Color.LightGray;

        }

        private void btnAdministrador_MouseLeave(object sender, EventArgs e)
        {

            btnAdministrador.BackColor = Color.FromArgb(18, 27, 31);

        }

        private void btnAyuda_MouseHover(object sender, EventArgs e)
        {

           btnAyuda.BackColor = Color.LightGray;

        }

        private void btnAyuda_MouseLeave(object sender, EventArgs e)
        {
            btnAyuda.BackColor = Color.FromArgb(18, 27, 31);

        }

        private void btnAbout_MouseHover(object sender, EventArgs e)
        {
            btnAbout.BackColor = Color.LightGray;
        }

        private void btnAbout_MouseLeave(object sender, EventArgs e)
        {
            btnAbout.BackColor = Color.FromArgb(18, 27, 31);
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            AdminForm admin = new AdminForm();
            admin.Show();
        }
    }
}

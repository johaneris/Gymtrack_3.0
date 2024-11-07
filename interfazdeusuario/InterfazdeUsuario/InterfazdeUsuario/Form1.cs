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

namespace InterfazdeUsuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            imagenDelForm();
            this.Text =string.Empty;
            this.DoubleBuffered = true;
            //el maxomizado de la pantalal igual al area de trabajo
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            ManualDeAyuda();
        }

        private void ManualDeAyuda()
        {

            //El paquete Spire.PDF permite la manipulación avanzada de archivos PDF en .NET sin requerir programas externos. En este caso, facilita la apertura, carga y guardado del PDF directamente desde el código. 


            //crear una ruta del archivo, basicamente el nombre del archivo

            //string rutaDePDF = "C:\\Users\\naole\\OneDrive\\gymtrack\\GymTrack\\interfazdeusuario\\InterfazdeUsuario\\RecursosUsadosManual\\Manual_de Usuario_de_Gymtrack.pdf";
            string rutaDePDF = "Manual_de Usuario_de_Gymtrack.pdf";

            //El paquete spire permine la manipulacion de archivps  usando objettos de la clase pdf document, asi creamos un nuevo documento

            PdfDocument pdfDocument = new PdfDocument();

            pdfDocument.LoadFromFile(rutaDePDF);

            //se guarda en una ubicacion temporal =. permit que se gener una copia del pdf

            //string rutaTemporal = "ManualUsuarioTemp.pdf";
            pdfDocument.SaveToFile(rutaDePDF);

            //process.start abre el archivo en el programapredeterminado del sistema 

            Process.Start(rutaDePDF);

            //liberar memoria y reucursos asignados

            pdfDocument.Close();


        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

            FrmAbout frm = new FrmAbout();
            frm.Show();
           
        }

        private void imagenDelForm()
        {
            Bitmap imagen = new Bitmap(Application.StartupPath + @"\imagenes\433002419_6916968025079610_1357578493705198718_n.jpg");
            this.BackgroundImage = imagen;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnAyuda_Click_1(object sender, EventArgs e)
        {
            ManualDeAyuda();
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
    }
}

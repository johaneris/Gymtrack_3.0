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



namespace InterfazdeUsuario.Service
{
    public class MnualDeAyuda
    {

        public void ManualDeAyuda()
        {

            //El paquete Spire.PDF permite la manipulación avanzada de archivos PDF en .NET sin requerir programas externos. En este caso, facilita la apertura, carga y guardado del PDF directamente desde el código. 


            //crear una ruta del archivo, basicamente el nombre del archivo

            //string rutaDePDF = "C:\\Users\\naole\\OneDrive\\gymtrack\\GymTrack\\interfazdeusuario\\InterfazdeUsuario\\RecursosUsadosManual\\Manual_de Usuario_de_Gymtrack.pdf";
            string pdfPath = "Manual_de Usuario_de_Gymtrack.pdf";
            //El paquete spire permine la manipulacion de archivps  usando objettos de la clase pdf document, asi creamos un nuevo documento

            PdfDocument pdfDocument = new PdfDocument();

            try {
                

                pdfDocument.LoadFromFile(pdfPath);

                //se guarda en una ubicacion temporal =. permit que se gener una copia del pdf

                //string rutaTemporal = "ManualUsuarioTemp.pdf";
                pdfDocument.SaveToFile(pdfPath);

                //process.start abre el archivo en el programapredeterminado del sistema 

                Process.Start(pdfPath);

                //liberar memoria y reucursos asignados


            }catch (Exception)
            {
                MessageBox.Show("El archivo no existe :(");
            }
            finally
            {

                pdfDocument.Close();

            }


            //private void imagenDelForm()
            //{
            //    Bitmap imagen = new Bitmap(Application.StartupPath + @"\imagenes\433002419_6916968025079610_1357578493705198718_n.jpg");
            //    this.BackgroundImage = imagen;
            //    this.BackgroundImageLayout = ImageLayout.Stretch;
            //}



        }
    }
}

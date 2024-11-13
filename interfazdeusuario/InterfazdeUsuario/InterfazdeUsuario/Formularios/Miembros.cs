using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazdeUsuario.Formularios
{
    public partial class Miembros : MetroFramework.Forms.MetroForm
    {
        public Miembros()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            RegisterStudent student = new RegisterStudent();
            student.ShowDialog();  
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            RegisterExternal external = new RegisterExternal();
            external.ShowDialog();
        }
    }
}

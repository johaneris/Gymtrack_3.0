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
    public partial class AdminForm : MetroFramework.Forms.MetroForm
    {

        public AdminForm()
        {
            InitializeComponent();
            
        }

        public void AparienciaForm()
        {
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Style = MetroFramework.MetroColorStyle.Default;
        }
    }
}

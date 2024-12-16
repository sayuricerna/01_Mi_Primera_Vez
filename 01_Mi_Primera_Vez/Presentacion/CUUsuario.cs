using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Mi_Primera_Vez.Presentacion
{
    public partial class CUUsuario : UserControl
    {
        public CUUsuario()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            Usuario.Frmusuario frmusuario = new Usuario.Frmusuario();
            frmusuario.ShowDialog();
        }
    }
}

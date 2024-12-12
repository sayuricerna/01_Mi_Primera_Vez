using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Mi_Primera_Vez.Presentacion.Usuario
{
    public partial class Frmusuario : Form
    {
        public Frmusuario()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Por favor, comuníquese al +593 980277855 para solicitar usuario y contraseña.",
                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Usted ha ingresado exitosamente al sistema de asistencias");
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase_1_C_
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enfermera Abrirenferm = new Enfermera();

            Abrirenferm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VistaPacientes abrirlista = new VistaPacientes();
            abrirlista.Show();
            this.Hide();
        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            // Si el texto es el placeholder, lo borramos y ponemos la letra negra
            if (txtusuario.Text == "Usuario")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.Black;
            }
        }

        private void txtcontraseña_Enter(object sender, EventArgs e)
        {
            // Si el texto es el placeholder, lo borramos y ponemos la letra negra
            if (txtcontraseña.Text == "Contraseña")
            {
                txtcontraseña.Text = "";
                txtcontraseña.ForeColor = Color.Black;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

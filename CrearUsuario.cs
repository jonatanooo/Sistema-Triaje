using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using Fase_1_C_.Models;

namespace Fase_1_C_
{
    public partial class Crear_Usuario : Form
    {
        public Crear_Usuario()
        {
            InitializeComponent();
        }

        private void txtcrearuser_Enter(object sender, EventArgs e)
        {
            if (txtcrearuser.Text == "Usuario")
            {
                txtcrearuser.Text = "";
                txtcrearuser.ForeColor = Color.Black;
            }
            ;
        }

        private void txtcontracrear_Enter(object sender, EventArgs e)
        {
            if (txtcontracrear.Text == "Contraseña")
            {
                txtcontracrear.Text = "";
                txtcontracrear.ForeColor = Color.Black;
            }
            ;
        }

        private void txtnombres_Enter(object sender, EventArgs e)
        {
            if (txtnombres.Text == "Nombres")
            {
                txtnombres.Text = "";
                txtnombres.ForeColor = Color.Black;
            }
            ;
        }

        private void txtapellidos_Enter(object sender, EventArgs e)
        {
            if (txtapellidos.Text == "Apellidos")
            {
                txtapellidos.Text = "";
                txtapellidos.ForeColor = Color.Black;
            }
            ;
        }

        private void txtDUI_Enter(object sender, EventArgs e)
        {
            if (txtDUI.Text == "DUI")
            {
                txtDUI.Text = "";
                txtDUI.ForeColor = Color.Black;
            }
            ;
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtcrearuser.Text) || string.IsNullOrWhiteSpace(txtcontracrear.Text) || string.IsNullOrWhiteSpace(txtDUI.Text) || string.IsNullOrWhiteSpace(txtnombres.Text) || string.IsNullOrWhiteSpace(txtapellidos.Text) || string.IsNullOrWhiteSpace(cbrol.Text))
            {
                MessageBox.Show("No deje Campos en Blanco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new TriajeClinicoContext())
                {
                    string ContraseñaNueva = txtcontracrear.Text;
                    //Lo encripta
                    string HashContraSegura = BCrypt.Net.BCrypt.HashPassword(ContraseñaNueva);

                    var NuevoUsuario = new Usuario
                    {
                        DuiUsuaio = txtDUI.Text,
                        Nombres = txtnombres.Text,
                        Apellidos = txtapellidos.Text,
                        Username = txtcrearuser.Text,
                        PasswordHash = HashContraSegura,
                        Rol = cbrol.Text
                    };

                    db.Usuarios.Add(NuevoUsuario);
                    db.SaveChanges();

                    MessageBox.Show("Usuario Registrado Con Exito", "Registro Completado", MessageBoxButtons.OK);

                    LimpiarCampos(this);
                   
                }
            }
            catch (Exception ex)
            {
                string MensajeError = ex.Message;
                if (ex.InnerException != null)
                {
                    MensajeError += "\n\nDetalle: " + ex.InnerException.Message;
                }
                MessageBox.Show("Hubo un problema al registrar el usuario.\n\n" + MensajeError, "Error");
            }

        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            Login abrirlogin = new Login();
            abrirlogin.Show();
            this.Hide();
        }

        private void LimpiarCampos(Control controlPadre)
        {
            //foreach recorre los elementos de una secuencia de datos de forma automatica y secuencial
            foreach (Control control in controlPadre.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
                else if (control is RadioButton)
                {
                    ((RadioButton)control).Checked = false;
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                else if (control is NumericUpDown)
                {
                    ((NumericUpDown)control).Value = 0; // O el valor por defecto
                }

                //Si el control tiene otros controles adentro (como un GroupBox),
                // llamamos a la misma función para entrar a buscar ahí también.
                if (control.HasChildren)
                {
                    LimpiarCampos(control);
                }
            }
        }
    }
}


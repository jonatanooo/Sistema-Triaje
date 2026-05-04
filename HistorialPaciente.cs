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
    public partial class HistorialPaciente : Form
    {
        public HistorialPaciente()
        {
            InitializeComponent();
        }

        private void txtbusqueda_Enter(object sender, EventArgs e)
        {
            // Si el texto es el placeholder, lo borramos y ponemos la letra negra
            if (txtbusqueda.Text == "Ingrese ID del Paciente")
            {
                txtbusqueda.Text = "";
                txtbusqueda.ForeColor = Color.Black;
            }
        }
    }
}
